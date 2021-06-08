
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/05/2021 10:01:17
-- Generated from EDMX file: E:\C#_projects\FinancialManagementApplication\FinancialManagementApplication\FMSystem.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [FinancialManagementDatabase];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_UserInfoContact1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Contacts] DROP CONSTRAINT [FK_UserInfoContact1];
GO
IF OBJECT_ID(N'[dbo].[FK_UserInfoIncome1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Incomes] DROP CONSTRAINT [FK_UserInfoIncome1];
GO
IF OBJECT_ID(N'[dbo].[FK_UserInfoExpense]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Expenses] DROP CONSTRAINT [FK_UserInfoExpense];
GO
IF OBJECT_ID(N'[dbo].[FK_ContactIncome]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Incomes] DROP CONSTRAINT [FK_ContactIncome];
GO
IF OBJECT_ID(N'[dbo].[FK_ContactExpense]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Expenses] DROP CONSTRAINT [FK_ContactExpense];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Categories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Categories];
GO
IF OBJECT_ID(N'[dbo].[UserInfoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserInfoes];
GO
IF OBJECT_ID(N'[dbo].[Contacts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Contacts];
GO
IF OBJECT_ID(N'[dbo].[Incomes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Incomes];
GO
IF OBJECT_ID(N'[dbo].[Expenses]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Expenses];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Categories'
CREATE TABLE [dbo].[Categories] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'UserInfoes'
CREATE TABLE [dbo].[UserInfoes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Contacts'
CREATE TABLE [dbo].[Contacts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [PhoneNumber] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [UserInfoId] int  NOT NULL
);
GO

-- Creating table 'Incomes'
CREATE TABLE [dbo].[Incomes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [Category] nvarchar(max)  NOT NULL,
    [Amount] decimal(18,2)  NOT NULL,
    [Date] datetime  NOT NULL,
    [UserInfoId] int  NOT NULL,
    [ContactId] int  NOT NULL
);
GO

-- Creating table 'Expenses'
CREATE TABLE [dbo].[Expenses] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [Category] nvarchar(max)  NOT NULL,
    [Amount] decimal(18,2)  NOT NULL,
    [Date] datetime  NOT NULL,
    [UserInfoId] int  NOT NULL,
    [ContactId] int  NOT NULL
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

-- Creating primary key on [Id] in table 'UserInfoes'
ALTER TABLE [dbo].[UserInfoes]
ADD CONSTRAINT [PK_UserInfoes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Contacts'
ALTER TABLE [dbo].[Contacts]
ADD CONSTRAINT [PK_Contacts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Incomes'
ALTER TABLE [dbo].[Incomes]
ADD CONSTRAINT [PK_Incomes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Expenses'
ALTER TABLE [dbo].[Expenses]
ADD CONSTRAINT [PK_Expenses]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UserInfoId] in table 'Contacts'
ALTER TABLE [dbo].[Contacts]
ADD CONSTRAINT [FK_UserInfoContact1]
    FOREIGN KEY ([UserInfoId])
    REFERENCES [dbo].[UserInfoes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserInfoContact1'
CREATE INDEX [IX_FK_UserInfoContact1]
ON [dbo].[Contacts]
    ([UserInfoId]);
GO

-- Creating foreign key on [UserInfoId] in table 'Incomes'
ALTER TABLE [dbo].[Incomes]
ADD CONSTRAINT [FK_UserInfoIncome1]
    FOREIGN KEY ([UserInfoId])
    REFERENCES [dbo].[UserInfoes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserInfoIncome1'
CREATE INDEX [IX_FK_UserInfoIncome1]
ON [dbo].[Incomes]
    ([UserInfoId]);
GO

-- Creating foreign key on [UserInfoId] in table 'Expenses'
ALTER TABLE [dbo].[Expenses]
ADD CONSTRAINT [FK_UserInfoExpense]
    FOREIGN KEY ([UserInfoId])
    REFERENCES [dbo].[UserInfoes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserInfoExpense'
CREATE INDEX [IX_FK_UserInfoExpense]
ON [dbo].[Expenses]
    ([UserInfoId]);
GO

-- Creating foreign key on [ContactId] in table 'Incomes'
ALTER TABLE [dbo].[Incomes]
ADD CONSTRAINT [FK_ContactIncome]
    FOREIGN KEY ([ContactId])
    REFERENCES [dbo].[Contacts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ContactIncome'
CREATE INDEX [IX_FK_ContactIncome]
ON [dbo].[Incomes]
    ([ContactId]);
GO

-- Creating foreign key on [ContactId] in table 'Expenses'
ALTER TABLE [dbo].[Expenses]
ADD CONSTRAINT [FK_ContactExpense]
    FOREIGN KEY ([ContactId])
    REFERENCES [dbo].[Contacts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ContactExpense'
CREATE INDEX [IX_FK_ContactExpense]
ON [dbo].[Expenses]
    ([ContactId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------