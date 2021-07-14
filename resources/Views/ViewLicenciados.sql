CREATE VIEW ViewLicenciados
as
select L.id as Id, L.nombre as Nombre, L.apellido as Apellido , L.tipo as Tipo, L.telefono as Telefono, L.celular as Celular, L.email as Email from licenciado as L;