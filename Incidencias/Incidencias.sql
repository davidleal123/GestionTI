create database incidencias
go
use incidencias
go
--drop database incidencias
create table departamento(
	id int identity(1,1) not null primary key,
	nombre varchar(50) not null,
	prioridad varchar(20) not null
)
--drop table departamento
insert into departamento values('SOPORTE','ALTA')
insert into departamento values('FINANCIERO','MEDIA')
insert into departamento values('RECURSOS HUMANOS','BAJA')
--Select id from departamento where nombre='Financiero'
create table equipo(
	id int identity(1,1) not null primary key,
	equipo varchar(50) not null,
	marca varchar(30) not null,
	modelo varchar(30) not null,
	Descripcion varchar(200) not null,
	garantia int not null,
	fechaCompra date not null,
	departamento int not null,
	foreign key(departamento) references departamento(id)
)
--SELECT * FROM EQUIPO
--drop table equipo
create table empleado
(
	id int identity(1,1) not null primary key,
	nombre varchar(40) not null,
	apellidoPaterno varchar(30) not null,
	apellidoMaterno varchar(30) not null,
	correoElectronico varchar(55) not null,
	contraseña char(12) not null,
	numeroCelular char(10),
	direccion varchar(80) not null,
	cargo varchar(40) not null,
	departamento int not null,
	foreign key(departamento) references departamento(id)
)

--select * from empleado where id=123 and contraseña=123
-- concat(nombre,' ',apellidoPaterno,' ',apellidoMaterno) from empleado
insert into empleado values('CARLOS','GERMAN','MILLAN','cacahuate@hotmail.com','0001',6672633090,'Margarita #37 Fracc. Los Alpes','ADMINISTRADOR',1)
insert into empleado values('ANTONIO','ASTORGA','LOPEZ','helados@hotmail.com','0002',6672233590,'Margarita #38 Fracc. Los Alpes','TECNICO',2)
insert into empleado values('JOSE','BENITEZ','LEAL','mantequilla@hotmail.com','0003',6672633470,'Margarita #39 Fracc. Los Alpes','DOCENTE',3)
insert into empleado values('CARLOS','BENITEZ','LEAL','mantequilla@hotmail.com','0005',6672633470,'Margarita #39 Fracc. Los Alpes','ADMINISTRADOR',2)
insert into empleado values('CARLOS','BENITEZ','LEAL','mantequilla@hotmail.com','0007',6672633470,'Margarita #39 Fracc. Los Alpes','DOCENTE',2)

create table tecnico(
	id int identity(1,1) not null primary key,
	idEmpleado int not null,
	especializacion varchar(50) not null,
	certificaciones varchar(150) not null,
	incidenciasAsignadas int null,
	foreign key (idEmpleado) references empleado(id)
)
select * from tecnico
insert into tecnico(idEmpleado,especializacion,certificaciones,incidenciasAsignadas) values(2,'CCNA1','DIVERSOS CURSOS Y CONGRESOS RELACIONADOS CON EL AMBITO DE REDES',0);
insert into tecnico(idEmpleado,especializacion,certificaciones,incidenciasAsignadas) values(4,'CCNA1','DIVERSOS CURSOS Y CONGRESOS RELACIONADOS CON EL AMBITO DE REDES',0);

--SELECT * FROM TECNICO

create table Servicios(
	id int identity(1,1) not null primary key,
	descripcion varchar(400) not null,
	solucion varchar(500) not null,
	tiempo varchar(20) not null
)


create table incidencia(
	id int identity(1,1) not null primary key,
	equipo int not null,
	departamento int not null,
	descripcion varchar(700) not null,
	tipo varchar(15) null,
	empleado int not null,--Empleado que levanta la incidencia
	prioridad varchar(20) not null,
	tecnico int null,
	fechaLevantamiento datetime null,
	fechaInicio datetime null,
	fechaTerminacion datetime null,
	tiempoAtender varchar(2) null,
	tiempoSolucion varchar(100) null,
	estatus varchar(20) not null,
	calificacion char(1) null,
	tiempoSolucionReal varchar(20) null,
	foreign key(equipo) references equipo(id),
	foreign key(departamento) references departamento(id),
	foreign key(empleado) references empleado(id),
	foreign key(tecnico) references tecnico(id)
)

select * from empleado




--select * from empleado
--select id from empleado except(select nombre from tecnico)
--select distinct concat(e.nombre,' ',apellidoPaterno,' ',apellidoMaterno) from empleado e
--join tecnico t on t.nombre!=e.id

--select distinct concat(e.nombre,' ',apellidoPaterno,' ',apellidoMaterno),certificaciones,incidenciasAsignadas from tecnico t inner join empleado e on t.nombre=e.id

--select equipo from equipo e inner join departamento d on e.departamento=d.id

--drop database incidencias


select * from empleado
SELECT * FROM equipo
select * from tecnico
select * from incidencia

Select i.id,e.equipo,i.descripcion,d.prioridad from incidencia i inner join equipo e on i.equipo=e.id inner join departamento d on d.id=i.departamento where i.tecnico is NULL 


Select i.id,e.equipo,i.descripcion,d.prioridad from incidencia i inner join equipo e on i.equipo=e.id inner join departamento d on d.id=i.departamento where i.tecnico is not NULL and i.tecnico='1'

select nombre, especializacion, count(*) from tecnico t inner join incidencia i on i.tecnico=t.id group by nombre,especializacion


update empleado set nombre='FELIPE' where id=1

select e.nombre, especializacion,incidenciasAsignadas from tecnico INNER JOIN EMPLEADO E ON E.ID=TECNICO.IDEMPleado 


select * from empleado

select id from empleado except(select idEmpleado from tecnico)

select distinct concat(e.nombre,' ',apellidoPaterno,' ',apellidoMaterno) from empleado e right join tecnico t on t.idEmpleado!=e.id

select * from tecnico

select * from incidencia

select i.id,descripcion,d.nombre,concat(e.nombre,' ',apellidoPaterno,' ',apellidoMaterno) ,estatus 
from incidencia i inner join departamento d on d.id=i.departamento 
left join tecnico t on t.id=i.tecnico
left join empleado e on e.id=t.idEmpleado

Select i.id,i.descripcion,d.nombre,d.prioridad from incidencia i inner join equipo e on i.equipo=e.id inner join departamento d on d.id=i.departamento inner join tecnico t on i.tecnico=t.id where i.tecnico is not NULL and i.estatus='En proceso'  and t.idEmpleado=2;


Select i.id,i.descripcion,e.equipo,d.nombre from incidencia i inner join equipo e on i.equipo=e.id inner join departamento d on d.id=i.departamento inner join tecnico t on i.tecnico=t.id where i.tecnico is not NULL and i.estatus='Terminada'  and t.idEmpleado=2

select i.id,descripcion,d.nombre,concat(e.nombre,' ',apellidoPaterno,' ',apellidoMaterno) from incidencia i inner join departamento d on d.id=i.departamento left join tecnico t on t.id=i.tecnico left join empleado e on e.id=t.idEmpleado where estatus='Liberada' and i.empleado=2

select * from incidencia
select * from tecnico
select * from equipo
select * from empleado
update equipo set fechaCompra='2017-13-05'where id=1
update tecnico set incidenciasAsignadas=0 where id=1
update incidencia set estatus='Terminada' where id=1

--Agregar a la tabla de incidencia los campos fechaLevantada, fechaDeInicio, fechaDeTerminacion

select * from departamento 

select * from incidencia where departamento=4 and estatus!='Liberada'
select * from incidencia where estatus!='liberada'