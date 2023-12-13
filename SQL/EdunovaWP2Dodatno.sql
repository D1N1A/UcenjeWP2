use edunovawp2;

update a
set 
a.ime = concat (a.ime, 'W')
from polaznici a
inner join clanovi b on a.sifra = b.polaznik
inner join grupe c on b.grupa = c.sifra
inner join smjerovi d on c.smjer= d.sifra
where d.naziv = 'Web programiranje' ;

delete c
from smjerovi a
inner join grupe b on a.sifra = b.smjer
inner join clanovi c on b.sifra = c.grupa
where a.naziv = 'Web programiranje' ;

select getdate ();

select dateadd(day,45,getdate());

select upper(ime) from polaznici;

select concat(ime,' ',prezime) as polaznik from polaznici
order by prezime;

select left (ime,1) from polaznici;

select * from smjerovi;

update smjerovi set cijena = rand()*1000;

select rand ();

alter table smjerovi add iznos decimal (18,2) ;

alter table smjerovi alter column iznos decimal (18,2) not null;

update smjerovi set iznos = 1;

create function email (
	@ime varchar (50), @prezime varchar (50)
	)
returns varchar (150) as
begin 
	return concat (left(lower(@ime),1),'.',lower(
			replace(
			replace(
			replace(
			replace(
			replace(upper(@prezime),' ',''),'Č','C')
			,'Š','S')
			,'Đ','D')
			,'Ć','C')
			,'Ž','Z')
			),'@edunova.hr');
end;









