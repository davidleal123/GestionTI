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

create table tecnico(
	id int identity(1,1) not null primary key,
	idEmpleado int not null,
	especializacion varchar(50) not null,
	certificaciones varchar(150) not null,
	incidenciasAsignadas int null,
	foreign key (idEmpleado) references empleado(id)
)
select * from tecnico
insert into tecnico(idEmpleado,especializacion,certificaciones) values(1,'CCNA1','DIVERSOS CURSOS Y CONGRESOS RELACIONADOS CON EL AMBITO DE REDES');
--SELECT * FROM TECNICO

create table incidencia(
	id int identity(1,1) not null primary key,
	equipo int not null,
	departamento int not null,
	descripcion varchar(700) not null,
	tipo varchar(15) not null,
	empleado int not null,--Empleado que levanta la incidencia
	prioridad varchar(20) not null,
	tecnico int null,
	tiempoAtender varchar(2) null,
	tiempoSolucion varchar(100) null,
	estatus varchar(20) not null,
	foreign key(equipo) references equipo(id),
	foreign key(departamento) references departamento(id),
	foreign key(empleado) references empleado(id),
	foreign key(tecnico) references tecnico(id)
)


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