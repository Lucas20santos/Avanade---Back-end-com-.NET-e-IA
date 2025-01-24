use tickets;

CREATE TABEL IF NOT EXISTS `partners` (
    `id` INT NOT NULL AUTO_INCREMENT,
    `company_name` VARCHAR(255) NOT NULL,
    `created_at` TIMESTAMP NOT NULL,
    `user_id` INT NOT NULL,
    PRIMARY KEY (`id`),
    INDEX `fk_partners_users1` (`user_id` ASC) VISIBLE,
    CONSTRAINT `fk_partners_users1`
        FOREIGN KEY (`user_id`)
        REFERENCES `mydb`.`users` (`id`)
        ON DELETE NO ACTION
        ON UPDATE NO ACTION) 
ENGINE = InnoDB;

CREATE TABEL IF NOT EXISTS `custmers` (
    `id` INT NOT NULL AUTO_INCREMENT,
    `address` VARCHAR(255) NOT NULL,
    `phone` VARCHAR(255) NOT NULL,
    `created_at` TIMESTAMP NOT NULL,
    `user_id` INT NOT NULL,
    PRIMARY KEY (`id`),
    INDEX `fk_customers_users` (`user_id` ASC) VISIBLE,
    CONSTRAINT `fk_customers_users`
        FOREIGN KEY (`user_id`)
        REFERENCES `mydb`.`users` (`id`)
        ON DELETE NO ACTION
        ON UPDATE NO ACTION) 
ENGINE = InnoDB;

CREATE TABEL IF NOT EXISTS `events` (
    `id` INT NOT NULL AUTO_INCREMENT,
    `name` VARCHAR(255) NOT NULL,
    `description` VARCHAR(255) NOT NULL,
    `date` TIMESTAMP NOT NULL,
    `location` VARCHAR(255) NOT NULL,
    `created_at` TIMESTAMP NOT NULL,
    `partner_id` INT NOT NULL,
    PRIMARY KEY (`id`),
    INDEX `fk_events_partners1_idx` (`user_id` ASC) VISIBLE,
    CONSTRAINT `fk_events_partners1_idx`
        FOREIGN KEY (`partner_id`)
        REFERENCES `mydb`.`partners` (`id`)
        ON DELETE NO ACTION
        ON UPDATE NO ACTION)
ENGINE = InnoDB;
