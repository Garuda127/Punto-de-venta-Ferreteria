-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema Ferreteria
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema Ferreteria
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `Ferreteria` DEFAULT CHARACTER SET utf8 ;
USE `Ferreteria` ;

-- -----------------------------------------------------
-- Table `Ferreteria`.`Categorias`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Ferreteria`.`Categorias` (
  `ID_Categorias` INT NOT NULL,
  `Nombre` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`ID_Categorias`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Ferreteria`.`Productos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Ferreteria`.`Productos` (
  `ID_producto` INT NOT NULL,
  `ID_Categorias` INT NOT NULL,
  `Nombre` VARCHAR(45) NOT NULL,
  `Marca` VARCHAR(45) NOT NULL,
  `Precio` DOUBLE NOT NULL,
  `Descripcion` VARCHAR(45) NULL,
  `Inventario` INT NOT NULL,
  PRIMARY KEY (`ID_producto`, `ID_Categorias`),
  INDEX `fk_Productos_Categorias1_idx` (`ID_Categorias` ASC) VISIBLE,
  CONSTRAINT `fk_Productos_Categorias1`
    FOREIGN KEY (`ID_Categorias`)
    REFERENCES `Ferreteria`.`Categorias` (`ID_Categorias`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Ferreteria`.`Provedor`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Ferreteria`.`Provedor` (
  `ID_Provedor` INT NOT NULL,
  `Nombre` VARCHAR(45) NOT NULL,
  `Telefono` VARCHAR(10) NOT NULL,
  `Productos_ID_producto` INT NOT NULL,
  `Productos_ID_Categorias` INT NOT NULL,
  PRIMARY KEY (`ID_Provedor`),
  INDEX `fk_Provedor_Productos1_idx` (`Productos_ID_producto` ASC, `Productos_ID_Categorias` ASC) VISIBLE,
  CONSTRAINT `fk_Provedor_Productos1`
    FOREIGN KEY (`Productos_ID_producto` , `Productos_ID_Categorias`)
    REFERENCES `Ferreteria`.`Productos` (`ID_producto` , `ID_Categorias`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Ferreteria`.`Venta`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Ferreteria`.`Venta` (
  `ID_Venta` INT NOT NULL,
  `Fecha` DATE NOT NULL,
  `Total` DOUBLE NOT NULL,
  PRIMARY KEY (`ID_Venta`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Ferreteria`.`CantidadXproducto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Ferreteria`.`CantidadXproducto` (
  `ID_producto` INT NOT NULL,
  `ID_Categorias` INT NOT NULL,
  `ID_Venta` INT NOT NULL,
  `Cantidad` INT NOT NULL,
  `Precio` DOUBLE NOT NULL,
  PRIMARY KEY (`ID_producto`, `ID_Categorias`, `ID_Venta`),
  INDEX `fk_Productos_has_Venta_Venta1_idx` (`ID_Venta` ASC) VISIBLE,
  INDEX `fk_Productos_has_Venta_Productos1_idx` (`ID_producto` ASC, `ID_Categorias` ASC) VISIBLE,
  CONSTRAINT `fk_Productos_has_Venta_Productos1`
    FOREIGN KEY (`ID_producto` , `ID_Categorias`)
    REFERENCES `Ferreteria`.`Productos` (`ID_producto` , `ID_Categorias`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Productos_has_Venta_Venta1`
    FOREIGN KEY (`ID_Venta`)
    REFERENCES `Ferreteria`.`Venta` (`ID_Venta`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Ferreteria`.`Sobrepedido`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Ferreteria`.`Sobrepedido` (
  `ID_SobrePedido` INT NOT NULL,
  `Anticipo` DOUBLE NOT NULL,
  `Total` DOUBLE NOT NULL,
  `Fecha_Inicio` DATE NOT NULL,
  `Fecha_Fin` DATE NOT NULL,
  `Direccion` VARCHAR(45) NOT NULL,
  `Nombre` VARCHAR(45) NOT NULL,
  `Apellido_paterno` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`ID_SobrePedido`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Ferreteria`.`CantidadXsobrepedido`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Ferreteria`.`CantidadXsobrepedido` (
  `Sobrepedido_ID_SobrePedido` INT NOT NULL,
  INDEX `fk_CantidadXsobrepedido_Sobrepedido1_idx` (`Sobrepedido_ID_SobrePedido` ASC) VISIBLE,
  CONSTRAINT `fk_CantidadXsobrepedido_Sobrepedido1`
    FOREIGN KEY (`Sobrepedido_ID_SobrePedido`)
    REFERENCES `Ferreteria`.`Sobrepedido` (`ID_SobrePedido`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;


create table Usuarios
(
`ID_USER` INT NOT NULL primary key,
  `USER` char NOT NULL,
  `PASSWORD` Char NOT NULL
);
ALTER TABLE `ferreteria`.`usuarios` 
CHANGE COLUMN `USER` `USER` CHAR(45) NOT NULL ,
CHANGE COLUMN `PASSWORD` `PASSWORD` CHAR(45) NOT NULL ;


insert into usuarios  VALUES (1, 'ADMIN', 'PASSWORD');