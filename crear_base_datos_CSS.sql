-- =============================================================
-- Script de creación de base de datos para CCS SOFTWARE / INTERFAZ_PC
-- Coincide con las columnas que usa el código C# (App.config: Database=CSS)
-- =============================================================

CREATE DATABASE IF NOT EXISTS CSS
    CHARACTER SET utf8mb4
    COLLATE utf8mb4_unicode_ci;

USE CSS;

-- -------------------------------------------------------------
-- Tabla: usuarios
-- -------------------------------------------------------------
CREATE TABLE IF NOT EXISTS usuarios (
    id         INT AUTO_INCREMENT PRIMARY KEY,
    NOMBRE     VARCHAR(100) NOT NULL,
    TELEFONO   VARCHAR(20)  NOT NULL,
    CORREO     VARCHAR(100) NOT NULL,
    CLAVE      VARCHAR(255) NOT NULL,   -- hash BCrypt (no texto plano)
    HORARIO    VARCHAR(50)  NOT NULL,
    OCUPACION  VARCHAR(50)  NOT NULL,
    AREA       VARCHAR(50)  NOT NULL,
    CARRERA    VARCHAR(100) NOT NULL,
    UID        VARCHAR(50)  NOT NULL UNIQUE   -- identificador de la tarjeta NFC
);

-- -------------------------------------------------------------
-- Tabla: guardias
-- -------------------------------------------------------------
CREATE TABLE IF NOT EXISTS guardias (
    id          INT AUTO_INCREMENT PRIMARY KEY,
    NOMBRE      VARCHAR(100) NOT NULL,
    DOMICILIO   VARCHAR(150) NOT NULL,
    TELEFONO    VARCHAR(20)  NOT NULL,
    CORREO      VARCHAR(100) NOT NULL,
    USUARIO     VARCHAR(50)  NOT NULL UNIQUE,  -- usuario de login del guardia
    CONTRASEÑA  VARCHAR(255) NOT NULL,         -- hash BCrypt (no texto plano)
    UID         VARCHAR(50)  NOT NULL UNIQUE
);

-- -------------------------------------------------------------
-- Tabla: invitados
-- -------------------------------------------------------------
CREATE TABLE IF NOT EXISTS invitados (
    id       INT AUTO_INCREMENT PRIMARY KEY,
    NOMBRE   VARCHAR(100) NOT NULL,
    TELEFONO VARCHAR(20)  NOT NULL,
    UID      VARCHAR(50)  NOT NULL UNIQUE
);

-- -------------------------------------------------------------
-- Tabla: administradores (nueva, no existía en el esquema original;
-- antes el login de admin estaba hardcodeado en el código)
-- -------------------------------------------------------------
CREATE TABLE IF NOT EXISTS administradores (
    id      INT AUTO_INCREMENT PRIMARY KEY,
    USUARIO VARCHAR(50)  NOT NULL UNIQUE,
    CLAVE   VARCHAR(255) NOT NULL   -- hash BCrypt (no texto plano)
);

-- =============================================================
-- Nota: este script NO inserta ningún administrador todavía porque
-- la contraseña debe guardarse como hash BCrypt, no en texto plano.
-- Sigue el paso "Genera el hash para el primer administrador" del
-- README_REFACTOR.md y luego corre el INSERT que ahí se explica.
-- =============================================================

-- -------------------------------------------------------------
-- Monitoreo: hora de entrada / salida en usuarios e invitados
-- Nulas porque al momento de REGISTRAR a alguien todavía no ha
-- entrado; se llenan cuando de verdad entra/sale (escaneo NFC
-- o acción manual en la pantalla de Monitoring).
-- Si ya habías corrido este script antes y solo quieres agregar
-- estas columnas a una base que ya existe, corre nada más este
-- bloque (IF NOT EXISTS evita error si ya las agregaste).
-- -------------------------------------------------------------
USE CSS;

ALTER TABLE usuarios
    ADD COLUMN IF NOT EXISTS HORA_ENTRADA DATETIME NULL,
    ADD COLUMN IF NOT EXISTS HORA_SALIDA  DATETIME NULL;

ALTER TABLE invitados
    ADD COLUMN IF NOT EXISTS HORA_ENTRADA DATETIME NULL,
    ADD COLUMN IF NOT EXISTS HORA_SALIDA  DATETIME NULL;
