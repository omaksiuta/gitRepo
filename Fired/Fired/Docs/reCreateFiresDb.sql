-- Скрипт сгенерирован Devart dbForge Studio for MySQL, Версия 6.0.568.0
-- Домашняя страница продукта: http://www.devart.com/ru/dbforge/mysql/studio
-- Дата скрипта: 26.11.2013 8:13:07
-- Версия сервера: 5.5.29
-- Версия клиента: 4.1

-- 
-- Установка базы данных по умолчанию
--
USE test;

--
-- Описание для таблицы tbl_companies
--
DROP TABLE tbl_companies;
CREATE TABLE IF NOT EXISTS tbl_companies (
  COMPANY_ID int(11) NOT NULL AUTO_INCREMENT,
  COMPANY_NAME varchar(50) DEFAULT NULL,
  PARENT_COMPANY_ID int(11) DEFAULT NULL,
  COMPANY_URL varchar(255) DEFAULT NULL,
  GEO_ID int(11) DEFAULT NULL,
  PRIMARY KEY (COMPANY_ID)
)
ENGINE = INNODB
AUTO_INCREMENT = 1
CHARACTER SET latin1
COLLATE latin1_swedish_ci
COMMENT = 'List of Companies for classification';

--
-- Описание для таблицы tbl_fires
--
DROP TABLE tbl_fires;
CREATE TABLE IF NOT EXISTS tbl_fires (
  FIRE_ID int(11) NOT NULL AUTO_INCREMENT,
  USER_ID int(11) DEFAULT NULL,
  FIRE_DATE datetime DEFAULT NULL,
  COMPANY_ID int(11) DEFAULT NULL,
  INDUSTRY_ID int(11) DEFAULT NULL,
  POSITION_ID int(11) DEFAULT NULL,
  REASON_ID int(11) DEFAULT NULL,
  CREATE_DATETIME datetime DEFAULT NULL,
  UPDATE_DATETIME datetime DEFAULT NULL,
  PRIMARY KEY (FIRE_ID)
)
ENGINE = INNODB
AUTO_INCREMENT = 1
CHARACTER SET latin1
COLLATE latin1_swedish_ci
COMMENT = 'Fire info )))';

--
-- Описание для таблицы tbl_industries
--
DROP TABLE tbl_industries;
CREATE TABLE IF NOT EXISTS tbl_industries (
  INDUSTRY_ID int(11) NOT NULL AUTO_INCREMENT,
  INDUSTRY_NAME varchar(50) DEFAULT NULL,
  NOTES varchar(255) DEFAULT NULL,
  PRIMARY KEY (INDUSTRY_ID)
)
ENGINE = INNODB
AUTO_INCREMENT = 1
CHARACTER SET latin1
COLLATE latin1_swedish_ci
COMMENT = 'IT industry for the start';

--
-- Описание для таблицы tbl_users
--
DROP TABLE tbl_users;
CREATE TABLE IF NOT EXISTS tbl_users (
  USER_ID int(11) NOT NULL AUTO_INCREMENT,
  USER_GROUP_ID int(11) DEFAULT NULL,
  EMAIL varchar(50) NOT NULL,
  USER_PASSWORD varchar(255) NOT NULL,
  SECRET_QUESTION_ID int(11) DEFAULT NULL,
  SECRET_ANSWER varchar(255) DEFAULT NULL,
  FIRST_NAME varchar(50) DEFAULT NULL,
  MIDLE_NAME varchar(50) DEFAULT NULL,
  LAST_NAME varchar(50) DEFAULT NULL,
  BIRTH_DATE datetime DEFAULT NULL,
  GENDER char(1) DEFAULT NULL,
  LANGUAGE_ID int(11) DEFAULT NULL,
  COUNTRY_ID int(11) DEFAULT NULL,
  CAPTCHA varchar(255) DEFAULT NULL,
  IP_ADDRESS varchar(255) DEFAULT NULL,
  IS_LOCKED tinyint(1) DEFAULT NULL,
  CREATE_DATETIME datetime DEFAULT NULL,
  UPDATE_DATETIME datetime DEFAULT NULL,
  PRIMARY KEY (USER_ID)
)
ENGINE = INNODB
AUTO_INCREMENT = 1
CHARACTER SET latin1
COLLATE latin1_swedish_ci;