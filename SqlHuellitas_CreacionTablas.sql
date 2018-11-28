USE [master]
GO


CREATE DATABASE [Huellitas]

 ON  PRIMARY 
( NAME = N'Practica_Data', 
FILENAME = N'C:\SQLData\Huellitas_Data.mdf' , 
SIZE = 10mb , 
MAXSIZE = UNLIMITED, 
FILEGROWTH = 2mb )
 LOG ON 
( NAME = N'Huellitas_log', 
FILENAME = N'C:\SQLData\Huellitas_log.ldf' , 
SIZE = 5mb , 
MAXSIZE = 2048mb , 
FILEGROWTH = 10%)
GO

create table dbo.Veterinario(
IdVeterinario int identity(1,1) not null ,
TipoDocumento varchar (50)not null,
NumeroDocumento varchar (50)not null,
NombreVeterinario varchar(50)not null,
AreaTrabajo varchar (50)
constraint PK_Veterinario primary key (IdVeterinario)
)
go
create table dbo.Tratamiento(
IdTratamiento int identity(1,1) not null ,
NombreTratamiento varchar(50)not null,
PrecioTratamiento decimal (4,2)not null,
IdVeterinario int not null
constraint PK_Tratamiento primary key (IdTratamiento)
)
go
create table dbo.TratamientoMascota(
IdTratamiento int not null ,
IdMascota int not null ,
FechaTratamiento datetime not null,
Preciotratamiento decimal (4,2)not null
constraint PK_TratamientoMascota primary key (IdTratamiento,IdMascota)
)
go
create table dbo.Mascota(
IdMascota int not null identity(1,1),
NombreMascota varchar (50)not null,
RazaMascota varchar(50)  null,
IdCliente int not null
constraint PK_Mascota primary key (IdMascota)
)
go
create table dbo.Cliente(
 IdCliente int identity(1,1) not null ,
 TipoDocumento varchar(50) not null,
 NumeroDocumento varchar(50)not null,
 NombreCliente varchar(50)not null,
 DireccionCliente varchar(50) null,
 Telefono varchar(50) null
 constraint PK_Cliente primary key(IdCliente)
 )
 go
 create table dbo.ClienteProducto(
 IdCliente int identity(1,1) not null,
 IdProducto int not null,
 FechaCompra datetime not null,
 CantidadProducto int not null,
 PrecioVenta decimal (4,2)
 constraint PK_ClienteProducto primary key(IdCliente,IdProducto)
 )
 go
 create table dbo.Producto(
 IdProducto int identity(1,1) not null,
 NombreProducto varchar(50) not null,
 PrecioProducto decimal (4,2) not null,
 IdVeterinaria int not null
 constraint PK_Producto primary key(IdProducto)
 )
 go
 create table dbo.ProveedorProducto(
 IdProducto int identity(1,1) not null,
 IdProveedor int not null,
 FechaCompra datetime not null,
 CantidadProducto varchar (50) not null,
 PrecioVenta decimal (4,2)
 constraint PK_FacturaProveedor primary key (IdProducto,IdProveedor)
 )
go
 create table dbo.Proveedor(
 IdProveedor int identity(1,1) not null,
 NombreProveedor varchar (50)not null
 constraint PK_Proveedor primary key (IdProveedor)
 )
 go
 create table dbo.Veterinaria(
 IdVeterinaria int identity(1,1) not null,
 NombreVeterinaria varchar(50)not null,
 DireccionVeterinaria varchar (50) null
 constraint PK_Veterinaria primary key (IdVeterinaria)
 )
 go
  alter table dbo.TratamientoMascota
 add constraint FK_Mascota
 foreign key (IdMascota)
 references dbo.Mascota(IdMascota)
 go
 alter table dbo.TratamientoMascota
 add constraint FK_Tratamiento
 foreign key (IdTratamiento)
 references dbo.Tratamiento(IdTratamiento)
 go


 
 alter table dbo.ClienteProducto
 add constraint FK_Cliente
 foreign key (IdCliente)
 references dbo.Cliente(IdCliente)

 alter table dbo.ClienteProducto
 add constraint FK_Producto
 foreign key (IdProducto)
 references dbo.Producto(IdProducto)

 alter table dbo.ProveedorProducto
 add constraint FK_Producto
 foreign key(IdProducto)
 references dbo.Producto(IdProducto)

 alter table dbo.ProveedorProducto
 add constraint FK_proveedor
 foreign key (IdProveedor)
 references dbo.Proveedor(IdProveedor)

 
