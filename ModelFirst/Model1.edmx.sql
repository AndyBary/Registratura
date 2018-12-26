
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/02/2018 12:15:17
-- Generated from EDMX file: F:\Универ\Фомина\Лаба 3\Поликлиника лаба 3\ModelFirst\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Поликлиника];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UchastokSet'
CREATE TABLE [dbo].[UchastokSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Uchastok_number] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PacientSet'
CREATE TABLE [dbo].[PacientSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Pacient_FIO] nvarchar(max)  NOT NULL,
    [Polis_number] nvarchar(max)  NOT NULL,
    [Adres] nvarchar(max)  NOT NULL,
    [Birth_day] nvarchar(max)  NOT NULL,
    [Uchastok_number] nvarchar(max)  NOT NULL,
    [Uchastok_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'UchastokSet'
ALTER TABLE [dbo].[UchastokSet]
ADD CONSTRAINT [PK_UchastokSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PacientSet'
ALTER TABLE [dbo].[PacientSet]
ADD CONSTRAINT [PK_PacientSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Uchastok_Id] in table 'PacientSet'
ALTER TABLE [dbo].[PacientSet]
ADD CONSTRAINT [FK_UchastokPacient]
    FOREIGN KEY ([Uchastok_Id])
    REFERENCES [dbo].[UchastokSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UchastokPacient'
CREATE INDEX [IX_FK_UchastokPacient]
ON [dbo].[PacientSet]
    ([Uchastok_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------