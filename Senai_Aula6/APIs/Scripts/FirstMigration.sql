IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Pedido] (
    [Id] uniqueidentifier NOT NULL,
    [Status] nvarchar(max) NULL,
    [OrderData] datetime2 NOT NULL,
    CONSTRAINT [PK_Pedido] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Produto] (
    [Id] uniqueidentifier NOT NULL,
    [Nome] nvarchar(max) NULL,
    [Preco] real NOT NULL,
    CONSTRAINT [PK_Produto] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [ProdutoItem] (
    [IdProdutoItem] uniqueidentifier NOT NULL,
    [IdPedido] uniqueidentifier NOT NULL,
    [PedidosId] uniqueidentifier NULL,
    [IdProduto] uniqueidentifier NOT NULL,
    [ProdutosId] uniqueidentifier NULL,
    CONSTRAINT [PK_ProdutoItem] PRIMARY KEY ([IdProdutoItem]),
    CONSTRAINT [FK_ProdutoItem_Pedido_PedidosId] FOREIGN KEY ([PedidosId]) REFERENCES [Pedido] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_ProdutoItem_Produto_ProdutosId] FOREIGN KEY ([ProdutosId]) REFERENCES [Produto] ([Id]) ON DELETE NO ACTION
);

GO

CREATE INDEX [IX_ProdutoItem_PedidosId] ON [ProdutoItem] ([PedidosId]);

GO

CREATE INDEX [IX_ProdutoItem_ProdutosId] ON [ProdutoItem] ([ProdutosId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200908135644_InitialCrate', N'3.1.7');

GO

