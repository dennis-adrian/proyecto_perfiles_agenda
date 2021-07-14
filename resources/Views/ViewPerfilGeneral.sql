CREATE VIEW ViewPerfilGeneral
AS
select P.id as Id,

  (SELECT coalesce(MAX(R.nro_revision), 0)
   from revision as R
   where R.id_tesis = P.id) as Revisiones,
       P.tema as Tema,
       P.estado as Estado_Proyecto,
       P.fecha_aprobacion_jefe_carrera as Fecha_Aprobacion,
       P.fecha_recepcion_titulacion as Fecha_Recepcion,
       P.fecha_limite as Fecha_limite,
       P.estado_defensa as Estado_Defensa,
       P.calificacion as Calificacion,
       E.id as Id_estudiante,
       E.registro as Registro,
       E.nombre||' '||E.apellido as Alumno,
       E.nombre as Nombre,
       E.apellido as Apellido,
       E.email as Email,
       E.telefono as Telefono,
       E.celular as Celular,
       C.id as Id_carrera,
       C.nombre as Carrera,
       F.nombre as Facultad,
       L.id as Id_licenciado,
       L.nombre||' '||L.apellido as Licenciado,
       L.tipo as Tipo,
       TL.id as Id_funcion_licenciado,
       TL.funcion as Funcion 
From perfil_tesis as P
inner join estudiante as E on P.id_estudiante = E.id
inner join carrera as C on E.id_carrera = C.id
inner join facultad as F on C.id_facultad = F.id
inner join licenciado as L on L.id = P.id_licenciado
inner join funcion_licenciado as TL on TL.id = P.id_funcion_licenciado;