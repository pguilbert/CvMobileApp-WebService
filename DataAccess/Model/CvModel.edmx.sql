
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/28/2013 13:41:20
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
IF OBJECT_ID(N'[dbo].[FK_CvFormation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Formations] DROP CONSTRAINT [FK_CvFormation];
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
IF OBJECT_ID(N'[dbo].[Formations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Formations];
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
    [Id] int IDENTITY(1,1) NOT NULL,
    [CvId] int  NOT NULL
);
GO

-- Creating table 'Formations'
CREATE TABLE [dbo].[Formations] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Periode] nvarchar(max)  NOT NULL,
    [Libelle] nvarchar(max)  NOT NULL,
    [CvId] int  NOT NULL
);
GO

-- Creating table 'Missions'
CREATE TABLE [dbo].[Missions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Poste] nvarchar(max)  NOT NULL,
    [LibelleMission] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [DateDebut] datetime  NOT NULL,
    [DateFin] datetime  NOT NULL,
    [CvId] int  NOT NULL,
    [ClientId] int  NOT NULL,
    [SSIIId] int  NOT NULL
);
GO

-- Creating table 'Clients'
CREATE TABLE [dbo].[Clients] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nom] nvarchar(max)  NOT NULL,
    [SiteWeb] nvarchar(max)  NOT NULL,
    [Ville] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'SSIIs'
CREATE TABLE [dbo].[SSIIs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nom] nvarchar(max)  NOT NULL,
    [Adresse] nvarchar(max)  NOT NULL,
    [CodePostal] nvarchar(max)  NOT NULL,
    [Ville] nvarchar(max)  NOT NULL,
    [SiteWeb] nvarchar(max)  NOT NULL
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

-- Creating primary key on [Id] in table 'Formations'
ALTER TABLE [dbo].[Formations]
ADD CONSTRAINT [PK_Formations]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Missions'
ALTER TABLE [dbo].[Missions]
ADD CONSTRAINT [PK_Missions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Clients'
ALTER TABLE [dbo].[Clients]
ADD CONSTRAINT [PK_Clients]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SSIIs'
ALTER TABLE [dbo].[SSIIs]
ADD CONSTRAINT [PK_SSIIs]
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

-- Creating foreign key on [CvId] in table 'Formations'
ALTER TABLE [dbo].[Formations]
ADD CONSTRAINT [FK_CvFormation]
    FOREIGN KEY ([CvId])
    REFERENCES [dbo].[Cvs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CvFormation'
CREATE INDEX [IX_FK_CvFormation]
ON [dbo].[Formations]
    ([CvId]);
GO

-- Creating foreign key on [CvId] in table 'Missions'
ALTER TABLE [dbo].[Missions]
ADD CONSTRAINT [FK_CvMission]
    FOREIGN KEY ([CvId])
    REFERENCES [dbo].[Cvs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CvMission'
CREATE INDEX [IX_FK_CvMission]
ON [dbo].[Missions]
    ([CvId]);
GO

-- Creating foreign key on [ClientId] in table 'Missions'
ALTER TABLE [dbo].[Missions]
ADD CONSTRAINT [FK_ClientMission]
    FOREIGN KEY ([ClientId])
    REFERENCES [dbo].[Clients]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientMission'
CREATE INDEX [IX_FK_ClientMission]
ON [dbo].[Missions]
    ([ClientId]);
GO

-- Creating foreign key on [SSIIId] in table 'Missions'
ALTER TABLE [dbo].[Missions]
ADD CONSTRAINT [FK_SSIIMission]
    FOREIGN KEY ([SSIIId])
    REFERENCES [dbo].[SSIIs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SSIIMission'
CREATE INDEX [IX_FK_SSIIMission]
ON [dbo].[Missions]
    ([SSIIId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------