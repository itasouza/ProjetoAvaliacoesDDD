/*
Created		07/01/2020
Modified		09/01/2020
Project		
Model			
Company		
Author		
Version		
Database		MS SQL 2005 
*/


Create table [Produto]
(
	[ProdutoId] Integer Identity NOT NULL,
	[NomeProduto] Varchar(250) NULL,
	[DescricaoProduto] Text NULL,
	[ValorProduto] Decimal(18,2) NULL,
	[Ativo] Char(1) NULL,
	[DataFabricacao] Datetime NULL,
	[DataValidade] Datetime NULL,
	[ProdutoPromocao] Char(1) NULL,
	[DataCadastro] Datetime NULL,
	[DataAlteracao] Datetime NULL,
Primary Key ([ProdutoId])
) 
go

Create table [Avaliacao]
(
	[AvaliacaoId] Integer Identity NOT NULL,
	[PedidoDetalheId] Integer NOT NULL,
	[PedidoId] Integer NULL,
	[Titulo] Varchar(250) NULL,
	[Descricao] Text NULL,
	[QuantidadeEstrela] Integer NULL,
	[AvaliacaoUtil] Char(1) NULL,
	[Ativo] Char(1) NULL,
	[DataCadastro] Datetime NULL,
	[DataAlteracao] Datetime NULL,
Primary Key ([AvaliacaoId])
) 
go

Create table [Cliente]
(
	[ClienteId] Integer Identity NOT NULL,
	[EstadoId] Integer NULL,
	[CidadeId] Integer NULL,
	[NomeCliente] Varchar(250) NULL,
	[Email] Varchar(250) NULL,
	[Ativo] Char(1) NULL,
	[DataCadastro] Datetime NULL,
	[DataAlteracao] Datetime NULL,
Primary Key ([ClienteId])
) 
go

Create table [Estado]
(
	[EstadoId] Integer Identity NOT NULL,
	[Nome] Varchar(250) NULL,
	[Sigla] Char(2) NULL,
	[Ativo] Char(1) NULL,
	[DataCadastro] Datetime NULL,
	[DataAlteracao] Datetime NULL,
Primary Key ([EstadoId])
) 
go

Create table [Cidade]
(
	[CidadeId] Integer Identity NOT NULL,
	[EstadoId] Integer NOT NULL,
	[Nome] Varchar(250) NULL,
	[Ativo] Char(1) NULL,
	[DataCadastro] Datetime NULL,
	[DataAlteracao] Datetime NULL,
Primary Key ([CidadeId])
) 
go

Create table [Pedido]
(
	[PedidoId] Integer Identity NOT NULL,
	[ClienteId] Integer NOT NULL,
	[ValorTotal] Decimal(18,2) NULL,
	[Ativo] Char(1) NULL,
	[DataCadastro] Datetime NULL,
	[DataAlteracao] Datetime NULL,
Primary Key ([PedidoId])
) 
go

Create table [PedidoDetalhe]
(
	[PedidoDetalheId] Integer Identity NOT NULL,
	[ProdutoId] Integer NOT NULL,
	[PedidoId] Integer NOT NULL,
	[Quantidade] Integer NULL,
	[ValorProduto] Decimal(18,2) NULL,
	[Ativo] Char(1) NULL,
	[DataCadastro] Datetime NULL,
	[DataAlteracao] Datetime NULL,
Primary Key ([PedidoDetalheId])
) 
go

Create table [ImagemProduto]
(
	[ImagemId] Integer Identity NOT NULL,
	[ProdutoId] Integer NOT NULL,
	[FotoProduto] Varchar(250) NULL,
Primary Key ([ImagemId])
) 
go


Alter table [PedidoDetalhe] add  foreign key([ProdutoId]) references [Produto] ([ProdutoId])  on update no action on delete no action 
go
Alter table [ImagemProduto] add  foreign key([ProdutoId]) references [Produto] ([ProdutoId])  on update no action on delete no action 
go
Alter table [Pedido] add  foreign key([ClienteId]) references [Cliente] ([ClienteId])  on update no action on delete no action 
go
Alter table [Cidade] add  foreign key([EstadoId]) references [Estado] ([EstadoId])  on update no action on delete no action 
go
Alter table [PedidoDetalhe] add  foreign key([PedidoId]) references [Pedido] ([PedidoId])  on update no action on delete no action 
go
Alter table [Avaliacao] add  foreign key([PedidoDetalheId]) references [PedidoDetalhe] ([PedidoDetalheId])  on update no action on delete no action 
go


Set quoted_identifier on
go


Set quoted_identifier off
go


/* Roles permissions */


