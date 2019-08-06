CREATE TABLE IF NOT EXISTS `__EFMigrationsHistory` (
    `MigrationId` varchar(95) NOT NULL,
    `ProductVersion` varchar(32) NOT NULL,
    CONSTRAINT `PK___EFMigrationsHistory` PRIMARY KEY (`MigrationId`)
);

CREATE TABLE `Usuarios` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Nome` longtext NULL,
    `SobreNome` longtext NULL,
    `Email` longtext NULL,
    `Senha` longtext NULL,
    `DataNascimento` datetime(6) NOT NULL,
    `Sexo` int NOT NULL,
    `UrlFoto` longtext NULL,
    CONSTRAINT `PK_Usuarios` PRIMARY KEY (`Id`)
);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20190804200540_Inicial', '2.2.6-servicing-10079');

ALTER TABLE `Usuarios` MODIFY COLUMN `UrlFoto` varchar(400) NOT NULL;

ALTER TABLE `Usuarios` MODIFY COLUMN `SobreNome` varchar(400) NOT NULL;

ALTER TABLE `Usuarios` MODIFY COLUMN `Senha` varchar(400) NOT NULL;

ALTER TABLE `Usuarios` MODIFY COLUMN `Nome` varchar(400) NOT NULL;

ALTER TABLE `Usuarios` MODIFY COLUMN `Email` varchar(400) NOT NULL;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20190805001735_AdicionadoUsuarioConfiguration', '2.2.6-servicing-10079');

CREATE TABLE `Postagems` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `DataPublicacao` datetime(6) NOT NULL,
    `Texto` longtext NULL,
    CONSTRAINT `PK_Postagems` PRIMARY KEY (`Id`)
);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20190806023313_AdicionadoClassePostagem', '2.2.6-servicing-10079');

CREATE TABLE `StatusRelacionamento` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Descricao` longtext NULL,
    CONSTRAINT `PK_StatusRelacionamento` PRIMARY KEY (`Id`)
);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20190806024512_AdicionandoStatusRelacionamento', '2.2.6-servicing-10079');

