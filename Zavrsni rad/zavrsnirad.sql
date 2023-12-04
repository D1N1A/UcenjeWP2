use master;
go
drop database if exists odvjetnickiured;
go

create database odvjetnickiured;
go
alter database odvjetnickiured collate Croatian_CI_AS;
go
use odvjetnickiured;

create table odvjetnik (
sifra int not null primary key identity(1,1),
ime varchar (50) not null,
prezime varchar (50) not null,
podrucjerada int not null,
poruka int,
fotografija varchar (255),
telefon char (14) not null,
eposta varchar (100)
);



create table podrucjerada (
sifra int not null primary key identity(1,1),
naziv varchar (255) not null
);

create table poruka (
sifra int not null primary key identity(1,1),
podrucjerada int not null,
predmet varchar (50) not null,
tekst varchar (255) not null,
ime varchar (50) not null,
prezime varchar (50) not null,
telefon char (14) not null,
eposta varchar (100),
statusporuke int not null
);

create table statusporuke (
sifra int not null primary key identity(1,1),
naziv varchar (50),
boja varchar (10) not null
);

create table operater (
sifra int not null primary key identity(1,1),
korisnickoime varchar (50) not null,
lozinka varchar (50) not null,
poruka int,
statusporuke int
);


alter table odvjetnik add foreign key (poruka) references poruka(sifra);

alter table odvjetnik add foreign key (podrucjerada) references podrucjerada(sifra);

alter table poruka add foreign key (podrucjerada) references podrucjerada(sifra);

alter table poruka add foreign key (statusporuke) references statusporuke(sifra);

alter table operater add foreign key (statusporuke) references statusporuke(sifra);

alter table operater add foreign key (poruka) references poruka(sifra);