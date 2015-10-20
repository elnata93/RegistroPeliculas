use RegPeliculas;
select * from Peliculas
select * from Generos;
select * from Actores;
select * from Estudios;
drop table Actores;
drop table Estudios;
drop table Peliculas;

create table Actores(ActorId int identity(1,1),Nombre varchar(30));

create table Estudios(EstudioId int identity(1,1),Nombre varchar(30));

create table Peliculas(PeliculaId int identity(1,1),Titulo varchar(30),Ano int not null,
Calificacion int not null,IMDB int not null,CategoriaId int not null,
Genero varchar(30),Actor varchar(30),Estudio varchar(30),Descripcion varchar(200));