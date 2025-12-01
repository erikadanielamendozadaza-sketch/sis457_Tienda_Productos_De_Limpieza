using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProLimp.Models;

namespace WebProLimp.Controllers
{
    public class VentasController : Controller
    {
        private readonly LabProLimpContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public VentasController(LabProLimpContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        // GET: Ventas
        public async Task<IActionResult> Index()
        {
            var labProLimpContext = _context.Venta.Include(v => v.IdclienteNavigation).Include(v => v.IdempleadoNavigation).Include(v => v.DetalleVenta);
            return View(await labProLimpContext.ToListAsync());
        }

        // GET: Ventas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var venta = await _context.Venta
                .Include(v => v.IdclienteNavigation)
                .Include(v => v.IdempleadoNavigation)
                .Include(v => v.DetalleVenta).ThenInclude(d => d.IdproductoNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (venta == null)
            {
                return NotFound();
            }
            return View(venta);
        }

        // GET: Ventas/Create
        public IActionResult Create()
        {
            ViewData["Idcliente"] = new SelectList(_context.Cliente, "Id", "CedulaIdentidad");
            ViewData["Productos"] = _context.Producto.Where(p => p.Estado == 1).ToList() ?? new List<Producto>();
            ViewBag.Empleado = "Empleado"; // Hardcodeado sin auth
            return View();
        }

        // AJAX: Buscar productos
        [HttpGet]
        public JsonResult BuscarProductos(string parametro)
        {
            var productos = _context.Producto
                .Where(p => p.Nombre.Contains(parametro) || p.Codigo.Contains(parametro))
                .Select(p => new { p.Id, p.Nombre, p.PrecioUnitario, p.Stock })
                .ToList();
            return Json(productos);
        }

        // AJAX: Buscar cliente por CI
        [HttpGet]
        public JsonResult BuscarCliente(string ci)
        {
            var cliente = _context.Cliente.FirstOrDefault(c => c.CedulaIdentidad == ci);
            if (cliente != null)
                return Json(new { id = cliente.Id, nombre = cliente.RazonSocial });
            return Json(null);
        }

        // AJAX: Obtener carrito actual (para cargar en vista) - Renombrado para evitar conflicto
        [HttpGet]
        public JsonResult ObtenerCarrito()
        {
            var carrito = GetCarrito(); // Usa el método privado
            return Json(carrito.Select(d => new
            {
                d.Idproducto,
                d.Cantidad,
                d.PrecioUnitario,
                d.Subtotal,
                ProductoNombre = d.IdproductoNavigation?.Nombre ?? "Producto"
            }));
        }

        // Métodos para carrito en sesión (privados)
        private List<DetalleVenta> GetCarrito()
        {
            var session = _httpContextAccessor.HttpContext.Session;
            var carritoJson = session.GetString("Carrito");
            return carritoJson == null ? new List<DetalleVenta>() : JsonConvert.DeserializeObject<List<DetalleVenta>>(carritoJson);
        }

        private void SaveCarrito(List<DetalleVenta> carrito)
        {
            var session = _httpContextAccessor.HttpContext.Session;
            session.SetString("Carrito", JsonConvert.SerializeObject(carrito));
        }

        // AJAX: Agregar al carrito
        [HttpPost]
        public JsonResult AddToCart(int idProducto, decimal cantidad)
        {
            var producto = _context.Producto.Find(idProducto);
            if (producto == null) return Json(new { success = false, message = "Producto no encontrado" });
            var carrito = GetCarrito();
            var detalle = carrito.FirstOrDefault(d => d.Idproducto == idProducto);
            decimal cantidadTotal = detalle?.Cantidad + cantidad ?? cantidad;
            if (cantidadTotal > producto.Stock)
                return Json(new { success = false, message = $"Stock insuficiente. Disponible: {producto.Stock}" });
            if (detalle != null)
            {
                detalle.Cantidad = cantidadTotal;
                detalle.Subtotal = detalle.Cantidad * detalle.PrecioUnitario;
            }
            else
            {
                carrito.Add(new DetalleVenta
                {
                    Idproducto = idProducto,
                    Cantidad = cantidad,
                    PrecioUnitario = producto.PrecioUnitario,
                    Subtotal = cantidad * producto.PrecioUnitario,
                    IdproductoNavigation = producto
                });
            }
            SaveCarrito(carrito);
            return Json(new { success = true, total = carrito.Sum(d => d.Subtotal) });
        }

        // AJAX: Quitar del carrito
        [HttpPost]
        public JsonResult RemoveFromCart(int idProducto)
        {
            var carrito = GetCarrito();
            carrito.RemoveAll(d => d.Idproducto == idProducto);
            SaveCarrito(carrito);
            return Json(new { success = true, total = carrito.Sum(d => d.Subtotal) });
        }

        // AJAX: Modificar cantidad
        [HttpPost]
        public JsonResult UpdateCantidad(int idProducto, decimal nuevaCantidad)
        {
            var carrito = GetCarrito();
            var detalle = carrito.FirstOrDefault(d => d.Idproducto == idProducto);
            if (detalle == null) return Json(new { success = false });
            var producto = _context.Producto.Find(idProducto);
            if (nuevaCantidad > producto.Stock)
                return Json(new { success = false, message = $"Stock insuficiente. Disponible: {producto.Stock}" });
            detalle.Cantidad = nuevaCantidad;
            detalle.Subtotal = nuevaCantidad * detalle.PrecioUnitario;
            SaveCarrito(carrito);
            return Json(new { success = true, subtotal = detalle.Subtotal, total = carrito.Sum(d => d.Subtotal) });
        }

        // AJAX: Limpiar carrito
        [HttpPost]
        public IActionResult LimpiarCarrito()
        {
            _httpContextAccessor.HttpContext.Session.Remove("Carrito");
            return Json(new { success = true });
        }

        // POST: Registrar venta
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int idCliente, [Bind("Fecha")] Venta venta)
        {
            Console.WriteLine("Iniciando registro de venta..."); // Logging básico

            var carrito = GetCarrito();
            if (!carrito.Any())
            {
                Console.WriteLine("Carrito vacío");
                TempData["Error"] = "Carrito vacío";
                return RedirectToAction("Create");
            }

            var cliente = _context.Cliente.Find(idCliente);
            if (cliente == null)
            {
                Console.WriteLine($"Cliente no encontrado: {idCliente}");
                TempData["Error"] = "Cliente no encontrado";
                return RedirectToAction("Create");
            }

            venta.Idcliente = idCliente;
            venta.Idempleado = GetCurrentEmpleadoId();
            venta.Total = carrito.Sum(d => d.Subtotal);
            venta.DetalleVenta = carrito.Select(d => new DetalleVenta
            {
                Idproducto = d.Idproducto,
                Cantidad = d.Cantidad,
                PrecioUnitario = d.PrecioUnitario,
                Subtotal = d.Subtotal,
                UsuarioRegistro = "Sistema",
                FechaRegistro = DateTime.Now,
                Estado = 1
            }).ToList();

            if (validar(venta))
            {
                try
                {
                    venta.FechaRegistro = DateTime.Now;
                    venta.Estado = 1;
                    venta.UsuarioRegistro = "Sistema";

                    Console.WriteLine("Guardando venta...");
                    _context.Add(venta);
                    await _context.SaveChangesAsync();
                    Console.WriteLine($"Venta guardada con ID: {venta.Id}");

                    // Actualizar stock
                    foreach (var det in venta.DetalleVenta)
                    {
                        var prod = await _context.Producto.FindAsync(det.Idproducto);
                        if (prod != null)
                        {
                            prod.Stock -= (int)det.Cantidad;
                            Console.WriteLine($"Stock actualizado para producto {det.Idproducto}: -{(int)det.Cantidad}");
                        }
                    }
                    await _context.SaveChangesAsync();

                    _httpContextAccessor.HttpContext.Session.Remove("Carrito");
                    Console.WriteLine("Redirigiendo a Factura...");
                    return RedirectToAction("Factura", new { idVenta = venta.Id });
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al guardar: {ex.Message}");
                    TempData["Error"] = $"Error al guardar: {ex.Message}";
                    return RedirectToAction("Create");
                }
            }
            else
            {
                Console.WriteLine("Validación fallida");
                TempData["Error"] = "Datos inválidos";
                return RedirectToAction("Create");
            }
        }

        // Método de validación personalizado
        private bool validar(Venta venta)
        {
            return
                venta.Idcliente > 0 &&
                venta.Idempleado > 0 &&
                venta.Total > 0 &&
                venta.DetalleVenta != null && venta.DetalleVenta.Any();
        }

        // GET: Mostrar factura
        public async Task<IActionResult> Factura(int idVenta)
        {
            var venta = await _context.Venta
                .Include(v => v.IdclienteNavigation)
                .Include(v => v.DetalleVenta).ThenInclude(d => d.IdproductoNavigation)
                .FirstOrDefaultAsync(v => v.Id == idVenta);
            if (venta == null) return NotFound();
            return View(venta);
        }

        // GET: Ventas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var venta = await _context.Venta.FindAsync(id);
            if (venta == null)
            {
                return NotFound();
            }
            ViewData["Idcliente"] = new SelectList(_context.Cliente, "Id", "Id", venta.Idcliente);
            ViewData["Idempleado"] = new SelectList(_context.Empleado, "Id", "Id", venta.Idempleado);
            return View(venta);
        }

        // POST: Ventas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Idcliente,Idempleado,Fecha,Total,UsuarioRegistro,FechaRegistro,Estado")] Venta venta)
        {
            if (id != venta.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(venta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VentaExists(venta.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["Idcliente"] = new SelectList(_context.Cliente, "Id", "Id", venta.Idcliente);
            ViewData["Idempleado"] = new SelectList(_context.Empleado, "Id", "Id", venta.Idempleado);
            return View(venta);
        }

        // GET: Ventas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var venta = await _context.Venta
                .Include(v => v.IdclienteNavigation)
                .Include(v => v.IdempleadoNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (venta == null)
            {
                return NotFound();
            }
            return View(venta);
        }

        // POST: Ventas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var venta = await _context.Venta.FindAsync(id);
            if (venta != null)
            {
                _context.Venta.Remove(venta);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VentaExists(int id)
        {
            return _context.Venta.Any(e => e.Id == id);
        }

        // Método auxiliar para obtener ID de empleado (hardcodeado sin auth)
        private int GetCurrentEmpleadoId()
        {
            return 1; // Cambia por un ID real de empleado en tu DB
        }
    }
}
