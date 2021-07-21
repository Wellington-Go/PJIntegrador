//--MySQL Workbench Forward Engineering
//SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS = 0;
//SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS = 0;
//SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';
//-- -----------------------------------------------------
//    --Schema BancoPI
//-- -----------------------------------------------------
//    -- -----------------------------------------------------
//        --Schema BancoPI
//-- -----------------------------------------------------
//    CREATE SCHEMA IF NOT EXISTS`BancoPI` DEFAULT CHARACTER SET utf8;
//USE`BancoPI`;
//-- -----------------------------------------------------
//    --Table`BancoPI`.`Cliente`
//-- -----------------------------------------------------
//    CREATE TABLE IF NOT EXISTS`BancoPI`.`Cliente`(
//        `id` INT NOT NULL AUTO_INCREMENT,
//        `nome` VARCHAR(45) NOT NULL,
//        `cpf` CHAR(11) NOT NULL,
//        `email` VARCHAR(45) NOT NULL,
//        `telefone` VARCHAR(14) NULL,
//        `ativo` BIT NOT NULL DEFAULT 1,
//        `senha` VARCHAR(45) NOT NULL,
//        PRIMARY KEY(`id`),
//        UNIQUE INDEX`cpf_UNIQUE`(`cpf` ASC),
//        UNIQUE INDEX`email_UNIQUE`(`email` ASC))
//ENGINE = InnoDB;
//-- -----------------------------------------------------
//    --Table`BancoPI`.`Endereco`
//-- -----------------------------------------------------
//    CREATE TABLE IF NOT EXISTS`BancoPI`.`Endereco`(
//        `Cliente_id` INT NOT NULL,
//        `cep` CHAR(8) NOT NULL,
//        `logradouro` VARCHAR(45) NOT NULL,
//        `numero` INT NOT NULL,
//        `complemento` VARCHAR(45) NOT NULL,
//        `tipo` VARCHAR(45) NOT NULL,
//        `cidade` VARCHAR(45) NOT NULL,
//        `bairro` VARCHAR(45) NOT NULL,
//        `uf` CHAR(2) NOT NULL,
//        INDEX`fk_Endereco_Cliente_idx`(`Cliente_id` ASC),
//        CONSTRAINT`fk_Endereco_Cliente`
//    FOREIGN KEY(`Cliente_id`)
//    REFERENCES`BancoPI`.`Cliente`(`id`)
//    ON DELETE NO ACTION
//    ON UPDATE NO ACTION)
//ENGINE = InnoDB;
//-- -----------------------------------------------------
//    --Table`BancoPI`.`Servico`
//-- -----------------------------------------------------
//    CREATE TABLE IF NOT EXISTS`BancoPI`.`Servico`(
//        `id` INT NOT NULL AUTO_INCREMENT,
//        `descricao` VARCHAR(100) NOT NULL,
//        `data` DATETIME NOT NULL DEFAULT CURRENT_TIMEstamp,
//        `Cliente_id` INT NOT NULL,
//        `valor` VARCHAR(50) NULL,
//        PRIMARY KEY(`id`),
//        INDEX`fk_Servico_Cliente1_idx`(`Cliente_id` ASC),
//        CONSTRAINT`fk_Servico_Cliente1`
//    FOREIGN KEY(`Cliente_id`)
//    REFERENCES`BancoPI`.`Cliente`(`id`)
//    ON DELETE NO ACTION
//    ON UPDATE NO ACTION)
//ENGINE = InnoDB;
//-- -----------------------------------------------------
//    --Table`BancoPI`.`Funcionario`
//-- -----------------------------------------------------
//    CREATE TABLE IF NOT EXISTS`BancoPI`.`Funcionario`(
//        `id` INT NOT NULL AUTO_INCREMENT,
//        `nome` VARCHAR(45) NOT NULL,
//        `email` VARCHAR(45) NOT NULL,
//        `telefone` VARCHAR(45) NOT NULL,
//        `cpf` CHAR(11) NOT NULL,
//        `senha` VARCHAR(45) NOT NULL,
//        `ativo` BIT NOT NULL DEFAULT 1,
//        `Servico_id` INT,
//        PRIMARY KEY(`id`),
//        UNIQUE INDEX`email_UNIQUE`(`email` ASC),
//        UNIQUE INDEX`cpf_UNIQUE`(`cpf` ASC),
//        INDEX`fk_Funcionario_Servico1_idx`(`Servico_id` ASC),
//        CONSTRAINT`fk_Funcionario_Servico1`
//    FOREIGN KEY(`Servico_id`)
//    REFERENCES`BancoPI`.`Servico`(`id`)
//    ON DELETE NO ACTION
//    ON UPDATE NO ACTION)
//ENGINE = InnoDB;
//SET SQL_MODE =@OLD_SQL_MODE;
//SET FOREIGN_KEY_CHECKS =@OLD_FOREIGN_KEY_CHECKS;
//SET UNIQUE_CHECKS =@OLD_UNIQUE_CHECKS;
//# sourceMappingURL=Script.js.map