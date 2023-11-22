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

select naziv, cijena from smjerovi;

select naziv, 'Osijek', 8, 9.8 from smjerovi;

select naziv as smjer, 'Osijek' as grad from smjerovi;

select naziv, getdate() as datum from smjerovi;

select 1;

select naziv, len(naziv) as duzina,
getdate() as datum from smjerovi;

select sifra as s, naziv as n, 'Edunova' as skola,
len(naziv) as duzina, * from smjerovi

select * from smjerovi where sifra=1;

select * from polaznici where sifra >= 2;

select * from polaznici where sifra !=1;

select * from polaznici where ime='Petra';

select * from grupe where datumpocetka > '2023-09-01';

select * from polaznici where sifra >1 and sifra < 3; 

select * from polaznici where prezime='Plečaš' or sifra=2;

select * from polaznici where not sifra=2;

select * from polaznici where ime like '%a%' ;

select * from polaznici where prezime like 'P%';

select * from polaznici where prezime like '%nt';

select * from polaznici where 
sifra between 1 and 3;

select * from grupe where 
datumpocetka between '2023-01-01' and '2023-12-31';

select * from smjerovi where brojsati is null;

select isnull (brojsati,0) as bs from smjerovi;

select * from polaznici order by prezime desc, 2 desc;

select top 1 * from polaznici;

select top 50 percent * from polaznici;




select ime as djever, brojugovora as racun 
into nova
from polaznici;

select * from nova;

drop table nova;


