-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema ferreteria
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema ferreteria
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `ferreteria` DEFAULT CHARACTER SET utf8 ;
USE `ferreteria` ;

-- -----------------------------------------------------
-- Table `ferreteria`.`categorias`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ferreteria`.`categorias` (
  `ID_Categorias` INT NOT NULL AUTO_INCREMENT,
  `Nombre` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`ID_Categorias`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `ferreteria`.`productos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ferreteria`.`productos` (
  `ID_producto` INT NOT NULL AUTO_INCREMENT,
  `ID_Categorias` INT NOT NULL,
  `Nombre` VARCHAR(45) NOT NULL,
  `Marca` VARCHAR(45) NOT NULL,
  `Precio` DOUBLE NOT NULL,
  `Descripcion` VARCHAR(45) NULL DEFAULT NULL,
  `InVentario` INT NOT NULL,
  PRIMARY KEY (`ID_producto`, `ID_Categorias`),
  INDEX `fk_Productos_Categorias1_idx` (`ID_Categorias` ASC) VISIBLE,
  CONSTRAINT `fk_Productos_Categorias1`
    FOREIGN KEY (`ID_Categorias`)
    REFERENCES `ferreteria`.`categorias` (`ID_Categorias`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `ferreteria`.`venta`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ferreteria`.`venta` (
  `ID_Venta` INT NOT NULL AUTO_INCREMENT,
  `Fecha` DATE NOT NULL,
  `Total` DOUBLE NOT NULL,
  PRIMARY KEY (`ID_Venta`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `ferreteria`.`cantidadxproducto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ferreteria`.`cantidadxproducto` (
  `ID_producto` INT NOT NULL,
  `ID_Categorias` INT NOT NULL,
  `ID_Venta` INT NOT NULL,
  `Cantidad` INT NOT NULL,
  `Precio` DOUBLE NOT NULL,
  PRIMARY KEY (`ID_producto`, `ID_Categorias`, `ID_Venta`),
  INDEX `fk_Productos_has_Venta_Venta_idx` (`ID_Venta` ASC) VISIBLE,
  INDEX `fk_Productos_has_Venta_Productos_idx` (`ID_producto` ASC, `ID_Categorias` ASC) VISIBLE,
  CONSTRAINT `fk_Productos_has_Venta_Productos`
    FOREIGN KEY (`ID_producto` , `ID_Categorias`)
    REFERENCES `ferreteria`.`productos` (`ID_producto` , `ID_Categorias`),
  CONSTRAINT `fk_Productos_has_Venta_Venta`
    FOREIGN KEY (`ID_Venta`)
    REFERENCES `ferreteria`.`venta` (`ID_Venta`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `ferreteria`.`sobrepedido`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ferreteria`.`sobrepedido` (
  `ID_SobrePedido` INT NOT NULL AUTO_INCREMENT,
  `Anticipo` DOUBLE NOT NULL,
  `Total` DOUBLE NOT NULL,
  `Fecha_Inicio` DATE NOT NULL,
  `Fecha_Fin` DATE NOT NULL,
  `Direccion` VARCHAR(45) NOT NULL,
  `Nombre` VARCHAR(45) NOT NULL,
  `Apellido_paterno` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`ID_SobrePedido`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `ferreteria`.`cantidadxsobrepedido`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ferreteria`.`cantidadxsobrepedido` (
  `Sobrepedido_ID_SobrePedido` INT NOT NULL,
  INDEX `fk_CantidadXsobrepedido_Sobrepedido_idx` (`Sobrepedido_ID_SobrePedido` ASC) VISIBLE,
  CONSTRAINT `fk_CantidadXsobrepedido_Sobrepedido`
    FOREIGN KEY (`Sobrepedido_ID_SobrePedido`)
    REFERENCES `ferreteria`.`sobrepedido` (`ID_SobrePedido`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `ferreteria`.`provedor`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ferreteria`.`provedor` (
  `ID_Provedor` INT NOT NULL AUTO_INCREMENT,
  `Nombre` VARCHAR(45) NOT NULL,
  `Telefono` VARCHAR(10) NOT NULL,
  `Productos_ID_producto` INT NOT NULL,
  `Productos_ID_Categorias` INT NOT NULL,
  PRIMARY KEY (`ID_Provedor`),
  INDEX `fk_Provedor_Productos_idx` (`Productos_ID_producto` ASC, `Productos_ID_Categorias` ASC) VISIBLE,
  CONSTRAINT `fk_Provedor_Productos`
    FOREIGN KEY (`Productos_ID_producto` , `Productos_ID_Categorias`)
    REFERENCES `ferreteria`.`productos` (`ID_producto` , `ID_Categorias`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `ferreteria`.`usuarios`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ferreteria`.`usuarios` (
  `ID_USER` INT NOT NULL AUTO_INCREMENT,
  `USER` CHAR(45) NOT NULL,
  `PASSWORD` CHAR(45) NOT NULL,
  PRIMARY KEY (`ID_USER`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

insert into categorias(Nombre) values('Herramientas');
insert into productos(ID_Categorias,Nombre,Marca,Precio,Descripcion,InVentario) values (1,'Martillo','LionTools',54,'Aguanta un rato',5);
insert into usuarios values (1,'ADMIN','PASSWORD')
