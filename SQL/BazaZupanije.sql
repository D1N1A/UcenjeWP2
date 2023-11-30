create database Zupanije;

use  Zupanije;

create table Župan (
šifra int not null primary key identity (1,1),
ime varchar (50) not null,
prezime varchar (50) not null
);

create table Županija (
šifra int not null primary key identity (1,1),
naziv varchar (100) not null,
župan int not null
);

create table Općina (
šifra int not null primary key identity (1,1),
županija int not null,
naziv varchar (100) not null
);

create table Mjesto (
šifra int not null primary key identity (1,1),
općina int not null,
naziv varchar (100) not null
);

alter table Županija add foreign key (župan) references Župan (šifra);

alter table Općina add foreign key (županija) references Županija (šifra);

alter table Mjesto add foreign key (općina) references Općina (šifra);

insert into Župan (ime,prezime) values
('Ivan', 'Anušić'),
('Boban', 'Blaženko'),
('Ivan', 'Celjak');

insert into Županija (naziv,župan) values
('Osječko-baranjska',1),
('Splitsko-dalmatinska',2),
('Sisačko-moslavačka',3);

insert into Općina (županija,naziv) values
(1,'Antunovac'),
(2, 'Baška Voda'),
(3, 'Dvor'),
(3, 'Gvozd'),
(3, 'Sunja'),
(3, 'Topusko');



insert into Mjesto (općina,naziv) values
(1,'Antunovac'),
(2,'Baška Voda'),
(3,'Brđani'),
(3,'Donji Žirovac'),
(2,'Bratuš'),
(2,'Promajna'),
(2,'Bast'),
(6,'Bukovica'),
(6,'Gređani'),
(6,'Ponikvari'),
(6,'Pecka'),
(6,'Malička');

update Mjesto set naziv  ='Staro Selo Topusko'
where šifra =11;

update Mjesto set naziv ='Hrvatsko Selo'
where šifra =10;

update Mjesto set naziv  ='Malička'
where šifra =9;

update Mjesto set naziv  ='Bukovica'
where šifra = 12;

update Mjesto set naziv ='Gređani'
where šifra =8;



select * from mjesto;

delete Mjesto
where šifra = 1;

delete Mjesto 
where šifra = 2;

delete Mjesto 
where šifra =5; 

delete Mjesto 
where šifra =6;

delete Mjesto 
where šifra = 7;

delete Općina
where šifra = 1;

delete Općina 
where šifra = 2;


