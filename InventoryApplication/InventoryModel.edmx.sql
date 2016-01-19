
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/25/2015 19:24:05
-- Generated from EDMX file: C:\Users\Enrique Rivera\Documents\Visual Studio 2013\Projects\InventoryApplication\InventoryApplication\InventoryModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [InventoryDatabase];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ArriveDepartures_ProductCode]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ArriveDepartures] DROP CONSTRAINT [FK_ArriveDepartures_ProductCode];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ArriveDepartures]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ArriveDepartures];
GO
IF OBJECT_ID(N'[dbo].[Products]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Products];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ArriveDepartures'
CREATE TABLE [dbo].[ArriveDepartures] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ProductCode] nvarchar(50)  NOT NULL,
    [Quantity] int  NOT NULL,
    [Date] datetime  NOT NULL,
    [Type] nvarchar(7)  NOT NULL
);
GO

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [Code] nvarchar(50)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Quantity] int  NOT NULL,
    [IsDeleted] bit  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Username] nvarchar(50)  NOT NULL,
    [Password] nvarchar(50)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ArriveDepartures'
ALTER TABLE [dbo].[ArriveDepartures]
ADD CONSTRAINT [PK_ArriveDepartures]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Code] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([Code] ASC);
GO

-- Creating primary key on [Username] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Username] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ProductCode] in table 'ArriveDepartures'
ALTER TABLE [dbo].[ArriveDepartures]
ADD CONSTRAINT [FK_ArriveDepartures_ProductCode]
    FOREIGN KEY ([ProductCode])
    REFERENCES [dbo].[Products]
        ([Code])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ArriveDepartures_ProductCode'
CREATE INDEX [IX_FK_ArriveDepartures_ProductCode]
ON [dbo].[ArriveDepartures]
    ([ProductCode]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------