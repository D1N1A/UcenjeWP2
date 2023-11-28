use knjiznica;

select * from katalog;

select a.naslov, b.ime, b.prezime
from katalog a inner join autor b
on a.autor = b.sifra;

select a.naslov, b.ime, b.prezime
from katalog a right join autor b
on a.autor = b.sifra;

select a.naslov, b.ime, b.prezime
from katalog a left join autor b
on a.autor = b.sifra
where a.naslov like '%ljubav%';

select a.naslov, b.ime, b.prezime, c.naziv
from katalog a left join autor b
on a.autor = b.sifra
inner join izdavac c on a.izdavac = c.sifra
where a.naslov like '%ljubav%';

select a.naslov, b.ime, b.prezime, c.naziv,
d.naziv
from katalog a inner join autor b
on a.autor = b.sifra
inner join izdavac c on a.izdavac = c.sifra
inner join mjesto d on a.mjesto =  d.sifra
where a.naslov like '%ljubav%';