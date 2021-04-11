-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema db_pdvuth2021
-- -----------------------------------------------------
-- Database for PDV UTH 2021 project
-- 
DROP SCHEMA IF EXISTS `db_pdvuth2021` ;

-- -----------------------------------------------------
-- Schema db_pdvuth2021
--
-- Database for PDV UTH 2021 project
-- 
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `db_pdvuth2021` DEFAULT CHARACTER SET utf8 COLLATE utf8_bin ;
USE `db_pdvuth2021` ;

-- -----------------------------------------------------
-- Table `db_pdvuth2021`.`users`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `db_pdvuth2021`.`users` ;

CREATE TABLE IF NOT EXISTS `db_pdvuth2021`.`users` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NOT NULL,
  `lastname` VARCHAR(45) NOT NULL,
  `mothers_lastname` VARCHAR(45) NOT NULL,
  `email` VARCHAR(45) NOT NULL,
  `password` VARCHAR(45) NOT NULL,
  `type` ENUM('ADMIN', 'CASHIER', 'SUPERUSER') NOT NULL,
  `street` VARCHAR(45) NULL,
  `house_number` VARCHAR(45) NULL,
  `residential` VARCHAR(45) NULL,
  `postal_code` VARCHAR(5) NULL,
  `region_state` VARCHAR(45) NOT NULL DEFAULT 'Sonora',
  `CURP` VARCHAR(18) NULL,
  `RFC` VARCHAR(15) NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `email_UNIQUE` (`email` ASC) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_pdvuth2021`.`users_movs_logs`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `db_pdvuth2021`.`users_movs_logs` ;

CREATE TABLE IF NOT EXISTS `db_pdvuth2021`.`users_movs_logs` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `date` DATETIME NOT NULL,
  `type` ENUM('CAMBIO_DE_PRECIOS', 'RETIRO', 'CORTE_DE_CAJA') NOT NULL,
  `details` VARCHAR(45) NOT NULL,
  `user_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_user_id_idx` (`user_id` ASC) ,
  CONSTRAINT `fk_user_id`
    FOREIGN KEY (`user_id`)
    REFERENCES `db_pdvuth2021`.`users` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_pdvuth2021`.`brands`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `db_pdvuth2021`.`brands` ;

CREATE TABLE IF NOT EXISTS `db_pdvuth2021`.`brands` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NOT NULL,
  `description` VARCHAR(200) NULL,
  `logo` VARCHAR(200) NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_pdvuth2021`.`categories`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `db_pdvuth2021`.`categories` ;

CREATE TABLE IF NOT EXISTS `db_pdvuth2021`.`categories` (
  `id` INT NOT NULL,
  `name` VARCHAR(45) NULL,
  `description` VARCHAR(200) NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_pdvuth2021`.`subcategories`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `db_pdvuth2021`.`subcategories` ;

CREATE TABLE IF NOT EXISTS `db_pdvuth2021`.`subcategories` (
  `id` INT NOT NULL,
  `name` VARCHAR(45) NOT NULL,
  `description` VARCHAR(200) NULL,
  `category_id` INT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_category_id_idx` (`category_id` ASC) ,
  CONSTRAINT `fk_category_id`
    FOREIGN KEY (`category_id`)
    REFERENCES `db_pdvuth2021`.`categories` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_pdvuth2021`.`products`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `db_pdvuth2021`.`products` ;

CREATE TABLE IF NOT EXISTS `db_pdvuth2021`.`products` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NOT NULL,
  `description` VARCHAR(200) NOT NULL,
  `price` FLOAT NOT NULL,
  `bar_code` VARCHAR(15) NOT NULL,
  `brand_id` INT NOT NULL,
  `subcategory_id` INT NOT NULL,
  `image` VARCHAR(200) NULL,
  `measure_unit` ENUM('UNIDAD', 'KILO', 'LITRO', 'CAJA') NOT NULL,
  `sku` VARCHAR(100) NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `bar_code_UNIQUE` (`bar_code` ASC) ,
  UNIQUE INDEX `sku_UNIQUE` (`sku` ASC) ,
  INDEX `fk_brand_id_idx` (`brand_id` ASC) ,
  INDEX `fk_subcategory_id_idx` (`subcategory_id` ASC) ,
  CONSTRAINT `fk_brand_id`
    FOREIGN KEY (`brand_id`)
    REFERENCES `db_pdvuth2021`.`brands` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_subcategory_id`
    FOREIGN KEY (`subcategory_id`)
    REFERENCES `db_pdvuth2021`.`subcategories` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_pdvuth2021`.`sales`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `db_pdvuth2021`.`sales` ;

CREATE TABLE IF NOT EXISTS `db_pdvuth2021`.`sales` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `date` DATETIME NULL,
  `cash_register_id` INT NULL,
  `user_id` INT NULL,
  `total_sale` FLOAT NULL,
  `articles_number` INT NULL,
  `ticket_number` INT ZEROFILL UNSIGNED NULL ,
  `cancelled` TINYINT NOT NULL DEFAULT 0,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `ticket_number_UNIQUE` (`ticket_number` ASC) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_pdvuth2021`.`sales_details`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `db_pdvuth2021`.`sales_details` ;

CREATE TABLE IF NOT EXISTS `db_pdvuth2021`.`sales_details` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `product_id` INT NOT NULL,
  `quantity` INT NOT NULL DEFAULT 1,
  `special_price` FLOAT NULL,
  `sale_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_product_id_idx` (`product_id` ASC) ,
  INDEX `fk_sale_id_idx` (`sale_id` ASC) ,
  CONSTRAINT `fk_product_id`
    FOREIGN KEY (`product_id`)
    REFERENCES `db_pdvuth2021`.`products` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_sale_id`
    FOREIGN KEY (`sale_id`)
    REFERENCES `db_pdvuth2021`.`sales` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_pdvuth2021`.`cash_registers`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `db_pdvuth2021`.`cash_registers` ;

CREATE TABLE IF NOT EXISTS `db_pdvuth2021`.`cash_registers` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NOT NULL,
  `description` VARCHAR(200) NULL,
  `mac_address` VARCHAR(20) NOT NULL,
  `active` TINYINT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `mac_address_UNIQUE` (`mac_address` ASC) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_pdvuth2021`.`inventory_movements`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `db_pdvuth2021`.`inventory_movements` ;

CREATE TABLE IF NOT EXISTS `db_pdvuth2021`.`inventory_movements` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `type` ENUM('VENTA', 'COMPRA', 'DEVOL_A_PROV', 'DEVOL_DE_CLI', 'MERMA') NOT NULL DEFAULT 'VENTA',
  `date` DATETIME NOT NULL,
  `product_id` INT NOT NULL,
  `quantity` FLOAT NOT NULL,
  `details` VARCHAR(200) NULL,
  `price` FLOAT NOT NULL,
  `cancelled` TINYINT NOT NULL DEFAULT 0,
  PRIMARY KEY (`id`),
  INDEX `fk_product_id_idx` (`product_id` ASC) ,
  CONSTRAINT `fk_product_id`
    FOREIGN KEY (`product_id`)
    REFERENCES `db_pdvuth2021`.`products` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_pdvuth2021`.`cash_withdrawals`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `db_pdvuth2021`.`cash_withdrawals` ;

CREATE TABLE IF NOT EXISTS `db_pdvuth2021`.`cash_withdrawals` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `type` ENUM('EMERGENCIA', 'SUELDOS', 'PAGO_A_PROV', 'OTRO') NOT NULL,
  `cash` FLOAT NOT NULL,
  `details` VARCHAR(200) NOT NULL,
  `date` DATETIME NOT NULL,
  `cash_register_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_cash_register_id_idx` (`cash_register_id` ASC) ,
  CONSTRAINT `fk_cash_register_id`
    FOREIGN KEY (`cash_register_id`)
    REFERENCES `db_pdvuth2021`.`cash_registers` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_pdvuth2021`.`cash_register_movements`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `db_pdvuth2021`.`cash_register_movements` ;

CREATE TABLE IF NOT EXISTS `db_pdvuth2021`.`cash_register_movements` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `cash_register_id` INT NOT NULL,
  `admin_id` INT NOT NULL,
  `date` DATETIME NOT NULL,
  `base_cash` FLOAT NULL,
  `cashier_id` INT NOT NULL,
  `cut_results` FLOAT NULL,
  `type` ENUM('OPEN', 'CLOSE') NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_cash_register_id_idx` (`cash_register_id` ASC) ,
  INDEX `fk_admin_id_idx` (`admin_id` ASC) ,
  INDEX `fk_cashier_id_idx` (`cashier_id` ASC) ,
  CONSTRAINT `fk_cash_register_id`
    FOREIGN KEY (`cash_register_id`)
    REFERENCES `db_pdvuth2021`.`cash_registers` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_admin_id`
    FOREIGN KEY (`admin_id`)
    REFERENCES `db_pdvuth2021`.`users` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_cashier_id`
    FOREIGN KEY (`cashier_id`)
    REFERENCES `db_pdvuth2021`.`users` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_pdvuth2021`.`inventory_existence`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `db_pdvuth2021`.`inventory_existence` ;

CREATE TABLE IF NOT EXISTS `db_pdvuth2021`.`inventory_existence` (
  `product_id` INT NOT NULL,
  `existence` FLOAT NOT NULL,
  `updated_at` DATETIME NOT NULL,
  `last_inventory_movement_id` INT NOT NULL,
  UNIQUE INDEX `_UNIQUE` (`product_id` ASC) ,
  INDEX `fk__last_inventory_movement_id_idx` (`last_inventory_movement_id` ASC) ,
  CONSTRAINT `fk_product_id`
    FOREIGN KEY (`product_id`)
    REFERENCES `db_pdvuth2021`.`products` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk__last_inventory_movement_id`
    FOREIGN KEY (`last_inventory_movement_id`)
    REFERENCES `db_pdvuth2021`.`inventory_movements` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
