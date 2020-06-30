CREATE TABLE IF NOT EXISTS "facultad" (
    "id" INTEGER PRIMARY KEY,
    "nombre" TEXT UNIQUE,
    "creado_en" TEXT DEFAULT CURRENT_TIMESTAMP NOT NULL,
    "modificado_en" TEXT DEFAULT CURRENT_TIMESTAMP NOT NULL
);
CREATE TABLE IF NOT EXISTS "carrera" (
    "id" INTEGER PRIMARY KEY,
    "nombre" TEXT UNIQUE,
    "id_facultad" INTEGER NOT NULL,
    "creado_en" TEXT DEFAULT CURRENT_TIMESTAMP NOT NULL,
    "modificado_en" TEXT DEFAULT CURRENT_TIMESTAMP NOT NULL,
    CONSTRAINT fk_facultad_carrera FOREIGN KEY ("id_facultad") REFERENCES "facultad"("id")
);
CREATE TABLE IF NOT EXISTS "institucion" (
    "id" INTEGER PRIMARY KEY,
    "nombre" TEXT NOT NULL,
    "creado_en" TEXT DEFAULT CURRENT_TIMESTAMP NOT NULL,
    "modificado_en" TEXT DEFAULT CURRENT_TIMESTAMP NOT NULL
);
CREATE TABLE IF NOT EXISTS "carrera_licenciado" (
    "id" INTEGER PRIMARY KEY,
    "nombre" TEXT NOT NULL,
    "creado_en" TEXT DEFAULT CURRENT_TIMESTAMP NOT NULL,
    "modificado_en" TEXT DEFAULT CURRENT_TIMESTAMP NOT NULL
);
-- nombre modificado y se quito el campo "tipo"
CREATE TABLE IF NOT EXISTS "funcion_licenciado"(
    "id" INTEGER PRIMARY KEY,
    "funcion_licenciado" TEXT COMMENT 'tutor, tribunal interno 1 o 2, presidente, secretario, representante del ministrerio de educacion, representante uagrm 1 o 2',
    "descripcion" TEXT,
    "creado_en" TEXT DEFAULT CURRENT_TIMESTAMP NOT NULL,
    "modificado_en" TEXT DEFAULT CURRENT_TIMESTAMP NOT NULL
);
CREATE TABLE IF NOT EXISTS "licenciado" (
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
CREATE TABLE IF NOT EXISTS "estudiante" (
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
CREATE TABLE IF NOT EXISTS "perfil_tesis" (
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
    CONSTRAINT fk_tutor_perfiltesis FOREIGN KEY("id_licenciado") REFERENCES "licenciado"("id"),
    FOREIGN key ("id_funcion_licenciado") REFERENCES "funcion_licenciado"("id"),
    FOREIGN key ("id_estudiante") REFERENCES "estudiante" ("id")
);
CREATE TABLE IF NOT EXISTS "revision" (
    "id" INTEGER PRIMARY KEY,
    -- campo agregado
    "estado" TEXT COMMENT 'Aprobado o Reprobado',
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
CREATE TABLE IF NOT EXISTS "detalle_revision" (
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
CREATE TABLE IF NOT EXISTS "tipo_titulacion_otros"(
    "id" INTEGER PRIMARY KEY,
    "tipo" TEXT COMMENT 'examen de grado, graduación por excelencia',
    "descripcion" TEXT,
    "creado_en" TEXT DEFAULT CURRENT_TIMESTAMP NOT NULL,
    "modificado_en" TEXT DEFAULT CURRENT_TIMESTAMP NOT NULL
);
CREATE TABLE IF NOT EXISTS "titulacion_otros" (
    "id" INTEGER PRIMARY KEY,
    "estado_defensa" TEXT COMMENT 'aprobada o reprobada',
    "calificacion" REAL,
    "id_estudiante" INTEGER NOT NULL,
    "id_tipo_titulacion" INTEGER NOT NULL,
    "creado_en" TEXT DEFAULT CURRENT_TIMESTAMP NOT NULL,
    "modificado_en" TEXT DEFAULT CURRENT_TIMESTAMP NOT NULL,
    CONSTRAINT fk_estudiante_examengrado FOREIGN KEY("id_estudiante") REFERENCES "estudiante"("id"),
    FOREIGN KEY("id_tipo_titulacion") REFERENCES "tipo_titulacion_otros"("id")
);
CREATE TABLE IF NOT EXISTS "defensa_externa" (
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
CREATE TABLE IF NOT EXISTS "detalle_defensa" (
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
-- Activar las llaves foráneas
PRAGMA foreign_keys = ON -- INSERTS
INSERT INTO facultad (nombre)
VALUES ('Ciencias Empresariales');
INSERT INTO facultad (nombre)
VALUES ('Ciencias y Tecnología');
INSERT INTO facultad (nombre)
VALUES ('Ciencias Jurídicas, Sociales');
INSERT INTO carrera (nombre, id_facultad)
VALUES ('carrera1', 1);