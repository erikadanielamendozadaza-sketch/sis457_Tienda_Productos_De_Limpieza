﻿CREATE DATABASE LabProLimp;
USE master
GO

CREATE LOGIN usrprolimp WITH PASSWORD = '123456',
	CHECK_POLICY = ON,
	CHECK_EXPIRATION = OFF,
	DEFAULT_DATABASE = LabProLimp
GO
USE LabProLimp
GO
CREATE USER usrprolimp FOR LOGIN usrprolimp
GO
ALTER ROLE db_owner ADD MEMBER usrprolimp
GO

DROP TABLE IF EXISTS DetalleCompra;
DROP TABLE IF EXISTS DetalleVenta;
DROP TABLE IF EXISTS Compra;
DROP TABLE IF EXISTS Venta;
DROP TABLE IF EXISTS Producto;
DROP TABLE IF EXISTS Empleado;
DROP TABLE IF EXISTS Proveedor;
DROP TABLE IF EXISTS Cliente;
DROP TABLE IF EXISTS UnidadMedida;


CREATE TABLE UnidadMedida(
	id INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	DESCRIPCION VARCHAR(20) NOT NULL UNIQUE
);

CREATE TABLE Cliente(
	id INT NOT NULL PRIMARY KEY IDENTITY (1, 1),
	nombre VARCHAR (50) NOT NULL,
	apellido VARCHAR (50) NOT NULL,
	cedulaIdentidad VARCHAR (10) NOT NULL,
	telefono BIGINT NOT NULL,
	direccion VARCHAR (250) NULL
	);

CREATE TABLE Proveedor(
	id INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	nombreEmpresa VARCHAR (50) NOT NULL,
	contacto VARCHAR (50) NOT NULL,
	telefono BIGINT NOT NULL,
	direccion VARCHAR (250) NULL,
	email VARCHAR (30) NOT NULL
);

 CREATE TABLE Empleado(
	id INT NOT NULL PRIMARY KEY IDENTITY (1, 1),
	nombre VARCHAR(30) NOT NULL,
	apellido VARCHAR(30) NULL,
	usuario VARCHAR(50) NOT NULL UNIQUE,
	contraseña VARCHAR (100) NOT NULL,
	telefono BIGINT NOT NULL
 );

 CREATE TABLE Producto(
	id INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	idunidadMedida INT NOT NULL,
	idproveedor INT NOT NULL,
	nombre VARCHAR (20) NOT NULL,
	descripcion VARCHAR (100)  NOT NULL,
	categoria VARCHAR (20) NOT NULL,
	precioUnitario DECIMAL NOT NULL CHECK (precioUnitario>0),
	stock INT NOT NULL,
	fechaVencimiento DATE NOT NULL,
	CONSTRAINT fk_Producto_UnidadMedida FOREIGN KEY (idunidadMedida) REFERENCES UnidadMedida(id),
	CONSTRAINT fk_Producto_Proveedor FOREIGN KEY (idProveedor) REFERENCES Proveedor(id)
);

CREATE TABLE Venta(
	id INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	idcliente INT NOT NULL,
	idempleado INT NOT NULL,
	fecha DATE NOT NULL DEFAULT GETDATE(),
	total DECIMAL NOT NULL CHECK (total>0),
	CONSTRAINT fk_Venta_Cliente FOREIGN KEY (idcliente) REFERENCES Cliente(id),
	CONSTRAINT fk_Venta_Empleado FOREIGN KEY (idempleado) REFERENCES Empleado(id)
);

CREATE TABLE Compra(
	id INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	idproveedor INT NOT NULL,
	idempleado INT NOT NULL,
	fecha DATE NOT NULL DEFAULT GETDATE(),
	total DECIMAL NOT NULL,
	CONSTRAINT fk_Compra_Proveedor FOREIGN KEY (idproveedor) REFERENCES Proveedor(id),
	CONSTRAINT fk_Compra_Empleado FOREIGN KEY (idempleado) REFERENCES Empleado(id)
);

CREATE TABLE DetalleVenta(
	id INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	idventa INT NOT NULL,
	idproducto INT NOT NULL,
	cantidad DECIMAL NOT NULL,
	precioUnitario DECIMAL NOT NULL CHECK (precioUnitario>0),
	subtotal DECIMAL NOT NULL,
	CONSTRAINT fk_DetalleVenta_Venta FOREIGN KEY (idventa) REFERENCES Venta(id),
	CONSTRAINT fk_DetalleVenta_Producto FOREIGN KEY (idproducto) REFERENCES Producto(id)
);

CREATE TABLE DetalleCompra(
	id INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	idcompra INT NOT NULL,
	idproducto INT NOT NULL,
	cantidadC DECIMAL NOT NULL CHECK (cantidadC>0),
	precioUnitarioC DECIMAL NOT NULL CHECK (precioUnitarioC>0),
	subtotalCompra DECIMAL NOT NULL CHECK (subtotalCompra>0),
	CONSTRAINT fk_DetalleCompra_Compra FOREIGN KEY (idcompra) REFERENCES Compra(id),
	CONSTRAINT fk_DetalleCompra_Producto FOREIGN KEY (idproducto) REFERENCES Producto(id)
);

ALTER TABLE UnidadMedida ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE UnidadMedida ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE UnidadMedida ADD estado SMALLINT NOT NULL DEFAULT 1;

ALTER TABLE Cliente ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Cliente ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Cliente ADD estado SMALLINT NOT NULL DEFAULT 1;

ALTER TABLE Proveedor ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Proveedor ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Proveedor ADD estado SMALLINT NOT NULL DEFAULT 1;

ALTER TABLE Empleado ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Empleado ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Empleado ADD estado SMALLINT NOT NULL DEFAULT 1;

ALTER TABLE Producto ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Producto ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Producto ADD estado SMALLINT NOT NULL DEFAULT 1;

ALTER TABLE Venta ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Venta ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Venta ADD estado SMALLINT NOT NULL DEFAULT 1;

ALTER TABLE Compra ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Compra ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Compra ADD estado SMALLINT NOT NULL DEFAULT 1;

ALTER TABLE DetalleVenta ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE DetalleVenta ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE DetalleVenta ADD estado SMALLINT NOT NULL DEFAULT 1;

ALTER TABLE DetalleCompra ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE DetalleCompra ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE DetalleCompra ADD estado SMALLINT NOT NULL DEFAULT 1;

GO
DROP PROC IF EXISTS paUnidadMedidaListar;
GO
CREATE PROC paUnidadMedidaListar @parametro VARCHAR(50)
AS
BEGIN
    SELECT 
        um.id, um.descripcion, um.usuarioRegistro, um.fechaRegistro, um.estado
    FROM UnidadMedida um
    WHERE um.estado > -1 
      AND um.descripcion LIKE '%' + REPLACE(@parametro, ' ', '%') + '%'
    ORDER BY um.estado DESC, um.descripcion ASC;
END;
GO

EXEC paUnidadMedidaListar '';

GO
DROP PROC IF EXISTS paClienteListar;
GO
CREATE PROC paClienteListar @parametro VARCHAR(50)
AS
BEGIN
    SELECT 
        c.id, c.nombre, c.apellido, c.cedulaIdentidad, c.telefono, c.direccion, c.usuarioRegistro, c.fechaRegistro, c.estado
    FROM Cliente c
    WHERE c.estado > -1 
      AND (c.nombre + c.apellido + c.cedulaIdentidad + ISNULL(c.direccion, '')) LIKE '%' + REPLACE(@parametro, ' ', '%') + '%'
    ORDER BY c.estado DESC, c.nombre ASC;
END;
GO

EXEC paClienteListar '';

GO
DROP PROC IF EXISTS paProveedorListar;
GO
CREATE PROC paProveedorListar @parametro VARCHAR(50)
AS
BEGIN
    SELECT pr.id, pr.nombreEmpresa, pr.contacto, pr.telefono, pr.direccion, pr.email, pr.usuarioRegistro, pr.fechaRegistro, pr.estado
    FROM Proveedor pr
    WHERE pr.estado > -1 
      AND (pr.nombreEmpresa + pr.contacto + pr.email + ISNULL(pr.direccion, '')) LIKE '%' + REPLACE(@parametro, ' ', '%') + '%'
    ORDER BY pr.estado DESC, pr.nombreEmpresa ASC;
END;
GO

EXEC paProveedorListar '';

GO
DROP PROC IF EXISTS paEmpleadoListar;
GO
CREATE PROC paEmpleadoListar @parametro VARCHAR(50)
AS
BEGIN
    SELECT 
        e.id, e.nombre, e.apellido, e.usuario, e.telefono, e.usuarioRegistro, e.fechaRegistro, e.estado
    FROM Empleado e
    WHERE e.estado > -1 
      AND (e.nombre + ISNULL(e.apellido, '') + e.usuario) LIKE '%' + REPLACE(@parametro, ' ', '%') + '%'
    ORDER BY e.estado DESC, e.nombre ASC;
END;
GO

EXEC paEmpleadoListar '';

GO
DROP PROC IF EXISTS paProductoListar;
GO
CREATE PROC paProductoListar @parametro VARCHAR(50)
AS
BEGIN
    SELECT 
        p.id, p.idunidadMedida, p.nombre AS codigo,  p.descripcion, um.descripcion AS unidadMedida, p.stock AS saldo,  
        p.precioUnitario AS precioVenta, p.usuarioRegistro, p.fechaRegistro, p.estado
    FROM Producto p
    INNER JOIN UnidadMedida um ON um.id = p.idunidadMedida
    WHERE p.estado > -1 
      AND (p.nombre + p.descripcion + um.descripcion) LIKE '%' + REPLACE(@parametro, ' ', '%') + '%' 
    ORDER BY p.estado DESC, p.descripcion ASC;
END;
GO

EXEC paProductoListar '';

GO
DROP PROC IF EXISTS paVentaListar;
GO
CREATE PROC paVentaListar @parametro VARCHAR(50)
AS
BEGIN
    SELECT 
        v.id, v.idcliente, v.idempleado, v.fecha, v.total, v.usuarioRegistro, v.fechaRegistro, v.estado
    FROM Venta v
    WHERE v.estado > -1 
      AND CAST(v.fecha AS VARCHAR) + CAST(v.total AS VARCHAR) LIKE '%' + REPLACE(@parametro, ' ', '%') + '%'
    ORDER BY v.estado DESC, v.fecha DESC;
END;
GO

EXEC paVentaListar '';

GO
DROP PROC IF EXISTS paCompraListar;
GO
CREATE PROC paCompraListar @parametro VARCHAR(50)
AS
BEGIN
    SELECT 
        co.id, co.idproveedor, co.idempleado, co.fecha, co.total, co.usuarioRegistro, co.fechaRegistro,  co.estado
    FROM Compra co
    WHERE co.estado > -1 
      AND CAST(co.fecha AS VARCHAR) + CAST(co.total AS VARCHAR) LIKE '%' + REPLACE(@parametro, ' ', '%') + '%'
    ORDER BY co.estado DESC, co.fecha DESC;
END;
GO

EXEC paCompraListar '';

GO
DROP PROC IF EXISTS paDetalleVentaListar;
GO
CREATE PROC paDetalleVentaListar @parametro VARCHAR(50)
AS
BEGIN
    SELECT 
        dv.id, dv.idventa, dv.idproducto, dv.cantidad, dv.precioUnitario, dv.subtotal, dv.usuarioRegistro, dv.fechaRegistro, dv.estado
    FROM DetalleVenta dv
    WHERE dv.estado > -1 
      AND (CAST(dv.cantidad AS VARCHAR) + CAST(dv.precioUnitario AS VARCHAR) + CAST(dv.subtotal AS VARCHAR)) LIKE '%' + REPLACE(@parametro, ' ', '%') + '%'
    ORDER BY dv.estado DESC, dv.id ASC;
END;
GO

EXEC paDetalleVentaListar '';

GO
DROP PROC IF EXISTS paDetalleCompraListar;
GO
CREATE PROC paDetalleCompraListar @parametro VARCHAR(50)
AS
BEGIN
    SELECT 
        dc.id, dc.idcompra, dc.idproducto, dc.cantidadC, dc.precioUnitarioC, dc.subtotalCompra, dc.usuarioRegistro, dc.fechaRegistro, dc.estado
    FROM DetalleCompra dc
    WHERE dc.estado > -1 
      AND (CAST(dc.cantidadC AS VARCHAR) + CAST(dc.precioUnitarioC AS VARCHAR) + CAST(dc.subtotalCompra AS VARCHAR)) LIKE '%' + REPLACE(@parametro, ' ', '%') + '%'
    ORDER BY dc.estado DESC, dc.id ASC;
END;
GO

EXEC paDetalleCompraListar '';