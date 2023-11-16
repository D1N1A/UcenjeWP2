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

	


