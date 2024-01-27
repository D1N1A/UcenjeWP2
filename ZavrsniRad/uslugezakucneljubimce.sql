use master;
go
drop database if exists uslugezakucneljubimce;
go

create database uslugezakucneljubimce;
go
alter database uslugezakucneljubimce collate Croatian_CI_AS;
go
use uslugezakucneljubimce;

create table pruzateljusluge (
sifra int not null primary key identity(1,1),
ime varchar (50) not null,
prezime varchar (50),
usluga int not null,
fotografija varchar (255),
telefon char (14) not null,
adresa varchar (50) not null,
eposta varchar (100)
);


create table usluga (
sifra int not null primary key identity(1,1),
naziv varchar (255) not null
);

create table klijent (
sifra int not null primary key identity(1,1),
usluga int not null,
pruzateljusluge int,
imeklijenta varchar (50) not null,
pasmina varchar  (50) not null,
napomena varchar (255) not null,
imevlasnika varchar (50) not null,
prezimevlasnika varchar (50) not null,
telefon char (14) not null,
eposta varchar (100),
statusrezervacije int not null,
);

create table statusrezervacije (
sifra int not null primary key identity(1,1),
naziv varchar (50),
boja varchar (10) not null,
);

create table operater (
sifra int not null primary key identity(1,1),
korisnickoime varchar (50) not null,
lozinka varchar (240) not null,
);



alter table klijent add foreign key (pruzateljusluge) references pruzateljusluge(sifra);

alter table pruzateljusluge add foreign key (usluga) references usluga(sifra);

alter table klijent add foreign key (usluga) references usluga(sifra);

alter table klijent add foreign key  (statusrezervacije) references statusrezervacije (sifra);