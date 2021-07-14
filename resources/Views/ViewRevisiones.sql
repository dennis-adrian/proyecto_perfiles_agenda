CREATE VIEW ViewRevisiones
as


SELECT R.id as Id, R.estado as Estado, R.fecha_entrega_alumno as Fecha_entrega_alumno,R.fecha_entrega_tribunal as Fecha_entrega_tribunal,R.fecha_limite_devolucion as Fecha_limite_devolucion, R.fecha_devolucion_tribunal as Fecha_devolucion_tribunal, R.fecha_devolucion_alumno as Fecha_devolucion_alumno, R.observacion as Observacion,R.nro_tribunal as Nro_tribunal, R.nro_revision as Nro_revision, R.fecha_empaste as Fecha_empaste,R.id_tesis as Id_tesis,DR.id as Id_detalle_revision,L.id as Id_Licenciado,L.nombre||' '||L.apellido as Licenciado,L.tipo as Tipo,DR.id_funcion_licenciado as Id_funcion_licenciado,FL.funcion as Funcion_licenciado 
FROM revision as R INNER JOIN detalle_revision as DR ON DR.id_revision = R.id INNER JOIN licenciado as L ON L.id = DR.id_licenciado INNER JOIN funcion_licenciado as FL ON FL.id = DR.id_funcion_licenciado;