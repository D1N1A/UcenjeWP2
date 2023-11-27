select * from grupe;

select * from smjerovi where sifra=1;

select a.*, b.*
from grupe a inner join smjerovi b
on b.sifra=a.smjer;

select a.sifra, a.naziv, b.naziv as smjer
from grupe a inner join smjerovi b
on b.sifra=a.smjer;

select a.sifra, a.naziv, b.naziv as smjer,
a.datumpocetka
from grupe a inner join smjerovi b 
on b.sifra=a.smjer;

select a.sifra, a.naziv, b.naziv as smjer,
a.datumpocetka, c.ime, c.prezime
from grupe a inner join smjerovi b
on b.sifra=a.smjer
inner join predavaci c
on c.sifra=a.predavac;

select a.sifra, a.naziv, b.naziv as smjer,
a.datumpocetka, c.ime, c.prezime,
concat (e.ime, ' ', e.prezime) as polaznik
from grupe a inner join smjerovi b on b.sifra = a.smjer left join predavaci c
on c.sifra=a.predavac
inner join clanovi d on a.sifra = d.grupa
inner join polaznici e on d.polaznik = e.sifra;

