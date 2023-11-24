select count (*) from autor;

select * from autor where datumrodenja between '1995-01-01' and '1995-12-31';

insert into autor (sifra,ime,prezime,datumrodenja) values
(5623,'Adriana','Plečaš','1995-04-11');

update autor set ime = 'Bruno'
where sifra = 5623;

select * from katalog where (naslov like '%bol%' or naslov like '%ljubav%')
and sifra not in (2541,2596, 2680);


select * from izdavac where aktivan=0;

select * from izdavac where naziv like ('%d%.%o%.%.%')
and sifra != 531;

select * from mjesto where postanskibroj like '31%';

select * from autor where ime like '%a';

select ime from autor where ime like '%a';

select distinct ime from autor where ime like '%a';








