# sis457_Tienda_Productos_De_Limpieza
Tienda de Productos de Limpieza "ProLimp"
Esta es una tienda que vende productos de limpieza de la linea Unilever, Muvel, Colgate y demás, todo para el cuidado del cliente y el hogar.
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

telefono

direccion

email

Relaciones:
•	Un Proveedor puede tener muchos Productos (1–N)
•	Un Proveedor puede realizar muchas Compras (1–N)

3. Producto
Propósito: almacenar toda la información de los productos que maneja la tienda.

id

idUnidadMedida

idProveedor 

idcategoria

idmarca

codigo

nombre

precioUnitario

stock

fechaVencimiento

cantidadMinimaStock

Relaciones:
•	Pertenece a una Unidad de Medida (N–1)
•	Pertenece a un Proveedor (N–1)
•	Participa en muchos DetallesVenta(N–N mediante esas tablas)

4. Empleado
Propósito: registrar al personal que trabaja en la tienda (cajeros, encargados, etc.)

id

nombres

primerApellido

segundoApellido

cedulaIdentidad

usuario

clave

telefono

Relaciones:
•	Puede registrar muchas Ventas(1–N)

5. Cliente
Propósito: registrar a los compradores frecuentes o que requieren facturación.

id

razonSocial

cedulaIdentidad

Relaciones:
•	Un cliente puede tener muchas Ventas (1–N)

6. Venta
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

7. DetalleVenta
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

8.Marca
Propósito: identificar la marca del producto (Unilever, Colgate, etc.)

id

nombre

Relaciones:
Una Marca puede tener muchos Productos (1–N)

9.Categoría
Propósito: clasificar los productos según su tipo (ej. detergentes, jabones, desinfectantes).

id

nombre

Relaciones:

Una Categoría puede contener muchos Productos (1–N)

Un producto tiene una categoria (N-1)
