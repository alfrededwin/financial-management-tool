
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/15/2021 12:41:31
-- Generated from EDMX file: C:\Users\Alfred Edwin\Desktop\EAD_CW02\financial-management-tool\PersonalFinancialTool\PersonalFinancialTool\PersonalFinancialToolDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [PersonalFinancialToolDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Categories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Categories];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Categories'
CREATE TABLE [dbo].[Categories] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CategoryName] nvarchar(max)  NOT NULL,
    [CategoryDescription] nvarchar(max)  NOT NULL,
    [CategoryType] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FullName] nvarchar(max)  NOT NULL,
    [Username] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [PK_Categories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------