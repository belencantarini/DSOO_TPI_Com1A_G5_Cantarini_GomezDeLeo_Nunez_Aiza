-- DSOO: Trabajo Practico Integrador --
-- Comision 1A - Grupo 5 - Cantarini, Gomez De Leo, Nuñez, Aiza

-- Crear la base de datos
drop database if exists DSOO_C1A_G5_TPI_Cantarini_GomezDeLeo_Nunez_Aiza;
create database DSOO_C1A_G5_TPI_Cantarini_GomezDeLeo_Nunez_Aiza;
use DSOO_C1A_G5_TPI_Cantarini_GomezDeLeo_Nunez_Aiza;

-- Crear las tablas del club: Roles, Usuario, Cliente, Socio, NoSocio, Actividad, Pago

create table Roles(
RolUsuario int not null,
NombreRol varchar (30) not null,
constraint pk_rol_usuario primary key (RolUsuario)
)engine=innodb;

create table Usuario(
UsuarioID int auto_increment not null,
Nombre varchar (30) not null,
Pass varchar (15) not null,
RolUsuario int,
Activo boolean default true,
constraint pk_usuario_id primary key (UsuarioID),
constraint fk_rol_usuario foreign key (RolUsuario) references Roles(RolUsuario)
)engine=innodb;

create table Cliente(
ClienteID int auto_increment not null,
Nombre varchar (30) not null,
Apellido varchar (30) not null,
TipoDocumento varchar (15) not null,
NumeroDocumento int not null,
FechaNacimiento date not null,
FechaInscripcion date not null,
AptoFisico bool default false,
constraint pk_cliente_id primary key (ClienteID)
)engine=innodb;

create table Socio(
SocioID int auto_increment not null,
CarnetSocioID varchar(30) null,
ClienteID int not null,
FechaVencimientoCuota date not null,
Activo boolean default false,
constraint pk_socio_id primary key (SocioID),
constraint fk_socio_cliente foreign key (ClienteID) references Cliente(ClienteID)
)engine=innodb;

create table NoSocio(
NoSocioID int auto_increment not null,
ClienteID int not null,
constraint pk_no_socio_id primary key (NoSocioID),
constraint fk_no_socio_cliente foreign key (ClienteID) references Cliente(ClienteID)
)engine=innodb;

create table Actividad(
ActividadID int auto_increment not null,
Nombre varchar (30) not null,
Precio double not null,
constraint pk_actividad_id primary key (ActividadID)
)engine=innodb;

create table Pago(
PagoID int auto_increment not null,
ClienteID int not null,
ActividadID int null,
Monto double not null,
MetodoPago varchar (30) not null,
Cuotas int not null default 1,
FechaPago date not null,
constraint pk_pago_id primary key (PagoID),
constraint fk_pago_cliente foreign key (ClienteID) references Cliente(ClienteID),
constraint fk_inscripcion_actividad foreign key (ActividadID) references Actividad(ActividadID)
)engine=innodb;

/* **************************************************************************************************************************** */

-- Insertar registros de Roles, Usuarios y Actividades

insert into Roles values
(120,'Administrador'),
(121,'Empleado');

insert into Usuario(Nombre, Pass, RolUsuario) values
('Administrador','adm123',120),
('Empleado','usu123',121);

insert into Actividad (Nombre, Precio) values 
('Fútbol', 2000.00),
('Natación', 5000.00),
('Musculacion', 1500.00),
('Tenis', 2000.00);


/* **************************************************************************************************************************** */
-- Procedimientos almacenados
/* **************************************************************************************************************************** */

-- Procedimiento Ingreso Login

-- Cambio el delimitador para poder crear el procedimiendo
delimiter // 

-- Elimino el procedimiento si es que existe
drop procedure if exists DSOO_C1A_G5_TPI_Cantarini_GomezDeLeo_Nunez_Aiza.ingresoLogin//

-- Creo el procedimiento almacenado que requiere de 2 parametros de entrada para ejecutar su logica: El nombre de usuario y su password. 
create procedure ingresoLogin(in UsuarioNombre varchar(30),in UsuarioPass varchar(15))
begin
  select R.NombreRol from Usuario U 
	inner join Roles R on U.RolUsuario = R.RolUsuario
		where U.Nombre = UsuarioNombre and U.Pass = UsuarioPass /* se compara con los parametros */
			and U.Activo = 1; /* el usuario debe estar activo */
end //
delimiter ;

-- Para llamar a mi procedimiento almacenado para el Ingreso LOGIN
-- call ingresoLogin('Administrador','adm123');
-- call ingresoLogin('NoExiste','NoExiste');


/* **************************************************************************************************************************** */

-- Procedimiento Nuevo Cliente

-- Cambio el delimitador para poder crear el procedimiendo
delimiter // 

-- Elimino el procedimiento si es que existe
drop procedure if exists DSOO_C1A_G5_TPI_Cantarini_GomezDeLeo_Nunez_Aiza.nuevoCliente //

-- Creo el procedimiento almacenado que requiere de los parametros de Entrada con los datos del nuevo cliente para ejecutar su logica 
-- y tiene una Respuesta como Salida, donde verifico si el cliente ya estaba registrado. 
create procedure nuevoCliente(
	in Nombre varchar(30),
    in Apellido varchar(30),
    in TipoDocumento varchar(15), 
    in NumeroDocumento int, 
    in FechaNacimiento date, 
    in AptoFisico bool, 
    out Respuesta int
    )
begin
	-- Declaro mis variables
	declare existeCliente int default 0;
    declare FechaInscripcion date default current_date;
    
    -- Verifico si el cliente ya existe en mi base de datos
    set existeCliente = (select count(*) from Cliente C WHERE C.TipoDocumento = TipoDocumento and C.NumeroDocumento = NumeroDocumento);				
	
    -- Si el cliente no esta registrado, ingreso sus datos en la tabla cliente
	if existeCliente = 0 then	 
		insert into Cliente(Nombre, Apellido, TipoDocumento, NumeroDocumento, FechaNacimiento, FechaInscripcion, AptoFisico) values(Nombre, Apellido, TipoDocumento, NumeroDocumento, FechaNacimiento, FechaInscripcion, AptoFisico);
        set respuesta = (select C.ClienteID from Cliente C WHERE C.TipoDocumento = TipoDocumento and C.NumeroDocumento = NumeroDocumento); 
	  else
		set respuesta = 0; -- Cliente ya registrado
      end if;	
end //
delimiter ;

-- Para llamar a mi procedimiento almacenado para el Nuevo Cliente
-- SET @Respuesta = NULL;
-- call nuevoCliente('Belen','Cantarini','DNI',31977726,'1985-12-12', @Respuesta);
-- SELECT @Respuesta;
-- call nuevoCliente('Carlos', 'Pérez', 'DNI', 12345678, '1990-05-15', @Respuesta);
-- SELECT @Respuesta;


/* **************************************************************************************************************************** */
-- Procedimiento Nuevo Socio / No Socio
delimiter // 
drop procedure if exists DSOO_C1A_G5_TPI_Cantarini_GomezDeLeo_Nunez_Aiza.nuevoSocio //
create procedure nuevoSocio(	
	in Nombre varchar(30),
    in Apellido varchar(30),
    in TipoDocumento varchar(15), 
    in NumeroDocumento int, 
    in FechaNacimiento date, 
    in AptoFisico bool, 
    out RespuestaCliente int)
begin
	declare existeCliente int default 0;
    declare nuevoClienteID int;
	declare FechaInscripcion date default current_date;
    declare FechaVencimientoCuota date default current_date;
    
    -- Verifico si el cliente o el socio ya existen en mi base de datos
    set existeCliente = (select count(*) from Cliente C WHERE C.TipoDocumento = TipoDocumento and C.NumeroDocumento = NumeroDocumento);				
    
    -- Si el cliente no esta registrado, ingreso sus datos en la tabla cliente
	if  existeCliente = 0 then	 
		insert into Cliente(Nombre, Apellido, TipoDocumento, NumeroDocumento, FechaNacimiento, FechaInscripcion, AptoFisico) values(Nombre, Apellido, TipoDocumento, NumeroDocumento, FechaNacimiento, FechaInscripcion, AptoFisico);
        set nuevoClienteID = last_insert_id();
        insert into Socio(ClienteID,FechaVencimientoCuota) values(nuevoClienteID,FechaVencimientoCuota);
        set RespuestaCliente = nuevoClienteID;
	else
		set RespuestaCliente = 0; -- Cliente ya registrado
	end if;	
end //
delimiter ;


delimiter // 

drop procedure if exists DSOO_C1A_G5_TPI_Cantarini_GomezDeLeo_Nunez_Aiza.nuevoNoSocio //
create procedure nuevoNoSocio(	
	in Nombre varchar(30),
    in Apellido varchar(30),
    in TipoDocumento varchar(15), 
    in NumeroDocumento int, 
    in FechaNacimiento date, 
    in AptoFisico bool, 
    out RespuestaCliente int)
begin
	declare existeCliente int default 0;
    declare nuevoClienteID int;
	declare FechaInscripcion date default current_date;
    
    -- Verifico si el cliente o el socio ya existen en mi base de datos
    set existeCliente = (select count(*) from Cliente C WHERE C.TipoDocumento = TipoDocumento and C.NumeroDocumento = NumeroDocumento);				
    
    -- Si el cliente no esta registrado, ingreso sus datos en la tabla cliente
	if  existeCliente = 0 then	 
		insert into Cliente(Nombre, Apellido, TipoDocumento, NumeroDocumento, FechaNacimiento, FechaInscripcion, AptoFisico) values(Nombre, Apellido, TipoDocumento, NumeroDocumento, FechaNacimiento, FechaInscripcion, AptoFisico);
        set nuevoClienteID = last_insert_id();
        insert into NoSocio(ClienteID) values(nuevoClienteID);
        set RespuestaCliente = nuevoClienteID;
	else
		set RespuestaCliente = 0; -- Cliente ya registrado
	end if;	
end //
delimiter ;



/* **************************************************************************************************************************** */
-- Eventos programados
/* **************************************************************************************************************************** */

-- Cambio el delimitador para poder crear el evento
delimiter // 
drop event if exists ActualizarEstadoSocios // 
create event ActualizarEstadoSocios on schedule every 1 day STARTS '2024-01-01 00:00:00' do 
begin
    update Socio set Activo = false 
		where FechaVencimientoCuota < current_date and Activo = true;
end //
delimiter ;


/* **************************************************************************************************************************** */
-- Vistas almacenadas
/* **************************************************************************************************************************** */

use DSOO_C1A_G5_TPI_Cantarini_GomezDeLeo_Nunez_Aiza;

drop view if exists VistaSocios;
create or replace view VistaSocios as
	select C.ClienteID, C.Nombre, C.Apellido, C.TipoDocumento, C.NumeroDocumento, C.FechaNacimiento, C.FechaInscripcion, C.AptoFisico, S.CarnetSocioID, S.FechaVencimientoCuota, S.Activo
		from Cliente C
			inner join Socio S
				on C.ClienteID = S.ClienteID;

drop view if exists VistaNoSocios;
create or replace view VistaNoSocios as
	select C.ClienteID, C.Nombre, C.Apellido, C.TipoDocumento, C.NumeroDocumento, C.FechaNacimiento, C.FechaInscripcion, C.AptoFisico, NS.NoSocioID
		from Cliente C
			inner join NoSocio NS
				on C.ClienteID = NS.ClienteID;
			
drop view if exists VistaClientes;
create or replace view VistaClientes as
	select C.ClienteID, C.Apellido, C.Nombre, C.TipoDocumento, C.NumeroDocumento, C.FechaNacimiento, 
		timestampdiff(year, FechaNacimiento, current_date) as Edad, 
			C.FechaInscripcion, C.AptoFisico,
				if(S.ClienteID is not null, 'Socio', if(NS.ClienteID is not null, 'No Socio', 'Indeterminado')) as TipoCliente
					from Cliente C
						left join Socio S on C.ClienteID = S.ClienteID
							left join NoSocio NS ON C.ClienteID = NS.ClienteID
								order by C.ClienteID;
                
drop view if exists VistaVencimientosCuotas;
create or replace view VistaVencimientosCuotas as
	select C.ClienteID, C.Nombre, C.Apellido, S.CarnetSocioID, C.FechaInscripcion, C.AptoFisico, S.FechaVencimientoCuota, S.Activo
		from Cliente C
			inner join Socio S
				on C.ClienteID = S.ClienteID;

drop view if exists VistaVencimientosHoy;
create or replace view VistaVencimientosHoy as
	select C.ClienteID, C.Nombre, C.Apellido, S.CarnetSocioID, C.FechaInscripcion, C.AptoFisico, S.FechaVencimientoCuota, S.Activo
		from Cliente C
			inner join Socio S
				on C.ClienteID = S.ClienteID
					where S.FechaVencimientoCuota = current_date;


drop view if exists VistaCuotasVencidas;                    
create or replace view VistaCuotasVencidas as
	select C.ClienteID, C.Nombre, C.Apellido, S.CarnetSocioID, C.FechaInscripcion, C.AptoFisico, S.FechaVencimientoCuota, S.Activo
		from Cliente C
			inner join Socio S
				on C.ClienteID = S.ClienteID
					where S.FechaVencimientoCuota < current_date;
                    
-- select * from DSOO_C1A_G5_TPI_Cantarini_GomezDeLeo_Nunez_Aiza.ListaSocios;
-- select * from DSOO_C1A_G5_TPI_Cantarini_GomezDeLeo_Nunez_Aiza.ListaNoSocios;
-- select * from DSOO_C1A_G5_TPI_Cantarini_GomezDeLeo_Nunez_Aiza.ListaClientes;
-- select * from DSOO_C1A_G5_TPI_Cantarini_GomezDeLeo_Nunez_Aiza.VistaVencimientosCuotas;
-- select * from DSOO_C1A_G5_TPI_Cantarini_GomezDeLeo_Nunez_Aiza.VistaVencimientosHoy;
-- select * from DSOO_C1A_G5_TPI_Cantarini_GomezDeLeo_Nunez_Aiza.VistaCuotasVencidas;

/* **************************************************************************************************************************** */
-- Pruebas a mi base de datos     
/* **************************************************************************************************************************** */

insert into Cliente (Nombre, Apellido, TipoDocumento, NumeroDocumento, FechaNacimiento, FechaInscripcion, AptoFisico) values 
('Carlos', 'Pérez', 'DNI', 12345678, '1990-05-15', '2024-10-01', TRUE),
('Lucía', 'Gómez', 'DNI', 87654321, '1985-11-10', '2024-09-28', TRUE),
('Mariano', 'López', 'Pasaporte', 45678901, '1992-08-22', '2024-10-05', FALSE),
('Ana', 'Rodríguez', 'DNI', 22334455, '2000-02-12', '2024-10-10', TRUE),
('Juan', 'Pérez', 'DNI', 11223344, '1985-05-15', '2024-10-01', TRUE),
('María', 'Fernández', 'DNI', 33445566, '1992-12-20', '2024-09-30', TRUE),
('Esteban', 'Mendoza', 'Pasaporte', 77889900, '1980-03-15', '2024-10-05', TRUE),
('Sofía', 'Castro', 'DNI', 55667788, '1995-07-01', '2024-10-15', FALSE);

insert into Socio (CarnetSocioID, ClienteID, FechaVencimientoCuota, Activo) values 
('SOCIO123', 1, '2024-10-16', TRUE),
('SOCIO124', 2, '2024-10-16', TRUE),
('SOCIO125', 4, '2024-11-10', TRUE),
('SOCIO126', 5, '2024-11-15', TRUE),  
('SOCIO127', 6, '2024-10-16', TRUE),
('SOCIO128', 7, '2024-09-01', FALSE), 
('SOCIO129', 8, '2024-10-10', FALSE);

insert into NoSocio (ClienteID) values (3);

call ingresoLogin('AdministradorPrueba','adm123');
call ingresoLogin('NoExiste','NoExiste');
SET @Respuesta = NULL;

call nuevoCliente('Belen','Cantarini','DNI',31977726,'1985-12-12',true, @Respuesta);
SELECT @Respuesta;
call nuevoCliente('Emanuel', 'Pérez', 'DNI', 38345, '1990-05-15',false, @Respuesta);
SELECT @Respuesta;
select * from Cliente;


/* **************************************************************************************************************************** */
-- Consultas a mi base de datos     
/* **************************************************************************************************************************** */
select * from Roles;
select * from Usuario;
select * from Actividad;
select * from Cliente;
select * from Socio;
select * from NoSocio;
select * from Pago;
select * from VistaSocios;
select * from VistaNoSocios;
select * from VistaClientes;
select * from VistaVencimientosCuotas;
select * from VistaVencimientosHoy;
select * from VistaCuotasVencidas;
show events like 'ActualizarEstadoSocios';
call nuevoSocio('Damian', 'Gomez', 'DNI', 65756757, '1990-05-15',true, @Respuesta);
SELECT @Respuesta;