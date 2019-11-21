create database Veterinaria
go
use Veterinaria

create table ciudades (
idCiudad int identity(1,2),
barrio nvarchar(50),

constraint pk_ciudades primary key (idCiudad)
)

create table propietarios(
idPropietario int identity,
nombre nvarchar (50),
apellido nvarchar (50),
calle nvarchar (100),
numCalle int,
telefono int,
email nvarchar (70),
sexo int,
idCiudad int,

constraint pk_propietarios primary key (idPropietario),
constraint fk_ciudades_propietario foreign key (idCiudad)
references ciudades (idCiudad)
)

create table veterinarios(
matricula int ,
nombre nvarchar(50),
apellido nvarchar(50),
calle nvarchar(50),
numCalle int ,
email nvarchar(50),
telefono int,
fec_nac date,
sexo int,
sueldoNeto decimal,
fechaIngreso datetime,
fechaEgreso datetime,
idCiudad int,

constraint pk_veterinarios primary key (matricula),
constraint fk_ciudades_veterinario foreign key (idCiudad)
references ciudades(idCiudad)
) 

create table razas
(
	idRaza int,
	raza nvarchar(60),

constraint pk_razas primary key(idRaza)
)

create table mascotas
(
	idMascota int,
	idPropietario int,
	nombre nvarchar(60),
	idRaza int,
	peso decimal(3,2),
	fecNac datetime,
	idTipo int,

	constraint pk_macotas primary key(idMascota),

    constraint fk_mascotas_propietarios foreign key(idPropietario)
	references propietarios (idPropietario),

	constraint fk_mascotas_razas foreign key(idRaza)
	references razas (idRaza)
)

create table tipoMascota(
idTipo int,
tipo nvarchar(60)

constraint pk_tipoMascota primary key (idTipo)
)

create table turnos
(
	idTurno int,
	idPropietario int,
	idMascota int,
	idVeterinario int,
	descripcion nvarchar(60),
	fecha datetime,

	constraint pk_turnos primary key(idTurno),

	constraint fk_turnos_propietarios foreign key(idPropietario)
	references propietarios (idPropietario),

	constraint fk_turnos_mascotas foreign key(idMascota)
	references mascotas (idMascota),

	constraint fk_turnos_veterinarios foreign key(idVeterinario)
	references veterinarios (matricula)
)

insert into ciudades values('Colonia Caroya')
insert into ciudades values('Jesus Maria')
insert into ciudades values('Sinsacate')
insert into ciudades values('Dean Funes')
insert into ciudades values('Cordoba')
insert into ciudades values('Tirolesa')

insert into propietarios values('Gonzalo','Fernandez','Calle 40',3640,35232127,'[gf@gmail.com]',1,11)
insert into propietarios values('Agustin','Marchetti','Santiafo del Estero',345,3518765,'[an@yahoo.com]',1,1)
insert into propietarios values('Fernando','VelezSarfield','Lote 7D',860,3525045,'[fercanciani@gmail.com]',1,5)
insert into propietarios values('Veronica','Montenegro','Leo Canciani',12,35278596,'vcan@gmail.com',2,1)
insert into propietarios values('Janet','Rufino','Calle 40',3500,01146777,'[janetunga@outlook.com.eu]',2,3)
insert into propietarios values('Monica','Gonzalez','venturini norte',25,35275444,'[MonGon@gmail.com]',2,3)
insert into propietarios values('Juan','Ferrascaro','migoti Norte',568,35254545,'[ferrusco@gmail.com]',2,7)

insert into veterinarios values(11122,'Nicol','Gonzalez','ameguino',12332,'[NIqui@gmail.com]',35255456,'1991/04/01',2,32000,'2004/02/04',null,5)
insert into veterinarios values(783312,'almendrado','Carlsen','Norway',2323,'[cheesMaster@gmail.com]',3513123,'1964/12/11',1,23040,'2000/05/04',null,1)
insert into veterinarios values(12356,'piTTy','Alvarez','themooon',8780,'[recoool@yahoo.com.ar]',3528678,'1945/01/14',1,45730,'2014/07/04',null,11)
insert into veterinarios values(6573453,'Martin','Perez','adolfina',6666,'[thebeast@outlook.es]',3522234,'1973/09/27',1,38614,'1995/12/13','2003/01/01',7)
