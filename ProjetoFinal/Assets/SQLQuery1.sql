select * from users

ALTER TABLE Users 
ALTER COLUMN Codigo int

EXEC sp_RENAME 'Codigo' , 'Password', 'COLUMN'

select * from make
where title = 'Opel'

delete from make
where title = 'carro'

select * from model
where title = 'corsa'

delete from model
where title = 'carro'

select mo.id as Número, mo.code as 'Código do Modelo', mo.title as Modelo, ma.code as 'Código da Marca', ma.title as Marca from make as ma inner join model as mo on mo.make_id = ma.id

select mo.make_id, mo.code, mo.title, ma.code, ma.title from model as mo inner join make as ma on ma.id = mo.make_id where mo.i

select id as Número, code as Código, title as Marca from make

select make_id from model as mo inner join make as ma on ma.id = mo.make_id where ma.title = 'bmw' group by make_id

select make_id from model as mo inner join make as ma on ma.id = mo.make_id where ma.title = 'opel' group by make_id

delete from make where title = 'Opel'

select mo.id as Número, mo.code as 'Código do Modelo', mo.title as Modelo, ma.code as 'Código da Marca', ma.title as Marca from make as ma inner join model as mo on mo.make_id = ma.id where mo.make_id in (select id from make where title = 'carro')


select make_id from make as ma
inner join model as mo on mo.make_id = ma.id
where make_id in (select make_id from model where id = 1 )