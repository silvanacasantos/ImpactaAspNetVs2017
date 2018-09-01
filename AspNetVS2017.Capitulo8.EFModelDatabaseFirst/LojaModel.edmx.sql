
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/01/2018 15:26:47
-- Generated from EDMX file: C:\Users\sa5121\source\repos\ImpactaAspNetVs2017\AspNetVS2017.Capitulo8.EFModelDatabaseFirst\LojaModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [LojaModelFirst];
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

-- Creating table 'Categoria'
CREATE TABLE [dbo].[Categoria] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(200)  NOT NULL
);
GO

-- Creating table 'ProdutoImagem'
CREATE TABLE [dbo].[ProdutoImagem] (
    [Produto_Id] int  NOT NULL,
    [Imagem] varbinary(max)  NOT NULL
);
GO

-- Creating table 'ProdutoSet'
CREATE TABLE [dbo].[ProdutoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(200)  NOT NULL,
    [Preco] decimal(9,2)  NOT NULL,
    [Categoria_Id] int  NOT NULL
);
GO

-- Creating table 'Fornecedores'
CREATE TABLE [dbo].[Fornecedores] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(200)  NOT NULL
);
GO

-- Creating table 'CategoriaFornecedores'
CREATE TABLE [dbo].[CategoriaFornecedores] (
    [Categoria_Id] int  NOT NULL,
    [Fornecedores_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Categoria'
ALTER TABLE [dbo].[Categoria]
ADD CONSTRAINT [PK_Categoria]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Produto_Id] in table 'ProdutoImagem'
ALTER TABLE [dbo].[ProdutoImagem]
ADD CONSTRAINT [PK_ProdutoImagem]
    PRIMARY KEY CLUSTERED ([Produto_Id] ASC);
GO

-- Creating primary key on [Id] in table 'ProdutoSet'
ALTER TABLE [dbo].[ProdutoSet]
ADD CONSTRAINT [PK_ProdutoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Fornecedores'
ALTER TABLE [dbo].[Fornecedores]
ADD CONSTRAINT [PK_Fornecedores]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Categoria_Id], [Fornecedores_Id] in table 'CategoriaFornecedores'
ALTER TABLE [dbo].[CategoriaFornecedores]
ADD CONSTRAINT [PK_CategoriaFornecedores]
    PRIMARY KEY CLUSTERED ([Categoria_Id], [Fornecedores_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Categoria_Id] in table 'ProdutoSet'
ALTER TABLE [dbo].[ProdutoSet]
ADD CONSTRAINT [FK_CategoriaProduto]
    FOREIGN KEY ([Categoria_Id])
    REFERENCES [dbo].[Categoria]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoriaProduto'
CREATE INDEX [IX_FK_CategoriaProduto]
ON [dbo].[ProdutoSet]
    ([Categoria_Id]);
GO

-- Creating foreign key on [Produto_Id] in table 'ProdutoImagem'
ALTER TABLE [dbo].[ProdutoImagem]
ADD CONSTRAINT [FK_ProdutoProdutoImagem]
    FOREIGN KEY ([Produto_Id])
    REFERENCES [dbo].[ProdutoSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Categoria_Id] in table 'CategoriaFornecedores'
ALTER TABLE [dbo].[CategoriaFornecedores]
ADD CONSTRAINT [FK_CategoriaFornecedores_Categoria]
    FOREIGN KEY ([Categoria_Id])
    REFERENCES [dbo].[Categoria]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Fornecedores_Id] in table 'CategoriaFornecedores'
ALTER TABLE [dbo].[CategoriaFornecedores]
ADD CONSTRAINT [FK_CategoriaFornecedores_Fornecedores]
    FOREIGN KEY ([Fornecedores_Id])
    REFERENCES [dbo].[Fornecedores]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoriaFornecedores_Fornecedores'
CREATE INDEX [IX_FK_CategoriaFornecedores_Fornecedores]
ON [dbo].[CategoriaFornecedores]
    ([Fornecedores_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------