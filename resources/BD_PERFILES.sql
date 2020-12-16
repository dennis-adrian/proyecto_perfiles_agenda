BD PERFILES 

==============================

===========================
----CARRERA---------------

CREATE TABLE "carrera" (
    "id" INTEGER PRIMARY KEY,
    "nombre" TEXT UNIQUE,
    "id_facultad" INTEGER NOT NULL,
    "creado_en" TEXT DEFAULT CURRENT_TIMESTAMP NOT NULL,
    "modificado_en" TEXT DEFAULT CURRENT_TIMESTAMP NOT NULL,
    CONSTRAINT fk_facultad_carrera FOREIGN KEY ("id_facultad") REFERENCES "facultad"("id")
);

===============================================

----CARRERA_LICENCIADO-------

CREATE TABLE "carrera_licenciado" (
    "id" INTEGER PRIMARY KEY,
    "nombre" TEXT NOT NULL,
    "creado_en" TEXT DEFAULT CURRENT_TIMESTAMP NOT NULL,
    "modificado_en" TEXT DEFAULT CURRENT_TIMESTAMP NOT NULL
);

=================================================

------DEFENSA EXTERNA-----------------

CREATE TABLE "defensa_externa" (
    "id" INTEGER PRIMARY KEY,
    "fecha_presentacion" TEXT NOT NULL,
    "hora" TEXT NOT NULL,
    "aula" TEXT NOT NULL,
    "id_tesis" INTEGER,
    "id_titulacion_otro" INTEGER,
    "creado_en" TEXT DEFAULT CURRENT_TIMESTAMP NOT NULL,
    "modificado_en" TEXT DEFAULT CURRENT_TIMESTAMP NOT NULL,
    CONSTRAINT fk_perfiltesis_defensaexterna FOREIGN KEY("id_tesis") REFERENCES "perfil_tesis"("id"),
    FOREIGN KEY("id_titulacion_otro") REFERENCES "titulacion_otros"("id")
);


========================================================

------DETALLE_DEFENSA------------------

CREATE TABLE "detalle_defensa" (
    "id" INTEGER PRIMARY KEY,
    "id_defensa_externa" INTEGER NOT NULL,
    "id_licenciado" INTEGER NOT NULL,
    "id_funcion_licenciado" INTEGER NOT NULL,
    "creado_en" TEXT DEFAULT CURRENT_TIMESTAMP NOT NULL,
    "modificado_en" TEXT DEFAULT CURRENT_TIMESTAMP NOT NULL,
    FOREIGN KEY("id_licenciado") REFERENCES "licenciado"("id"),
    FOREIGN KEY("id_funcion_licenciado") REFERENCES "funcion_licenciado"("id"),
    FOREIGN KEY("id_defensa_externa") REFERENCES "defensa_externa"("id")
);


===========================================================


-----DETALLE_REVISION----------------------

CREATE TABLE "detalle_revision" (
    "id" INTEGER PRIMARY KEY,
    "id_revision" INTEGER NOT NULL,
    "id_licenciado" INTEGER NOT NULL,
    "id_funcion_licenciado" INTEGER,
    "creado_en" TEXT DEFAULT CURRENT_TIMESTAMP NOT NULL,
    "modificado_en" TEXT DEFAULT CURRENT_TIMESTAMP NOT NULL,
    CONSTRAINT fk_revision_revisionlicenciado FOREIGN KEY("id_revision") REFERENCES "revision"("id"),
    CONSTRAINT fk_licenciado_revisionlicenciado FOREIGN KEY("id_licenciado") REFERENCES "licenciado"("id"),
    FOREIGN key ("id_funcion_licenciado") REFERENCES "funcion_licenciado"("id")
);


=======================================================


------ESTUDIANTE-------------------------

CREATE TABLE "estudiante" (
    "id" INTEGER PRIMARY KEY,
    "registro" TEXT NOT NULL,
    "nombre" TEXT NOT NULL,
    "apellido" TEXT NOT NULL,
    "email" TEXT,
    "telefono" TEXT,
    "celular" TEXT,
    "id_carrera" INTEGER NOT NULL,
    "creado_en" TEXT DEFAULT CURRENT_TIMESTAMP NOT NULL,
    "modificado_en" TEXT DEFAULT CURRENT_TIMESTAMP NOT NULL,
    CONSTRAINT fk_carrera_estudiante FOREIGN KEY("id_carrera") REFERENCES "carrera"("id")
);


==========================================================

------FACULTAD-----------

CREATE TABLE "facultad" (
    "id" INTEGER PRIMARY KEY,
    "nombre" TEXT UNIQUE,
    "creado_en" TEXT DEFAULT CURRENT_TIMESTAMP NOT NULL,
    "modificado_en" TEXT DEFAULT CURRENT_TIMESTAMP NOT NULL
);


========================================================

-----FUNCION_LICENCIADO----------

CREATE TABLE "funcion_licenciado"(
    "id" INTEGER PRIMARY KEY,
    "funcion" TEXT COMMENT 'tutor, tribunal interno 1 o 2, presidente, secretario, representante del ministrerio de educacion, representante uagrm 1 o 2',
    "descripcion" TEXT,
    "creado_en" TEXT DEFAULT CURRENT_TIMESTAMP NOT NULL,
    "modificado_en" TEXT DEFAULT CURRENT_TIMESTAMP NOT NULL
    );

==========================================================

-------INSTITUCION-------------------

CREATE TABLE "institucion" (
    "id" INTEGER PRIMARY KEY,
    "nombre" TEXT NOT NULL,
    "creado_en" TEXT DEFAULT CURRENT_TIMESTAMP NOT NULL,
    "modificado_en" TEXT DEFAULT CURRENT_TIMESTAMP NOT NULL
);

====================================================

-------LICENCIADO----------------------

CREATE TABLE "licenciado" (
    "id" INTEGER PRIMARY KEY,
    "nombre" TEXT NOT NULL,
    "apellido" TEXT NOT NULL,
    "descripcion" TEXT,
    "email" TEXT UNIQUE,
    "telefono" TEXT,
    "celular" TEXT,
    -- campo agregado
    "tipo" TEXT COMMENT 'interno o externo',
    "docente" NUMERIC COMMENT '0 = no, 1 = si',
    "id_institucion_representada" INTEGER NOT NULL,
    "id_carrera_licenciado" INTEGER NOT NULL,
    "creado_en" TEXT DEFAULT CURRENT_TIMESTAMP NOT NULL,
    "modificado_en" TEXT DEFAULT CURRENT_TIMESTAMP NOT NULL,
    CONSTRAINT fk_institucion_licenciado FOREIGN KEY("id_institucion_representada") REFERENCES "institucion"("id"),
    CONSTRAINT fk_carrera_licenciado FOREIGN KEY("id_carrera_licenciado") REFERENCES "carrera_licenciado"("id")
);


=============================================================

-------NOTIFICACION------------------------

CREATE TABLE "notificacion" (
    "id" INTEGER PRIMARY KEY,    
    
    "titulo" TEXT NOT NULL,
    "mensaje" TEXT NOT NULL,
    "fecha" TEXT NOT NULL,
    "hora" TEXT NOT NULL,        
    "leido" INTEGER NOT NULL,
    "prioridad" TEXT NOT NULL,
    "tipo" TEXT NOT NULL,
    "id_perfil" INTEGER NOT NULL,
    "creado_en" TEXT DEFAULT CURRENT_TIMESTAMP NOT NULL,
    "modificado_en" TEXT DEFAULT CURRENT_TIMESTAMP NOT NULL,
    CONSTRAINT fk_id_perfil_notificacion FOREIGN KEY ("id_perfil") REFERENCES "perfil_tesis"("id")
);

==============================================================

NOTA: VERIFICAR LA COLUMNA FECHA_LIMITE

----------PERFIL_TESIS----------------------

CREATE TABLE "perfil_tesis" (
    "id" INTEGER PRIMARY KEY,
    "tema" TEXT NOT NULL,
    "estado" TEXT COMMENT 'recepcionado, rechazado, aprobado, en revision, abandonado' NOT NULL,
    "fecha_aprobacion_jefe_carrera" TEXT,
    "fecha_recepcion_titulacion" TEXT,
    "estado_defensa" TEXT COMMENT 'aprobada o reprobada',
    "calificacion" REAL,
    "id_estudiante" INTEGER NOT NULL,
    "id_licenciado" INTEGER COMMENT 'tutor de tesis' NOT NULL,
    "id_funcion_licenciado" INTEGER,
    "creado_en" TEXT DEFAULT CURRENT_TIMESTAMP NOT NULL,
    "modificado_en" TEXT DEFAULT CURRENT_TIMESTAMP NOT NULL, 
    "fecha_limite" TEXT NOT NULL,
    CONSTRAINT fk_tutor_perfiltesis FOREIGN KEY("id_licenciado") REFERENCES "licenciado"("id"),
    FOREIGN key ("id_funcion_licenciado") REFERENCES "funcion_licenciado"("id"),
    FOREIGN key ("id_estudiante") REFERENCES "estudiante" ("id")
);

=================================================================

------REVISION--------------------------

CREATE TABLE "revision" (
    "id" INTEGER PRIMARY KEY,
    -- campo agregado
    "estado" TEXT COMMENT 'Aprobado o Reprobado',
    -- campo agregado
    "fecha_entrega_alumno" TEXT COMMENT 'fecha alumno entrega su tesis',
    "fecha_entrega_tribunal" TEXT COMMENT 'fecha se entrega el trabajo a los tribunales',
    "fecha_limite_devolucion" TEXT COMMENT 'fecha limite para que el tribunal devuelva el trabajo revisado',
    "fecha_devolucion_tribunal" TEXT COMMENT 'fecha el tribunal devuelve el trabajo revisado',
    "fecha_devolucion_alumno" TEXT COMMENT 'fecha se entrega la resvision al alumno',
    --campo agregado
    "observacion" TEXT COMMENT 'comentarios que puede poner el usuario para la revisión',
    "nro_tribunal" INTEGER COMMENT '1 para tribunal 1, 2 para tribunal 2' NOT NULL,
    "nro_revision" INTEGER COMMENT 'revision 1, 2, 3...' NOT NULL,
    "fecha_empaste" TEXT COMMENT 'si no hay empaste es NULL',
    "id_tesis" INTEGER NOT NULL,
    "creado_en" TEXT DEFAULT CURRENT_TIMESTAMP NOT NULL,
    "modificado_en" TEXT DEFAULT CURRENT_TIMESTAMP NOT NULL,
    CONSTRAINT fk_perfiltesis_revision FOREIGN KEY("id_tesis") REFERENCES "perfil_tesis"("id")
);


=============================================================

---------TIPO_TITULACION_OTROS----------------------

CREATE TABLE "tipo_titulacion_otros"(
    "id" INTEGER PRIMARY KEY,
    "tipo" TEXT COMMENT 'examen de grado, graduación por excelencia',
    "descripcion" TEXT
);

==============================================================

----------TITULACION_OTROS-----------------------

CREATE TABLE "titulacion_otros" (
    "id" INTEGER PRIMARY KEY,
    "estado_defensa" TEXT COMMENT 'aprobada o reprobada',
    "tema" TEXT COMMENT 'tema',
    "calificacion" REAL,
    "id_estudiante" INTEGER NOT NULL,
    "id_tipo_titulacion" INTEGER NOT NULL,
    "creado_en" TEXT DEFAULT CURRENT_TIMESTAMP NOT NULL,
    "modificado_en" TEXT DEFAULT CURRENT_TIMESTAMP NOT NULL,
    CONSTRAINT fk_estudiante_examengrado FOREIGN KEY("id_estudiante") REFERENCES "estudiante"("id"),
    FOREIGN KEY("id_tipo_titulacion") REFERENCES "tipo_titulacion_otros"("id")
);

===============================================================


===============================================================
=======================Vistas==================================
===============================================================

CREATE VIEW ViewDefensas 
    AS 

    select * from (
    select DE.id as Id,DE.fecha_presentacion as Fecha_Defensa ,DE.hora as Hora,DE.aula as Aula,"Tesis" as Tipo, PF.tema as Tema, ES.registro as Registro ,ES.nombre||' '||ES.apellido as Estudiante ,CA.nombre as Carrera,FA.nombre as Facultad  from defensa_externa as DE inner join perfil_tesis as PF on DE.id_tesis = PF.id  inner join estudiante as ES on PF.id_estudiante = ES.id inner join carrera as CA on ES.id_carrera = CA.id inner join facultad as FA on CA.id_facultad = FA.id  where DE.id_tesis >= 0 or DE.id_tesis != null
     UNION 
    select DE.id as Id,DE.fecha_presentacion as Fecha_Defensa ,DE.hora as Hora,DE.aula as Aula,TTO.tipo as Tipo, TOS.tema as Tema, ES.registro as Registro ,ES.nombre||' '||ES.apellido as Estudiante , CA.nombre as Carrera, FA.nombre as Facultad  from defensa_externa as DE inner join titulacion_otros as TOS on DE.id_titulacion_otro = TOS.id  inner join tipo_titulacion_otros as TTO on TOS.id_tipo_titulacion = TTO.id    inner join estudiante as ES on TOS.id_estudiante = ES.id inner join carrera as CA on ES.id_carrera = CA.id inner join facultad as FA on CA.id_facultad = FA.id  where DE.id_titulacion_otro >= 0 or DE.id_titulacion_otro != null );
==============================================================
CREATE VIEW ViewDefensasCarrera 
    AS 

    select * from (
    select DE.id as Id,DE.fecha_presentacion as Fecha_Defensa ,DE.hora as Hora,DE.aula as Aula,"Tesis" as Tipo, PF.tema as Tema, ES.registro as Registro ,ES.nombre||' '||ES.apellido as Estudiante, CA.nombre as Carrera from defensa_externa as DE inner join perfil_tesis as PF on DE.id_tesis = PF.id  inner join estudiante as ES on PF.id_estudiante = ES.id inner join carrera as CA on ES.id_carrera = CA.id inner join facultad as FA on CA.id_facultad = FA.id  where DE.id_tesis >= 0 or DE.id_tesis != null
     UNION 
    select DE.id as Id,DE.fecha_presentacion as Fecha_Defensa ,DE.hora as Hora,DE.aula as Aula,TTO.tipo as Tipo, TOS.tema as Tema, ES.registro as Registro,ES.nombre||' '||ES.apellido as Estudiante,CA.nombre as Carrera  from defensa_externa as DE inner join titulacion_otros as TOS on DE.id_titulacion_otro = TOS.id  inner join tipo_titulacion_otros as TTO on TOS.id_tipo_titulacion = TTO.id    inner join estudiante as ES on TOS.id_estudiante = ES.id inner join carrera as CA on ES.id_carrera = CA.id inner join facultad as FA on CA.id_facultad = FA.id  where DE.id_titulacion_otro  >= 0 or DE.id_titulacion_otro != null

    );
==============================================================
CREATE VIEW ViewLicenciados
    as
    select L.id as Id, L.nombre as Nombre, L.apellido as Apellido , L.tipo as Tipo, L.telefono as Telefono, L.celular as Celular, L.email as Email from licenciado as L;
==============================================================
CREATE VIEW ViewPerfiles
    as
    select P.id as Id, P.estado as Estado_Proyecto, E.registro as Registro, E.nombre||' '||E.apellido as  Estudiante, C.nombre as Carrera, F.nombre as Facultad,  P.tema as Tema,L.nombre||' '||L.apellido as Tutor, E.email as Email , E.telefono as Telefono, P.fecha_recepcion_titulacion as Fecha_Recepcion  from perfil_tesis as  P inner join estudiante as E on P.id_estudiante = E.id inner join carrera as C on E.id_carrera = C.id inner join facultad as F on C.id_facultad = F.id inner join licenciado as L on P.id_licenciado = L.id;
==============================================================
CREATE VIEW ViewPerfilesCarrera
    as
    select P.id as Id, P.estado as Estado_Proyecto, E.registro as Registro, E.nombre||' '||E.apellido as  Estudiante, C.nombre as Carrera ,  P.tema as Tema, L.nombre||' '||L.apellido as Tutor, E.email as Email , E.telefono as Telefono, P.fecha_recepcion_titulacion as Fecha_Recepcion from perfil_tesis as  P inner join estudiante as E on P.id_estudiante = E.id inner join carrera as C on E.id_carrera = C.id inner join facultad as F on C.id_facultad = F.id inner join licenciado as L on P.id_licenciado = L.id;
==============================================================
CREATE VIEW ViewPerfilGeneral
    AS
    select P.id as Id, (SELECT coalesce(MAX(R.nro_revision),0) from revision as R where R.id_tesis = P.id)   as Revisiones ,P.tema as Tema, P.estado as Estado_Proyecto, P.fecha_aprobacion_jefe_carrera as Fecha_Aprobacion, P.fecha_recepcion_titulacion as Fecha_Recepcion, P.estado_defensa as Estado_Defensa, P.calificacion as Calificacion, E.registro as Registro, E.nombre as Nombre, E.apellido as Apellido, E.email as Email, E.telefono as  Telefono, E.celular as Celular, C.nombre as Carrera,F.nombre as Facultad, L.nombre||' '||L.apellido as Licenciado, L.tipo as Tipo, TL.funcion as Funcion, I.nombre as Institucion, CL.nombre Carrera_Licenciado  From perfil_tesis as P inner join estudiante as E on P.id_estudiante = E.id inner join carrera as C on E.id_carrera = C.id inner join facultad as  F on C.id_facultad = F.id inner join licenciado as L on L.id = P.id_licenciado inner join funcion_licenciado as TL on TL.id = P.id_funcion_licenciado inner join institucion as I on L.id_institucion_representada = I.id inner join carrera_licenciado as CL on CL.id = L.id_carrera_licenciado;
==============================================================
CREATE VIEW 'ViewPerfiltesisForUpdate' 
    as
    select 
           DE.id as Id, 
           DE.fecha_presentacion as Fecha_presentacion, 
           DE.hora as Hora, 
           DE.aula as Aula,  
           DE.id_tesis as Id_tesis,
           PF.estado as Estado,
           PF.fecha_aprobacion_jefe_carrera as Fecha_aprobacion_jefe_carrera,
           PF.fecha_recepcion_titulacion as Fecha_recepcion_titulacion,
           PF.estado_defensa as Estado_defensa, 
           PF.tema as Tema, 
           PF.calificacion as Calificacion, 
           PF.id_estudiante as Id_estudiante, 
           ES.registro as Registro, 
           ES.nombre as Nombre , 
           ES.apellido as Apellido, 
           ES.email as Email, 
           ES.telefono as Telefono, 
           ES.celular as Celular, 
           ES.id_carrera as Id_carrera, 
           CA.nombre as Carrera ,
           PF.id_licenciado as Id_licenciado,
           LI.nombre as NombreLicenciado,
           LI.apellido as ApellidoLicenciado,
           PF.id_funcion_licenciado as Id_funcion_licenciado,
           FL.funcion as Funcion

           from 
           defensa_externa as DE 
           inner join 
           perfil_tesis AS PF 
           on  PF.id = DE.id_tesis 
           inner join estudiante as ES 
           on ES.id = PF.id_estudiante 
           inner join carrera as CA 
           on ES.id_carrera = CA.id 
           inner join licenciado as LI 
           on LI.id = PF.id_licenciado
           inner join funcion_licenciado as FL 
           on FL.id = PF.id_funcion_licenciado;
==============================================================
CREATE VIEW ViewRevisiones
    as


    SELECT R.id as Id, R.estado as Estado, R.fecha_entrega_alumno as Fecha_entrega_alumno,R.fecha_entrega_tribunal as Fecha_entrega_tribunal,R.fecha_limite_devolucion as Fecha_limite_devolucion, R.fecha_devolucion_tribunal as Fecha_devolucion_tribunal, R.fecha_devolucion_alumno as Fecha_devolucion_alumno, R.observacion as Observacion,R.nro_tribunal as Nro_tribunal, R.nro_revision as Nro_revision, R.fecha_empaste as Fecha_empaste,R.id_tesis as Id_tesis,DR.id as Id_detalle_revision,L.id as Id_Licenciado,L.nombre||' '||L.apellido as Licenciado,L.tipo as Tipo,DR.id_funcion_licenciado as Id_funcion_licenciado,FL.funcion as Funcion_licenciado 
    FROM revision as R INNER JOIN detalle_revision as DR ON DR.id_revision = R.id INNER JOIN licenciado as L ON L.id = DR.id_licenciado INNER JOIN funcion_licenciado as FL ON FL.id = DR.id_funcion_licenciado;
==============================================================