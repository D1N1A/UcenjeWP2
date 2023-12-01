
select count (*) from artikli
where cijena between 1000 and 1100;


select b.*
from opcine a inner join mjesta b
on a.sifra = b.opcina
where a.naziv='Čepin';

update mjesta set postanskiBroj='31431' where sifra = 1945;

-- inner join radi i kada ne postoji veza primarni i vanjski ključ

select b.ime, b.prezime
from mjesta a inner join kupci b
on b.mjesto = a.sifra
where a.naziv='Livana';

select b.ime, b.prezime
from mjesta a inner join kupci b
on b.mjesto = a.sifra
where a.naziv='Osijek';

select count (*) from primke where 
datum between '2017-01-01' and '2017-12-31';

select top 1* from primke where 
datum between '2017-01-01' and '2017-12-31';

select c.kratkiNaziv, b.kolicina, b.cijena
from Primke a 
inner join ArtikliNaPrimci b on a.sifra=b.primka
inner join Artikli c on b.artikl=c.sifra
where a.rednibroj='14788/2017';

select c.kratkiNaziv, b.kolicina, b.cijena,
b.kolicina * b.cijena as iznos
from Primke a 
inner join ArtikliNaPrimci b on a.sifra=b.primka
inner join Artikli c on b.artikl=c.sifra
where a.rednibroj='14788/2017'
order by iznos desc;

select sum (b.kolicina * b.cijena) as ukupniIznos
from Primke a 
inner join ArtikliNaPrimci b on a.sifra=b.primka
inner join Artikli c on b.artikl=c.sifra
where a.rednibroj='14788/2017'
;

select sum (b.kolicina * b.cijena) as ukupniIznos
from Primke a 
inner join ArtikliNaPrimci b on a.sifra=b.primka
inner join Artikli c on b.artikl=c.sifra
where a.datum between '2017-01-01' and '2017-12-31';

select a.rednibroj, sum (b.kolicina * b.cijena) as ukupniIznos
from Primke a 
inner join ArtikliNaPrimci b on a.sifra=b.primka
inner join Artikli c on b.artikl=c.sifra
where a.datum between '2017-01-01' and '2017-12-31'
group by a.rednibroj
order by 2 desc;


--having
select a.rednibroj, d.naziv,
sum (b.kolicina * b.cijena) as ukupniIznos
from Primke a 
inner join ArtikliNaPrimci b on a.sifra=b.primka
inner join Artikli c on b.artikl=c.sifra
inner join Dobavljaci d on a.dobavljac=d.sifra
where a.datum between '2017-01-01' and '2017-12-31'
group by a.rednibroj, d.naziv
having sum (b.kolicina * b.cijena)>7000000
order by 3 desc;


select a.rednibroj, d.naziv,
sum (b.kolicina * b.cijena) as ukupniIznos,
avg (b.kolicina * b.cijena) as prosjek,
min (b.kolicina * b.cijena) as minimalno,
max (b.kolicina * b.cijena) as maksimalno
from Primke a 
inner join ArtikliNaPrimci b on a.sifra=b.primka
inner join Artikli c on b.artikl=c.sifra
inner join Dobavljaci d on a.dobavljac=d.sifra
where a.datum between '2017-01-01' and '2017-12-31'
group by a.rednibroj, d.naziv
having sum (b.kolicina * b.cijena)>7000000
order by 3 desc;


select a.rednibroj, d.naziv,
sum (b.kolicina * b.cijena) as ukupniIznos,
avg (b.kolicina * b.cijena) as prosjek,
min (b.kolicina * b.cijena) as minimalno,
max (b.kolicina * b.cijena) as maksimalno
from Primke a 
inner join ArtikliNaPrimci b on a.sifra=b.primka
inner join Artikli c on b.artikl=c.sifra
inner join Dobavljaci d on a.dobavljac=d.sifra
where a.datum between '2017-01-01' and '2017-01-31'
group by a.rednibroj, d.naziv
having sum (b.kolicina * b.cijena)>7000000
order by 3 desc;

--KLAUZULE: select into, select, from, where, group by, having , order by