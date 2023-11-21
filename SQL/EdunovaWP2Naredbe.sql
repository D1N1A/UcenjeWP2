select * from smjerovi;

insert into smjerovi (naziv,brojsati,cijena,upisnina,verificiran) values
('Web programiranje',225,1325.85,null,1);


--minimalni unos (samo not null -->Baza(naziv) - Tables - naziv tablice i pogledati koji su not null)
insert into smjerovi (naziv) values
('Java programiranje'), ('Serviser');

insert into predavaci (ime, prezime, email) values
('Tomislav', 'Jakopec', 'tjakopec@gmail.com'),
('Shaquille', 'O''Neal', 'shaki@gmail.com');

select * from predavaci;

insert into polaznici (prezime,ime,email) values
('Adriana','Plečaš','adriana.plecas@gmail.com'),
('Petra','Božić','bozic.petra35@gmail.com');

select * from polaznici;

insert into grupe (naziv,smjer,datumpocetka) values
('WP1',1,'2023-04-24 17:00:00'),
('WP2',1,'2023-10-30 17:00:00'),
('JP28',2,'2023-04-24 19:00:00');

select * from grupe;

insert into clanovi (grupa,polaznik) values
(2,1),
(2,2);

select * from clanovi;

select * from polaznici;

update polaznici set prezime = 'Edunova'
where sifra=2;

update polaznici set prezime = 'Božić',
oib='53805878807' , brojugovora = '25/2023'
where sifra =2;

select * from polaznici where sifra = 2;

update polaznici set ime = 'Petra'
where sifra = 2;

update smjerovi set cijena = 1000
where sifra in (2,3);


update smjerovi set cijena = cijena*1.2;

update smjerovi set cijena = cijena*0.8;

update smjerovi set cijena=cijena-15;

update smjerovi set cijena=cijena+15;

update smjerovi set upisnina = cijena*0.1;

update smjerovi set cijena = 1489.52 
where sifra=2;

insert into smjerovi (naziv)
values ('Phyton programiranje');

delete from smjerovi where sifra = 4;

delete from polaznici where sifra = 1;