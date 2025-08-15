create database Datos20250161
go

use Datos20250161
go

create table Peliculas(
id int identity(1,1) primary key,
nombre varchar(50) not null,
director varchar(50) not null,
fechaLanzamiento date
);
go

insert into Peliculas values ('Ant-Man','James Gunn', '2015/05/25'),
('KPop Demon Hunters','maggie Kang', '2025/06/20'),
('Como entrenar a tu dragon','Chris Sanders', '2010/03/21'),
('Titanes del Pacifico','Guillermo del Toro', '2013/07/01'),
('Big Hero 6', 'Chris Williams', '2014/11/07')
go

select *from Peliculas

select * from Peliculas