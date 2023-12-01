use svastara;

select count (*) from kupci;

select * from kupci where ime = 'Bruno';

select count (*) from kupci where ime = 'Bruno';

select distinct ime,prezime
from kupci where ime= 'Bruno';