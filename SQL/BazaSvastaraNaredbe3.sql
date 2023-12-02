
select count (*) from Artikli;

select distinct Artikl from ArtikliNaPrimci;

--podupit

select * from artikli where sifra
not in (select distinct artikl from artiklinaprimci);

--brisanje ta dva artikla iz podupita

delete from artikli where sifra
not in (select distinct artikl from artiklinaprimci);

i

