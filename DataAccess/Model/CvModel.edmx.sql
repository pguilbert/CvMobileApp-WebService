
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/27/2013 23:49:28
-- Generated from EDMX file: D:\Documents\Travail-Documents\Dev\Projets\CvMobileApp\DataAccess\Model\CvModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [CvDatabase];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CvCompetenceGenerale]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CompetencesGenerales] DROP CONSTRAINT [FK_CvCompetenceGenerale];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Cvs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cvs];
GO
IF OBJECT_ID(N'[dbo].[CompetencesGenerales]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CompetencesGenerales];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Cvs'
CREATE TABLE [dbo].[Cvs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nom] nvarchar(max)  NOT NULL,
    [Prenom] nvarchar(max)  NOT NULL,
    [Titre] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CompetencesGenerales'
CREATE TABLE [dbo].[CompetencesGenerales] (
    [Categorie] nvarchar(max)  NOT NULL,
    [Nom] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL,
    [CvId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Cvs'
ALTER TABLE [dbo].[Cvs]
ADD CONSTRAINT [PK_Cvs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CompetencesGenerales'
ALTER TABLE [dbo].[CompetencesGenerales]
ADD CONSTRAINT [PK_CompetencesGenerales]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CvId] in table 'CompetencesGenerales'
ALTER TABLE [dbo].[CompetencesGenerales]
ADD CONSTRAINT [FK_CvCompetenceGenerale]
    FOREIGN KEY ([CvId])
    REFERENCES [dbo].[Cvs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CvCompetenceGenerale'
CREATE INDEX [IX_FK_CvCompetenceGenerale]
ON [dbo].[CompetencesGenerales]
    ([CvId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------