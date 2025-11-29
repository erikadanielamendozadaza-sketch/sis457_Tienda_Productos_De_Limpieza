using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebProLimp.Models;

namespace WebProLimp.Controllers
{
    public class ProductosController : Controller
    {
        private readonly LabProLimpContext _context;

        public ProductosController(LabProLimpContext context)
        {
            _context = context;
        }

        // GET: Productos
        public async Task<IActionResult> Index()
        {
            var labProLimpContext = _context.Producto
                .Include(p => p.IdcategoriaNavigation)
                .Include(p => p.IdmarcaNavigation)
                .Include(p => p.IdproveedorNavigation)
                .Include(p => p.IdunidadMedidaNavigation)
                .Where(p => p.Estado == 1)
                .OrderBy(p => p.Nombre);

            return View(await labProLimpContext.ToListAsync());
        }

        // GET: Productos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Producto
                .Include(p => p.IdcategoriaNavigation)
                .Include(p => p.IdmarcaNavigation)
                .Include(p => p.IdproveedorNavigation)
                .Include(p => p.IdunidadMedidaNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // GET: Productos/Create
        public IActionResult Create()
        {
            ViewData["Idcategoria"] = new SelectList(_context.Categoria, "Id", "Nombre");
            ViewData["Idmarca"] = new SelectList(_context.Marca, "Id", "Nombre");
            ViewData["Idproveedor"] = new SelectList(_context.Proveedor, "Id", "NombreEmpresa");
            ViewData["IdunidadMedida"] = new SelectList(_context.UnidadMedida, "Id", "Descripcion");
            return View();
        }

        private bool validar(Producto producto)
        {
            return
                !string.IsNullOrWhiteSpace(producto.Codigo) &&
                !string.IsNullOrWhiteSpace(producto.Nombre) &&
                producto.Idcategoria != 0 &&
                producto.Idmarca != 0 &&
                producto.Idproveedor != 0 &&
                producto.IdunidadMedida != 0 &&
                producto.PrecioUnitario > 0 &&
                producto.Stock >= 0;
        }

        // POST: Productos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdunidadMedida,Idproveedor,Idcategoria,Idmarca,Codigo,Nombre,PrecioUnitario,Stock,FechaVencimiento,PrecioCompra,CantidadMinimaStock,UsuarioRegistro,FechaRegistro,Estado")] Producto producto)
        {
            if (validar(producto))
            {
                producto.FechaRegistro = DateTime.Now;
                producto.Estado = 1;

                _context.Add(producto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["Idcategoria"] = new SelectList(_context.Categoria, "Id", "Nombre", producto.Idcategoria);
            ViewData["Idmarca"] = new SelectList(_context.Marca, "Id", "Nombre", producto.Idmarca);
            ViewData["Idproveedor"] = new SelectList(_context.Proveedor, "Id", "NombreEmpresa", producto.Idproveedor);
            ViewData["IdunidadMedida"] = new SelectList(_context.UnidadMedida, "Id", "Descripcion", producto.IdunidadMedida);

            return View(producto);
        }

        // GET: Productos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Producto.FindAsync(id);
            if (producto == null)
            {
                return NotFound();
            }

            ViewData["Idcategoria"] = new SelectList(_context.Categoria, "Id", "Nombre", producto.Idcategoria);
            ViewData["Idmarca"] = new SelectList(_context.Marca, "Id", "Nombre", producto.Idmarca);
            ViewData["Idproveedor"] = new SelectList(_context.Proveedor, "Id", "NombreEmpresa", producto.Idproveedor);
            ViewData["IdunidadMedida"] = new SelectList(_context.UnidadMedida, "Id", "Descripcion", producto.IdunidadMedida);

            return View(producto);
        }

        // POST: Productos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdunidadMedida,Idproveedor,Idcategoria,Idmarca,Codigo,Nombre,PrecioUnitario,Stock,FechaVencimiento,PrecioCompra,CantidadMinimaStock,UsuarioRegistro,FechaRegistro,Estado")] Producto producto)
        {
            if (id != producto.Id)
            {
                return NotFound();
            }

            if (validar(producto))
            {
                try
                {
                    _context.Update(producto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductoExists(producto.Id))
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
            ViewData["Idcategoria"] = new SelectList(_context.Categoria, "Id", "Nombre", producto.Idcategoria);
            ViewData["Idmarca"] = new SelectList(_context.Marca, "Id", "Nombre", producto.Idmarca);
            ViewData["Idproveedor"] = new SelectList(_context.Proveedor, "Id", "NombreEmpresa", producto.Idproveedor);
            ViewData["IdunidadMedida"] = new SelectList(_context.UnidadMedida, "Id", "Descripcion", producto.IdunidadMedida);
            return View(producto);
        }

        // GET: Productos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Producto
                .Include(p => p.IdcategoriaNavigation)
                .Include(p => p.IdmarcaNavigation)
                .Include(p => p.IdproveedorNavigation)
                .Include(p => p.IdunidadMedidaNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // POST: Productos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producto = await _context.Producto.FindAsync(id);
            if (producto != null)
            {
                producto.Estado = -1;
                _context.Update(producto);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductoExists(int id)
        {
            return _context.Producto.Any(e => e.Id == id);
        }
    }
}
