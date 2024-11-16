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

create table PlanMembresia(
MembresiaID int auto_increment not null,
Plan varchar (30) not null,
Meses int not null,
Precio double not null,
constraint pk_membresia_id primary key (MembresiaID)
)engine=innodb;

create table Pago(
PagoID int auto_increment not null,
ClienteID int not null,
MembresiaID int null,
ActividadID int null,
Monto double not null,
MetodoPago varchar (30) not null,
Cuotas int not null default 1,
FechaPago date not null,
constraint pk_pago_id primary key (PagoID),
constraint fk_pago_cliente foreign key (ClienteID) references Cliente(ClienteID),
constraint fk_inscripcion_membresia foreign key (MembresiaID) references PlanMembresia(MembresiaID),
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

insert into PlanMembresia (Plan,Meses,Precio) values 
('Mensual', 1,30000.00),
('Trimestral',3,80000.00),
('Semestral',6,150000.00),
('Anual', 12,290000.00);
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
-- Procedimiento obtener datos Cliente

-- Cambio el delimitador para poder crear el procedimiendo
delimiter //

drop procedure if exists DSOO_C1A_G5_TPI_Cantarini_GomezDeLeo_Nunez_Aiza.obtenerDatosCliente //

create procedure obtenerDatosCliente(
    in TipoDocumento varchar(15), 
    in NumeroDocumento int, 
	out ExisteCliente int,
	out VarClienteID int,
    out VarTipoCliente varchar (15),
	out VarApellido varchar (30),
	out VarNombre varchar (30),
	out VarFechaNacimiento date,
    out VarEdad int,
	out FechaInscripcion date,
	out VarAptoFisico bool,
	out VarCarnetSocioID varchar(30),
	out VarFechaVencimientoCuota date,
	out VarActivo boolean
)
begin
    -- Inicializo valores por defecto
    set ExisteCliente = 0;

	-- Verifico si el cliente existe
    set existeCliente = (select count(*) from Cliente C where C.TipoDocumento = TipoDocumento and C.NumeroDocumento = NumeroDocumento);	 
    
    -- Si el cliente existe, obtengo todos sus datos
    if  existeCliente > 0 then	 
		select C.ClienteID, 
			if(S.ClienteID is not null, 'Socio', if(NS.ClienteID is not null, 'No Socio', 'Indeterminado')) as TipoCliente,
				C.Apellido, C.Nombre, C.FechaNacimiento, 
					timestampdiff(year, FechaNacimiento, current_date) as Edad, 
						C.FechaInscripcion, C.AptoFisico, S.CarnetSocioID, S.FechaVencimientoCuota, S.Activo
							into VarClienteID,VarTipoCliente,VarApellido,VarNombre,VarFechaNacimiento,VarEdad,FechaInscripcion,VarAptoFisico,VarCarnetSocioID,VarFechaVencimientoCuota,VarActivo
								from Cliente C
									left join Socio S on C.ClienteID = S.ClienteID
										left join NoSocio NS ON C.ClienteID = NS.ClienteID
											where C.TipoDocumento = TipoDocumento and C.NumeroDocumento = NumeroDocumento;
    end if;	
end //
delimiter ;


-- in TipoDocumento, NumeroDocumento    
-- out ExisteCliente,VarClienteID,VarTipoCliente,VarApellido,VarNombre,VarFechaNacimiento,VarEdad,FechaInscripcion,VarAptoFisico,VarCarnetSocioID,VarFechaVencimientoCuota,VarActivo
-- call obtenerDatosCliente('DNI',12345678,@ExisteCliente,@VarClienteID,@VarTipoCliente,@VarApellido,@VarNombre,@VarFechaNacimiento,@VarEdad,@FechaInscripcion,@VarAptoFisico,@VarCarnetSocioID,@VarFechaVencimientoCuota,@VarActivo);
-- select @ExisteCliente,@VarClienteID,@VarTipoCliente,@VarApellido,@VarNombre,@VarFechaNacimiento,@VarEdad,@FechaInscripcion,@VarAptoFisico,@VarCarnetSocioID,@VarFechaVencimientoCuota,@VarActivo;
call obtenerDatosCliente('Pasaporte',45678901,@ExisteCliente,@VarClienteID,@VarTipoCliente,@VarApellido,@VarNombre,@VarFechaNacimiento,@VarEdad,@FechaInscripcion,@VarAptoFisico,@VarCarnetSocioID,@VarFechaVencimientoCuota,@VarActivo);
select @ExisteCliente,@VarClienteID,@VarTipoCliente,@VarApellido,@VarNombre,@VarFechaNacimiento,@VarEdad,@FechaInscripcion,@VarAptoFisico,@VarCarnetSocioID,@VarFechaVencimientoCuota,@VarActivo;

/* **************************************************************************************************************************** */

-- Procedimiento Nuevo Pago y Emision de Carnet de Socio

-- Cambio el delimitador para poder crear el procedimiendo
delimiter //

drop procedure if exists DSOO_C1A_G5_TPI_Cantarini_GomezDeLeo_Nunez_Aiza.registrarPago//

create procedure registrarPago(
    in VarClienteID int,
    in EsSocio boolean,
    in VarMembresiaID int,
    in VarActividadID int,
    in VarMetodoPago varchar(30),
    in VarCuotas int,
    out Respuesta int
)
begin
    declare carnetGenerado varchar(30);
    declare existeCarnetSocio int default 0;
    declare planMeses int;
    declare monto double;
    declare fechaActual date default current_date;
	declare nuevaFechaVencimiento date;
	declare FechaVencimientoCuota date;
    -- Control de errores SQL
    declare exit handler for sqlexception
    begin
        set Respuesta = -2; -- Error de SQL
        rollback;
    end;

    start transaction;

    -- Si el cliente no existe, terminamos
    if not exists (select 1 from Cliente where ClienteID = VarClienteID) then
        set Respuesta = -1; -- Cliente no existe
        rollback;
    end if;
	

    -- Si el cliente es un socio
    if EsSocio then
		-- Verificamos el plan de membresia del socio
		set planMeses = (select Meses from PlanMembresia PM where PM.MembresiaID = VarMembresiaID);
        -- Verificamos el monto a pagar
        set monto = (select Precio from PlanMembresia PM where PM.MembresiaID = VarMembresiaID);
        -- Verificamos si ya tiene carnet de socio
        set existeCarnetSocio = (select count(*) from Socio S where S.ClienteID = VarClienteID and S.CarnetSocioID is not null);
		-- Verificamos la fecha actual de vencimiento de la cuota
        set FechaVencimientoCuota = (select S.FechaVencimientoCuota from Socio S where S.ClienteID = VarClienteID);
        -- Si no tiene carnet, generamos uno
        if existeCarnetSocio = 0 then
            set carnetGenerado = concat('CARNET-', VarClienteID);
            update Socio S
            set S.CarnetSocioID = carnetGenerado, S.Activo = true, S.FechaVencimientoCuota = date_add(fechaActual, interval planMeses month)
            where S.ClienteID = VarClienteID;
		else
			-- Si ya tiene un carnet, actualizamos su fecha de vencimiento
			if FechaVencimientoCuota < fechaActual then
				-- Si la fecha de vencimiento es anterior a la fecha actual, reiniciamos la fecha de vencimiento desde la fecha actual
				set nuevaFechaVencimiento = DATE_ADD(fechaActual, interval planMeses month);
			else
				-- Si la fecha de vencimiento es posterior a la fecha actual, extendemos la fecha de vencimiento actual
				set nuevaFechaVencimiento = DATE_ADD(FechaVencimientoCuota, interval planMeses month);
			end if;
            
			-- Actualizamos el estado del socio y la nueva fecha de vencimiento calculada
			update Socio S 
			set S.Activo = true, S.FechaVencimientoCuota = nuevaFechaVencimiento 
			where S.ClienteID = VarClienteID;
        end if;

        -- Registramos el pago de la membresía
        insert into Pago (ClienteID, MembresiaID, Monto, MetodoPago, Cuotas, FechaPago)
        values (VarClienteID, VarMembresiaID, Monto, VarMetodoPago, VarCuotas, fechaActual);

        -- Devolvemos el estado de éxito
        if existeCarnetSocio = 0 then
			set Respuesta = 2;
		else
			set Respuesta = 1;
		end if;

    else
        -- Verificamos el monto a pagar
        set monto = (select Precio from Actividad A where A.ActividadID = VarActividadID);
        
        -- registramos el pago de la actividad
        insert into Pago (ClienteID, ActividadID, Monto, MetodoPago, Cuotas, FechaPago)
        values (VarClienteID, VarActividadID, Monto, VarMetodoPago, VarCuotas, fechaActual);

        -- Devolvemos el estado de éxito
        set Respuesta = 1;
    end if;
	commit;
end //
delimiter ;

 -- in VarClienteID,EsSocio,VarMembresiaID,VarActividadID,VarMetodoPago,VarCuotas,out Respuesta
 -- call registrarPago(1, true, 2,null,'Tarjeta',3, @Respuesta);
 -- select @Respuesta;
select*from pago;
select*from socio;
select*from nosocio;

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
select*from pago;
drop view if exists VistaUltimoRecibo;
create or replace view VistaUltimoRecibo as
	select P.ClienteID,C.Apellido, C.Nombre, C.TipoDocumento, C.NumeroDocumento,P.PagoID,P.MembresiaID,M.Plan as Membresia,P.ActividadID,A.Nombre as Actividad,P.Monto, P.MetodoPago, P.Cuotas, P.FechaPago
		from Pago P
			left join Cliente C
				on C.ClienteID = P.ClienteID
					left join PlanMembresia M
						on M.MembresiaID = P.MembresiaID
							left join Actividad A
								on A.ActividadID = P.ActividadID
									where P.PagoID = (select MAX(PagoID) from Pago);
                                
select * from VistaUltimoRecibo;
select * from pago;                              
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
('Sofía', 'Castro', 'DNI', 11111111, '1995-07-01', '2024-10-15', FALSE);

insert into Socio (CarnetSocioID, ClienteID, FechaVencimientoCuota, Activo) values 
('SOCIO123', 1, '2024-11-16', TRUE),
('SOCIO124', 2, '2024-10-16', FALSE);

insert into NoSocio (ClienteID) values (3);

call ingresoLogin('AdministradorPrueba','adm123');
call ingresoLogin('NoExiste','NoExiste');
SET @Respuesta = NULL;
call nuevoSocio('Damian', 'Gomez', 'DNI', 22222222, '1990-05-15',true, @Respuesta);
SELECT @Respuesta;


/* **************************************************************************************************************************** */
-- Consultas a mi base de datos     
/* **************************************************************************************************************************** */
select * from Roles;
select * from Usuario;
select * from Actividad;
select * from PlanMembresia;
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
