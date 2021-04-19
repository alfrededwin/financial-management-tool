
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/18/2021 05:45:01
-- Generated from EDMX file: C:\Users\Alfred Edwin\Desktop\EAD_Final\PersonalFinancialTool\PersonalFinancialTool\FinanceToolDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [FinanceToolDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_UserCategory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Categories] DROP CONSTRAINT [FK_UserCategory];
GO
IF OBJECT_ID(N'[dbo].[FK_UserEvent]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Events] DROP CONSTRAINT [FK_UserEvent];
GO
IF OBJECT_ID(N'[dbo].[FK_UserTransaction]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transactions] DROP CONSTRAINT [FK_UserTransaction];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[Categories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Categories];
GO
IF OBJECT_ID(N'[dbo].[Events]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Events];
GO
IF OBJECT_ID(N'[dbo].[Transactions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Transactions];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FullName] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Username] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Categories'
CREATE TABLE [dbo].[Categories] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CategoryName] nvarchar(max)  NOT NULL,
    [CategoryDescription] nvarchar(max)  NOT NULL,
    [CategoryType] nvarchar(max)  NOT NULL,
    [UserId] int  NOT NULL
);
GO

-- Creating table 'Events'
CREATE TABLE [dbo].[Events] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [EventName] nvarchar(max)  NOT NULL,
    [EventDate] nvarchar(max)  NOT NULL,
    [EventStatus] nvarchar(max)  NOT NULL,
    [UserId] int  NOT NULL
);
GO

-- Creating table 'Transactions'
CREATE TABLE [dbo].[Transactions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CategoryType] nvarchar(max)  NOT NULL,
    [Income] nvarchar(max)  NOT NULL,
    [Expense] nvarchar(max)  NOT NULL,
    [TransactionDescription] nvarchar(max)  NOT NULL,
    [TransactionDate] nvarchar(max)  NOT NULL,
    [Amount] nvarchar(max)  NOT NULL,
    [EventName] nvarchar(max)  NOT NULL,
    [UserId] int  NOT NULL
);
GO

-- Creating table 'TransactionCategory'
CREATE TABLE [dbo].[TransactionCategory] (
    [TransactionCategory_Category_Id] int  NOT NULL,
    [TransactionCategory_Transaction_Id] int  NOT NULL
);
GO

-- Creating table 'TransactionEvent'
CREATE TABLE [dbo].[TransactionEvent] (
    [TransactionEvent_Event_Id] int  NOT NULL,
    [TransactionEvent_Transaction_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [PK_Categories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Events'
ALTER TABLE [dbo].[Events]
ADD CONSTRAINT [PK_Events]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [PK_Transactions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [TransactionCategory_Category_Id], [TransactionCategory_Transaction_Id] in table 'TransactionCategory'
ALTER TABLE [dbo].[TransactionCategory]
ADD CONSTRAINT [PK_TransactionCategory]
    PRIMARY KEY CLUSTERED ([TransactionCategory_Category_Id], [TransactionCategory_Transaction_Id] ASC);
GO

-- Creating primary key on [TransactionEvent_Event_Id], [TransactionEvent_Transaction_Id] in table 'TransactionEvent'
ALTER TABLE [dbo].[TransactionEvent]
ADD CONSTRAINT [PK_TransactionEvent]
    PRIMARY KEY CLUSTERED ([TransactionEvent_Event_Id], [TransactionEvent_Transaction_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UserId] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [FK_UserCategory]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserCategory'
CREATE INDEX [IX_FK_UserCategory]
ON [dbo].[Categories]
    ([UserId]);
GO

-- Creating foreign key on [UserId] in table 'Events'
ALTER TABLE [dbo].[Events]
ADD CONSTRAINT [FK_UserEvent]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserEvent'
CREATE INDEX [IX_FK_UserEvent]
ON [dbo].[Events]
    ([UserId]);
GO

-- Creating foreign key on [UserId] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [FK_UserTransaction]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserTransaction'
CREATE INDEX [IX_FK_UserTransaction]
ON [dbo].[Transactions]
    ([UserId]);
GO

-- Creating foreign key on [TransactionCategory_Category_Id] in table 'TransactionCategory'
ALTER TABLE [dbo].[TransactionCategory]
ADD CONSTRAINT [FK_TransactionCategory_Transaction]
    FOREIGN KEY ([TransactionCategory_Category_Id])
    REFERENCES [dbo].[Transactions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [TransactionCategory_Transaction_Id] in table 'TransactionCategory'
ALTER TABLE [dbo].[TransactionCategory]
ADD CONSTRAINT [FK_TransactionCategory_Category]
    FOREIGN KEY ([TransactionCategory_Transaction_Id])
    REFERENCES [dbo].[Categories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TransactionCategory_Category'
CREATE INDEX [IX_FK_TransactionCategory_Category]
ON [dbo].[TransactionCategory]
    ([TransactionCategory_Transaction_Id]);
GO

-- Creating foreign key on [TransactionEvent_Event_Id] in table 'TransactionEvent'
ALTER TABLE [dbo].[TransactionEvent]
ADD CONSTRAINT [FK_TransactionEvent_Transaction]
    FOREIGN KEY ([TransactionEvent_Event_Id])
    REFERENCES [dbo].[Transactions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [TransactionEvent_Transaction_Id] in table 'TransactionEvent'
ALTER TABLE [dbo].[TransactionEvent]
ADD CONSTRAINT [FK_TransactionEvent_Event]
    FOREIGN KEY ([TransactionEvent_Transaction_Id])
    REFERENCES [dbo].[Events]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TransactionEvent_Event'
CREATE INDEX [IX_FK_TransactionEvent_Event]
ON [dbo].[TransactionEvent]
    ([TransactionEvent_Transaction_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------