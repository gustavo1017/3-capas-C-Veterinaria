/* Procedimientos almacenados de la tabla cliente*/
create proc sp_insertarCliente
@Dni varchar(50),
@Ndocumento varchar (50),
@Nombre varchar (50),
@Direccion varchar (50),
@Telefono varchar (50) 
as
insert into Cliente values (@Dni,@Ndocumento,@Nombre,@Direccion,@Telefono)


create proc sp_ActualizarCliente
@IdCliente int,
@Dni varchar (50),
@Ndocumento varchar (50),
@Nombre varchar (50),
@Direccion varchar (50),
@Telefono varchar (50)
as
update Cliente
set TipoDocumento= @DNI,NumeroDocumento= @Ndocumento, NombreCliente= @Nombre, DireccionCliente= @Direccion, Telefono= @Telefono
where IdCliente= @IdCliente

create proc sp_EliminarCliente
@IdCliente int 
as
delete from Cliente
where IdCliente=@IdCliente


create proc sp_ListarCliente
as
select IdCliente,TipoDocumento,NumeroDocumento,NombreCliente,DireccionCliente,Telefono from Cliente

create proc sp_BuscarCliente
@IdCliente int 
as
select IdCliente,TipoDocumento,NumeroDocumento,DireccionCliente,Telefono from Cliente
where IdCliente=@IdCliente

exec sp_BuscarCliente 2

exec sp_ListarCliente

exec sp_EliminarCliente 3


exec sp_ActualizarCliente 1,'DNI','74125861','Adrian','av japon 7895','999687429'

select * from Cliente
exec sp_insertarCliente 'DNI','74125869','Juana','av la marina 7895','145687429'


/*Procedimientos de tabla mascota*/


create proc sp_InsertarMascota
@Nombre varchar (50),
@Raza varchar (50),
@IdCliente int
as
insert into Mascota values (@Nombre , @Raza, @IdCliente)

create proc sp_ActualizarMascota
@IdMascota int,
@Nombre varchar (50),
@Raza varchar (50)
as
update Mascota
set NombreMascota=@Nombre,RazaMascota=@Raza
where IdMascota=@IdMascota


create proc sp_EliminarMascota
@IdMascota int
as
delete from Mascota
where IdMascota=@IdMascota

create proc sp_ListarMascota
as
select IdMascota,NombreMascota,RazaMascota,IdCliente from Mascota

create proc sp_BuscarMascota
@IdMascota int
as
select IdMascota,NombreMascota,RazaMascota,IdCliente from Mascota
where IdMascota=@IdMascota

exec sp_BuscarMascota 2
exec sp_ListarMascota
exec sp_EliminarMascota 3

exec sp_ActualizarMascota 2,'pedro','alto'
exec sp_InsertarMascota 'lorenzo','alto',2
select * from Mascota

/*Procedimientos almacenados de la tabla Veterinario*/

create proc sp_InsertarVeterinario
@Dni varchar(50),
@Ndocumento varchar(50),
@Nombre varchar (50),
@Area varchar(50)
as
insert into Veterinario values (@Dni,@Ndocumento,@Nombre,@Area)


create proc sp_ActualizarVeterinario
@IdVeterinario int,
@Dni varchar (50),
@Ndocumento varchar (50),
@Nombre varchar(50),
@Area varchar (50)
as
update Veterinario 
set  TipoDocumento=@Dni, NumeroDocumento=@Ndocumento,NombreVeterinario=@Nombre,AreaTrabajo=@Area
where IdVeterinario=@IdVeterinario


create proc sp_ElimnarVeterinario
@IdVeterinario int 
as 
delete from Veterinario
where IdVeterinario=@IdVeterinario

create proc sp_ListarVeterinario
as
select IdVeterinario,TipoDocumento,NumeroDocumento,NombreVeterinario,AreaTrabajo from Veterinario

create proc sp_BuscarVeterinario
@IdVeterinario int
as
select IdVeterinario,TipoDocumento,NumeroDocumento,NombreVeterinario,AreaTrabajo from Veterinario
where IdVeterinario=@IdVeterinario


exec sp_BuscarVeterinario 2
exec sp_ListarVeterinario 
exec sp_ElimnarVeterinario 4
exec sp_ActualizarVeterinario 1,'DNI','14785123','Carlos',''
exec sp_InsertarVeterinario 'DNI','14778123','Lucia','cirujia'

select * from Veterinario

/*Procedimientos almacenados de tratamiento*/

create proc sp_InsertarTratamiento
@Nombre varchar (50),
@Precio decimal(4,2),
@IdVeterinario int
as
insert into Tratamiento values (@Nombre,@Precio,@IdVeterinario)


create proc sp_ActualizarTratamiento
@IdTratamiento int,
@Nombre varchar (50),
@Precio decimal (4,2)
as
update Tratamiento 
set NombreTratamiento=@Nombre,PrecioTratamiento=@Precio
where IdTratamiento=@IdTratamiento

create proc sp_EliminarTratamiento
@IdTratamiento int 
as
delete from Tratamiento
where IdTratamiento=@IdTratamiento

create proc sp_ListarTratamiento
as
select IdTratamiento,NombreTratamiento,PrecioTratamiento,IdVeterinario from Tratamiento

create proc sp_BuscarTratamiento
@IdTratamiento int 
as
select IdTratamiento,NombreTratamiento,PrecioTratamiento,IdVeterinario from Tratamiento
where IdTratamiento=@IdTratamiento

select * from Tratamiento
exec sp_BuscarTratamiento 2
exec sp_ListarTratamiento
exec sp_EliminarTratamiento 3
exec sp_ActualizarTratamiento  1,'baño completo',25.10
exec sp_InsertarTratamiento 'Terapia patas delanteras',50.5,5


/*Procedimiento almacenados de la tabla tratamiento mascota */
create proc sp_InsertarTratamientoMascota
@IdTratamiento int ,
@IdMascota int ,
@Fecha datetime,
@Precio decimal (4,2)
as
insert into TratamientoMascota values (@IdTratamiento,@IdMascota,@Fecha,@Precio)


create proc sp_ActualizarTratamientoMascota
@IdTratamiento int,
@IdMascota int ,
@Fecha datetime ,
@Precio decimal (4,2)
as
update TratamientoMascota 
set FechaTratamiento=@Fecha,Preciotratamiento=@Precio
where IdTratamiento = @IdTratamiento and IdMascota=@IdMascota


create proc sp_EliminarTratamientoMascota
@IdTratamiento int,
@IdMascota int 
as
delete from TratamientoMascota
where IdTratamiento=@IdTratamiento and IdMascota=@IdMascota

create proc sp_ListarTratamientoMascota
as
select IdTratamiento,IdMascota,FechaTratamiento,Preciotratamiento  from TratamientoMascota


select * from TratamientoMascota


/*Procedimientos almacenados de la tabla veterinaria*/
create proc sp_InsertarVeterinaria
@Nombre varchar (50),
@Direccion varchar(50)
as
insert into Veterinaria values (@Nombre,@Direccion)

create proc sp_ActualizarVeterinaria
@IdVeterianria int ,
@Nombre varchar (50),
@Direccion varchar(50)
as
update Veterinaria 
set NombreVeterinaria=@Nombre,DireccionVeterinaria=@Direccion
where IdVeterinaria=@IdVeterianria

create proc sp_EliminarVeterinaria 
@IdVeterinaria int 
as 
delete from Veterinaria 
where IdVeterinaria=@IdVeterinaria

create proc sp_ListarVeterinaria
as
select IdVeterinaria,NombreVeterinaria,DireccionVeterinaria from Veterinaria

create proc sp_BuscarVeterinaria
@IdVeterinaria int 
as
select IdVeterinaria,NombreVeterinaria,DireccionVeterinaria from Veterinaria
where IdVeterinaria=@IdVeterinaria




select * from Veterinaria