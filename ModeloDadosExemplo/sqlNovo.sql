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


Create table [Usuario]
(
	[UsuarioId] Integer Identity NOT NULL,
	[NomeUsuario] Varchar(250) NULL,
	[Email] Varchar(250) NULL,
	[Ativo] Char(1) NULL,
	[DataCadastro] Datetime NULL,
	[DataAlteracao] Datetime NULL,
Primary Key ([UsuarioId])
) 
go

Create table [Produto]
(
	[ProdutoId] Integer Identity NOT NULL,
	[NomeProduto] Varchar(250) NULL,
	[DescricaoProduto] Text NULL,
	[ValorProduto] Decimal(18,2) NULL,
	[Ativo] Char(1) NULL,
	[DataFabricacao] Datetime NULL,
	[DataValidade] Datetime NULL,
	[FotoProduto] Varchar(250) NULL,
	[ProdutoPromocao] Char(1) NULL,
	[DataCadastro] Datetime NULL,
	[DataAlteracao] Datetime NULL,
Primary Key ([ProdutoId])
) 
go

Create table [Avaliacoes]
(
	[AvaliacoesId] Integer Identity NOT NULL,
	[UsuarioId] Integer NOT NULL,
	[ProdutoId] Integer NOT NULL,
	[ClienteId] Integer NOT NULL,
	[Titulo] Varchar(250) NULL,
	[Descricao] Text NULL,
	[QuantidadeEstrela] Integer NULL,
	[AvaliacaoUtil] Char(1) NULL,
	[Ativo] Char(1) NULL,
	[DataCadastro] Datetime NULL,
	[DataAlteracao] Datetime NULL,
Primary Key ([AvaliacoesId])
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
	[EstadoID] Integer Identity NOT NULL,
	[Nome] Varchar(250) NULL,
	[Sigla] Char(2) NULL,
	[Ativo] Char(1) NULL,
	[DataCadastro] Datetime NULL,
	[DataAlteracao] Datetime NULL,
Primary Key ([EstadoID])
) 
go

Create table [Cidade]
(
	[CidadeID] Integer Identity NOT NULL,
	[EstadoID] Integer NOT NULL,
	[Nome] Varchar(250) NULL,
	[Ativo] Char(1) NULL,
	[DataCadastro] Datetime NULL,
	[DataAlteracao] Datetime NULL,
Primary Key ([CidadeID])
) 
go


Alter table [Avaliacoes] add  foreign key([UsuarioId]) references [Usuario] ([UsuarioId])  on update no action on delete no action 
go
Alter table [Avaliacoes] add  foreign key([ProdutoId]) references [Produto] ([ProdutoId])  on update no action on delete no action 
go
Alter table [Avaliacoes] add  foreign key([ClienteId]) references [Cliente] ([ClienteId])  on update no action on delete no action 
go
Alter table [Cidade] add  foreign key([EstadoID]) references [Estado] ([EstadoID])  on update no action on delete no action 
go


Set quoted_identifier on
go


Set quoted_identifier off
go


/* Roles permissions */


