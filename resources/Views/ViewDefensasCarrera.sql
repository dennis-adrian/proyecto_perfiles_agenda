CREATE VIEW ViewDefensasCarrera 
AS 

select * from (
select DE.id as Id,DE.fecha_presentacion as Fecha_Defensa ,DE.hora as Hora,DE.aula as Aula,"Tesis" as Tipo, PF.tema as Tema, ES.registro as Registro ,ES.nombre||' '||ES.apellido as Estudiante, CA.nombre as Carrera from defensa_externa as DE inner join perfil_tesis as PF on DE.id_tesis = PF.id  inner join estudiante as ES on PF.id_estudiante = ES.id inner join carrera as CA on ES.id_carrera = CA.id inner join facultad as FA on CA.id_facultad = FA.id  where DE.id_tesis >= 0 or DE.id_tesis != null
 UNION 
select DE.id as Id,DE.fecha_presentacion as Fecha_Defensa ,DE.hora as Hora,DE.aula as Aula,TTO.tipo as Tipo, TOS.tema as Tema, ES.registro as Registro,ES.nombre||' '||ES.apellido as Estudiante,CA.nombre as Carrera  from defensa_externa as DE inner join titulacion_otros as TOS on DE.id_titulacion_otro = TOS.id  inner join tipo_titulacion_otros as TTO on TOS.id_tipo_titulacion = TTO.id    inner join estudiante as ES on TOS.id_estudiante = ES.id inner join carrera as CA on ES.id_carrera = CA.id inner join facultad as FA on CA.id_facultad = FA.id  where DE.id_titulacion_otro  >= 0 or DE.id_titulacion_otro != null

);