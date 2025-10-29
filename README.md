# sis457_Tienda_Productos_De_Limpieza
Tienda de Productos de Limpieza "ProLimp"
Esta es una tienda que vende productos de limpieza de la linea Unilever, Muvel, Colgate y demás, esta tiene una amplia variedad de productos.
Entidades finales:
1. UnidadMedida

Propósito: definir cómo se mide cada producto.

- id
  
- descripcion
  
Relación:
•	UnidadMedida puede aplicarse a muchos Productos (1–N)
 
2. Proveedor

Propósito: registrar los datos de quienes venden productos a la tienda.

id

nombreEmpresa

contacto

telefono

direccion

email

Relaciones:
•	Un Proveedor puede tener muchos Productos (1–N)
•	Un Proveedor puede realizar muchas Compras (1–N)

4. Producto
Propósito: almacenar toda la información de los productos que maneja la tienda.

id

idUnidadMedida

idProveedor 

nombre

descripcion

categoria

precioCompra

precioVenta

stock

fechaVencimiento

Relaciones:
•	Pertenece a una Unidad de Medida (N–1)
•	Pertenece a un Proveedor (N–1)
•	Participa en muchos DetallesVenta y muchos DetallesCompra (N–N mediante esas tablas)

6. Empleado
Propósito: registrar al personal que trabaja en la tienda (cajeros, encargados, etc.)

id

nombre

apellido

usuario

contraseña

telefono

rol 

Relaciones:
•	Puede registrar muchas Ventas y Compras (1–N)

8. Cliente
Propósito: registrar a los compradores frecuentes o que requieren facturación.

id

nombre

apellido

cedulaIdentidad

telefono

direccion

Relaciones:
•	Un cliente puede tener muchas Ventas (1–N)

10. Venta
Propósito: registrar la transacción de venta realizada al cliente.

Id

idCliente

idEmpleado

fecha

total

Relaciones:
•	Una Venta tiene muchos DetallesVenta (1–N)
•	Una Venta la realiza un Empleado
•	Una Venta pertenece a un Cliente

12. DetalleVenta
Propósito: registrar los productos vendidos dentro de cada venta.

id

idVenta 

idProducto

cantidad

precioUnitario

subtotal

Relaciones:
•	Pertenece a una Venta (N–1)
•	Se refiere a un Producto (N–1)

14. Compra
Propósito: registrar las compras que hace la tienda a los proveedores.

Id

idProveedor 

idEmpleado 

fecha

total

Relaciones:
•	Una Compra tiene muchos DetallesCompra (1–N)
•	Una Compra la gestiona un Empleado
•	Una Compra pertenece a un Proveedor

16. DetalleCompra
Propósito: registrar los productos incluidos en una compra.

id

idCompra 

idProducto 

cantidad

precioUnitario

subtotal

Relaciones:
•	Pertenece a una Compra (N–1)
•	Se refiere a un Producto (N–1)
