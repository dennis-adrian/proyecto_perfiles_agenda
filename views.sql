-----------------------------------------------------------------
Vista: ViewDefensas
----------------------------------------------------------------
descricpion: vista de denfensas de todas las carreras
campos:
Id 
Fecha_Defensa
Hora
Aula
Tipo
Tema
Registro
Estudiante
Carrera
Facultad


CREATE VIEW ViewDefensas 
AS 

select * from (
select DE.id as Id,DE.fecha_presentacion as Fecha_Defensa ,DE.hora as Hora,DE.aula as Aula,"Tesis" as Tipo, PF.tema as Tema, ES.registro as Registro ,ES.nombre||' '||ES.apellido as Estudiante ,CA.nombre as Carrera,FA.nombre as Facultad  from defensa_externa as DE inner join perfil_tesis as PF on DE.id_tesis = PF.id  inner join estudiante as ES on PF.id_estudiante = ES.id inner join carrera as CA on ES.id_carrera = CA.id inner join facultad as FA on CA.id_facultad = FA.id  where DE.id_tesis > 0 and DE.id_tesis != null
 UNION 
select DE.id as Id,DE.fecha_presentacion as Fecha_Defensa ,DE.hora as Hora,DE.aula as Aula,TTO.tipo as Tipo, "descripcion de tema" as Tema, ES.registro as Registro ,ES.nombre||' '||ES.apellido as Estudiante , CA.nombre as Carrera, FA.nombre as Facultad  from defensa_externa as DE inner join titulacion_otros as TOS on DE.id_titulacion_otro = TOS.id  inner join tipo_titulacion_otros as TTO on TOS.id_tipo_titulacion = TTO.id    inner join estudiante as ES on TOS.id_estudiante = ES.id inner join carrera as CA on ES.id_carrera = CA.id inner join facultad as FA on CA.id_facultad = FA.id  where DE.id_titulacion_otro > 0 and DE.id_titulacion_otro != null );
-----------------------------------------------------------------
Vista: ViewDefensasCarrera
-----------------------------------------------------------------
descripcion: defensas por carrera 
campos:
Id 
Fecha_Defensa
Hora
Aula
Tipo
Tema
Registro
Estudiante

CREATE VIEW ViewDefensasCarrera 
AS 

select * from (
select DE.id as Id,DE.fecha_presentacion as Fecha_Defensa ,DE.hora as Hora,DE.aula as Aula,"Tesis" as Tipo, PF.tema as Tema, ES.registro as Registro ,ES.nombre||' '||ES.apellido as Estudiante, CA.nombre as Carrera from defensa_externa as DE inner join perfil_tesis as PF on DE.id_tesis = PF.id  inner join estudiante as ES on PF.id_estudiante = ES.id inner join carrera as CA on ES.id_carrera = CA.id inner join facultad as FA on CA.id_facultad = FA.id  where DE.id_tesis > 0 and DE.id_tesis != null
 UNION 
select DE.id as Id,DE.fecha_presentacion as Fecha_Defensa ,DE.hora as Hora,DE.aula as Aula,TTO.tipo as Tipo, "descripcion de tema" as Tema, ES.registro as Registro,ES.nombre||' '||ES.apellido as Estudiante,CA.nombre as Carrera  from defensa_externa as DE inner join titulacion_otros as TOS on DE.id_titulacion_otro = TOS.id  inner join tipo_titulacion_otros as TTO on TOS.id_tipo_titulacion = TTO.id    inner join estudiante as ES on TOS.id_estudiante = ES.id inner join carrera as CA on ES.id_carrera = CA.id inner join facultad as FA on CA.id_facultad = FA.id  where DE.id_titulacion_otro > 0 and DE.id_titulacion_otro != null

);

---------------------------------------------------------------
Vista:  ViewLicenciados
---------------------------------------------------------------
descripcion: vista de licenciados general
campos:

Id 
Nombre
Apellido
Tipo 
Telefono
Celular
Email


CREATE View ViewLicenciados
as
select L.id as Id, L.nombre as Nombre, L.apellido as Apellido , L.tipo as Tipo, L.telefono as Telefono, L.celular as Celular, L.email as Email from licenciado as L;


----------------------------------------------------------------
Vista: ViewPerfiles
----------------------------------------------------------------
descipcion:perfiles con carrera
campos:
Id
Estado_Proyecto
Registro
Estudiante
Carrera
Facultad
Tema
Tutor
Email
Telefono
Fecha_Recepcion

create view ViewPerfiles
as
select P.id as Id, P.estado as Estado_Proyecto, E.registro as Registro, E.nombre||' '||E.apellido as  Estudiante, C.nombre as Carrera, F.nombre as Facultad,  P.tema as Tema,L.nombre||' '||L.apellido as Tutor, E.email as Email , E.telefono as Telefono, P.fecha_recepcion_titulacion as Fecha_Recepcion  from perfil_tesis as  P inner join estudiante as E on P.id_estudiante = E.id inner join carrera as C on E.id_carrera = C.id inner join facultad as F on C.id_facultad = F.id inner join licenciado as L on P.id_licenciado = L.id;


------------------------------------------------------------
Vista: ViewPerfilesCarrera
-----------------------------------------------------------
descripcion: perfil por carrera
campos:
Id
Estado_Proyecto
Registro
Estudiante
Tema
Tutor
Email
Telefono
Fecha_Recepcion


create view ViewPerfilesCarrera
as
select P.id as Id, P.estado as Estado_Proyecto, E.registro as Registro, E.nombre||' '||E.apellido as  Estudiante, C.nombre as Carrera ,  P.tema as Tema, L.nombre||' '||L.apellido as Tutor, E.email as Email , E.telefono as Telefono, P.fecha_recepcion_titulacion as Fecha_Recepcion from perfil_tesis as  P inner join estudiante as E on P.id_estudiante = E.id inner join carrera as C on E.id_carrera = C.id inner join facultad as F on C.id_facultad = F.id inner join licenciado as L on P.id_licenciado = L.id;

-----------------------------------------------------------------
Vista: ViewPerfilGeneral
-----------------------------------------------------------------
descripcion: vista de todos los datos de perfil
campos:
Id 
Tema
Estado_Proyecto
Fecha_Aprobacion
Fecha_Recepcion
Estado_Defensa
Calificacion
Registro
Nombre
Apellido
Email
Telefono
Celular
Carrera
Facultad
Tutor
Tipo
Funcion
Institucion
Carrera_Licenciado

create view ViewPerfilGeneral
AS
select P.id as Id ,P.tema as Tema, P.estado as Estado_Proyecto, P.fecha_aprobacion_jefe_carrera as Fecha_Aprobacion, P.fecha_recepcion_titulacion as Fecha_Recepcion, P.estado_defensa as Estado_Defensa, P.calificacion as Calificacion, E.registro as Registro, E.nombre as Nombre, E.apellido as Apellido, E.email as Email, E.telefono as  Telefono, E.celular as Celular, C.nombre as Carrera,F.nombre as Facultad, L.nombre||' '||L.apellido as Licenciado, L.tipo as Tipo, TL.funcion as Funcion, I.nombre as Institucion, CL.nombre Carrera_Licenciado  From perfil_tesis as P inner join estudiante as E on P.id_estudiante = E.id inner join carrera as C on E.id_carrera = C.id inner join facultad as  F on C.id_facultad = F.id inner join licenciado as L on L.id = P.id_licenciado inner join funcion_licenciado as TL on TL.id = P.id_funcion_licenciado inner join institucion as I on L.id_institucion_representada = I.id inner join carrera_licenciado as CL on CL.id = L.id_carrera_licenciado ;


