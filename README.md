# sis457_Tienda_Productos_De_Limpieza
Tienda de Productos de Limpieza "ProLimp"
Esta es una tienda que vende productos de limpieza de la linea Unilever, esta tiene una amplia variedad de productos.
Entidades con campos tentativos:
- Producto
id_producto
nombre
descripción
categoría
precio_unitario
stock
unidad_medida 
fecha_vencimiento 
proveedor_id

-Cliente
id_cliente 
nombre
apellido
ci_nit
teléfono
dirección

-Venta
id_venta 
fecha
total
id_cliente 
id_vendedor 

-DetalleVenta
id_detalleVenta
id_venta 
id_producto 
cantidad
subtotal

-Vendedor
id_vendedor 
nombre
apellido
usuario 
contraseña 
teléfono

-Proveedor
id_proveedor (PK)
nombre_empresa
contacto
teléfono
dirección
email

