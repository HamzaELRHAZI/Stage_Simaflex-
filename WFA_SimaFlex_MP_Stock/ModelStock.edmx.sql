
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/11/2016 10:50:12
-- Generated from EDMX file: D:\Users\Hamza EL RHAZI\documents\visual studio 2015\Projects\WFA_SimaFlex_MP_Stock\WFA_SimaFlex_MP_Stock\ModelStock.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SimaFlex_MP_Stock_DB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CatégoriesSous_Catégories]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Sous_CatégoriesSet] DROP CONSTRAINT [FK_CatégoriesSous_Catégories];
GO
IF OBJECT_ID(N'[dbo].[FK_CatégoriesArticles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ArticlesSet] DROP CONSTRAINT [FK_CatégoriesArticles];
GO
IF OBJECT_ID(N'[dbo].[FK_FournisseursCommandes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CommandesSet] DROP CONSTRAINT [FK_FournisseursCommandes];
GO
IF OBJECT_ID(N'[dbo].[FK_ArticlesCommandes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ArticlesSet] DROP CONSTRAINT [FK_ArticlesCommandes];
GO
IF OBJECT_ID(N'[dbo].[FK_CatégoriesFournisseurs]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FournisseursSet] DROP CONSTRAINT [FK_CatégoriesFournisseurs];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ArticlesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ArticlesSet];
GO
IF OBJECT_ID(N'[dbo].[CatégoriesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CatégoriesSet];
GO
IF OBJECT_ID(N'[dbo].[Sous_CatégoriesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sous_CatégoriesSet];
GO
IF OBJECT_ID(N'[dbo].[CommandesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CommandesSet];
GO
IF OBJECT_ID(N'[dbo].[FournisseursSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FournisseursSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ArticlesSet'
CREATE TABLE [dbo].[ArticlesSet] (
    [IdArticles] int IDENTITY(1,1) NOT NULL,
    [Référence] nvarchar(max)  NOT NULL,
    [Couleur] nvarchar(max)  NOT NULL,
    [Catégories_IdCatégories] int  NOT NULL,
    [Commandes_IdCommande] int  NOT NULL
);
GO

-- Creating table 'CatégoriesSet'
CREATE TABLE [dbo].[CatégoriesSet] (
    [IdCatégories] int IDENTITY(1,1) NOT NULL,
    [Type_Catégorie] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Sous_CatégoriesSet'
CREATE TABLE [dbo].[Sous_CatégoriesSet] (
    [IdSous_Catégories] int IDENTITY(1,1) NOT NULL,
    [Type_Sous_Catégorie] nvarchar(max)  NOT NULL,
    [Catégories_IdCatégories] int  NOT NULL
);
GO

-- Creating table 'CommandesSet'
CREATE TABLE [dbo].[CommandesSet] (
    [IdCommande] int IDENTITY(1,1) NOT NULL,
    [Date_Lancement] datetime  NOT NULL,
    [Date_PrévuDeLivraison] datetime  NOT NULL,
    [Quantité_Commandée] int  NOT NULL,
    [Fournisseurs_IdFournisseurs] int  NOT NULL
);
GO

-- Creating table 'FournisseursSet'
CREATE TABLE [dbo].[FournisseursSet] (
    [IdFournisseurs] int IDENTITY(1,1) NOT NULL,
    [Nom] nvarchar(max)  NOT NULL,
    [Adresse] nvarchar(max)  NOT NULL,
    [Tél_Pérsonnel] nvarchar(max)  NOT NULL,
    [Tél_Travail] nvarchar(max)  NOT NULL,
    [Tél_fixe] nvarchar(max)  NOT NULL,
    [Catégories_IdCatégories] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdArticles] in table 'ArticlesSet'
ALTER TABLE [dbo].[ArticlesSet]
ADD CONSTRAINT [PK_ArticlesSet]
    PRIMARY KEY CLUSTERED ([IdArticles] ASC);
GO

-- Creating primary key on [IdCatégories] in table 'CatégoriesSet'
ALTER TABLE [dbo].[CatégoriesSet]
ADD CONSTRAINT [PK_CatégoriesSet]
    PRIMARY KEY CLUSTERED ([IdCatégories] ASC);
GO

-- Creating primary key on [IdSous_Catégories] in table 'Sous_CatégoriesSet'
ALTER TABLE [dbo].[Sous_CatégoriesSet]
ADD CONSTRAINT [PK_Sous_CatégoriesSet]
    PRIMARY KEY CLUSTERED ([IdSous_Catégories] ASC);
GO

-- Creating primary key on [IdCommande] in table 'CommandesSet'
ALTER TABLE [dbo].[CommandesSet]
ADD CONSTRAINT [PK_CommandesSet]
    PRIMARY KEY CLUSTERED ([IdCommande] ASC);
GO

-- Creating primary key on [IdFournisseurs] in table 'FournisseursSet'
ALTER TABLE [dbo].[FournisseursSet]
ADD CONSTRAINT [PK_FournisseursSet]
    PRIMARY KEY CLUSTERED ([IdFournisseurs] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Catégories_IdCatégories] in table 'Sous_CatégoriesSet'
ALTER TABLE [dbo].[Sous_CatégoriesSet]
ADD CONSTRAINT [FK_CatégoriesSous_Catégories]
    FOREIGN KEY ([Catégories_IdCatégories])
    REFERENCES [dbo].[CatégoriesSet]
        ([IdCatégories])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CatégoriesSous_Catégories'
CREATE INDEX [IX_FK_CatégoriesSous_Catégories]
ON [dbo].[Sous_CatégoriesSet]
    ([Catégories_IdCatégories]);
GO

-- Creating foreign key on [Catégories_IdCatégories] in table 'ArticlesSet'
ALTER TABLE [dbo].[ArticlesSet]
ADD CONSTRAINT [FK_CatégoriesArticles]
    FOREIGN KEY ([Catégories_IdCatégories])
    REFERENCES [dbo].[CatégoriesSet]
        ([IdCatégories])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CatégoriesArticles'
CREATE INDEX [IX_FK_CatégoriesArticles]
ON [dbo].[ArticlesSet]
    ([Catégories_IdCatégories]);
GO

-- Creating foreign key on [Fournisseurs_IdFournisseurs] in table 'CommandesSet'
ALTER TABLE [dbo].[CommandesSet]
ADD CONSTRAINT [FK_FournisseursCommandes]
    FOREIGN KEY ([Fournisseurs_IdFournisseurs])
    REFERENCES [dbo].[FournisseursSet]
        ([IdFournisseurs])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FournisseursCommandes'
CREATE INDEX [IX_FK_FournisseursCommandes]
ON [dbo].[CommandesSet]
    ([Fournisseurs_IdFournisseurs]);
GO

-- Creating foreign key on [Commandes_IdCommande] in table 'ArticlesSet'
ALTER TABLE [dbo].[ArticlesSet]
ADD CONSTRAINT [FK_ArticlesCommandes]
    FOREIGN KEY ([Commandes_IdCommande])
    REFERENCES [dbo].[CommandesSet]
        ([IdCommande])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ArticlesCommandes'
CREATE INDEX [IX_FK_ArticlesCommandes]
ON [dbo].[ArticlesSet]
    ([Commandes_IdCommande]);
GO

-- Creating foreign key on [Catégories_IdCatégories] in table 'FournisseursSet'
ALTER TABLE [dbo].[FournisseursSet]
ADD CONSTRAINT [FK_CatégoriesFournisseurs]
    FOREIGN KEY ([Catégories_IdCatégories])
    REFERENCES [dbo].[CatégoriesSet]
        ([IdCatégories])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CatégoriesFournisseurs'
CREATE INDEX [IX_FK_CatégoriesFournisseurs]
ON [dbo].[FournisseursSet]
    ([Catégories_IdCatégories]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------