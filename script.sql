USE [master]
GO
/****** Object:  Database [estoquess]    Script Date: 01/02/2024 13:08:01 ******/
CREATE DATABASE [estoquess]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ControleEstoque', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLSERVERDARLAN\MSSQL\DATA\ControleEstoque.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ControleEstoque_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLSERVERDARLAN\MSSQL\DATA\ControleEstoque_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [estoquess] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [estoquess].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [estoquess] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [estoquess] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [estoquess] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [estoquess] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [estoquess] SET ARITHABORT OFF 
GO
ALTER DATABASE [estoquess] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [estoquess] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [estoquess] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [estoquess] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [estoquess] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [estoquess] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [estoquess] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [estoquess] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [estoquess] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [estoquess] SET  DISABLE_BROKER 
GO
ALTER DATABASE [estoquess] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [estoquess] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [estoquess] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [estoquess] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [estoquess] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [estoquess] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [estoquess] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [estoquess] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [estoquess] SET  MULTI_USER 
GO
ALTER DATABASE [estoquess] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [estoquess] SET DB_CHAINING OFF 
GO
ALTER DATABASE [estoquess] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [estoquess] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [estoquess] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [estoquess] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [estoquess] SET QUERY_STORE = ON
GO
ALTER DATABASE [estoquess] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [estoquess]
GO
/****** Object:  Table [dbo].[fornecedor]    Script Date: 01/02/2024 13:08:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[fornecedor](
	[fornecedor] [nchar](100) NULL,
	[telefone] [int] NULL,
	[endereco] [nchar](100) NULL,
	[cep] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[produto]    Script Date: 01/02/2024 13:08:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[produto](
	[quantidade] [int] NULL,
	[codigo] [int] NULL,
	[produto] [nchar](100) NULL,
	[descricao] [nchar](150) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[fornecedor] ([fornecedor], [telefone], [endereco], [cep]) VALUES (N'Total Produtos de Limpeza Ltda.                                                                     ', 98546325, N'Avenida Principal, 456                                                                              ', 54822658)
INSERT [dbo].[fornecedor] ([fornecedor], [telefone], [endereco], [cep]) VALUES (N'Mundo da Limpeza Distribuidora Ltda.                                                                ', 992548635, N'Travessa das Águas, 789                                                                             ', 84655218)
INSERT [dbo].[fornecedor] ([fornecedor], [telefone], [endereco], [cep]) VALUES (N'Nova Limpeza Ltda                                                                                   ', 77586245, N'Rua Nova Limpeza, 890                                                                               ', 57899645)
INSERT [dbo].[fornecedor] ([fornecedor], [telefone], [endereco], [cep]) VALUES (N'Clean Ltda                                                                                          ', 33458268, N'Rua Clean, 321                                                                                      ', 75466328)
INSERT [dbo].[fornecedor] ([fornecedor], [telefone], [endereco], [cep]) VALUES (N'Brilhante Ltda                                                                                      ', 33354862, N'Avenida Brilhante, 456                                                                              ', 84655219)
INSERT [dbo].[fornecedor] ([fornecedor], [telefone], [endereco], [cep]) VALUES (N'HigiClean Ltda                                                                                      ', 33358796, N'Travessa HigiClean, 789                                                                             ', 24855682)
INSERT [dbo].[fornecedor] ([fornecedor], [telefone], [endereco], [cep]) VALUES (N'Limpmax Ltda                                                                                        ', 94523659, N'Avenida Limpmax, 567                                                                                ', 15244865)
INSERT [dbo].[fornecedor] ([fornecedor], [telefone], [endereco], [cep]) VALUES (N'CleanTech Ltda                                                                                      ', 33485698, N'Praça CleanTech, 890                                                                                ', 64822658)
INSERT [dbo].[fornecedor] ([fornecedor], [telefone], [endereco], [cep]) VALUES (N'BrilhoVivo Ltda                                                                                     ', 66567852, N' Rua BrilhoVivo, 234                                                                                ', 45822658)
GO
INSERT [dbo].[produto] ([quantidade], [codigo], [produto], [descricao]) VALUES (20, 1, N'Detergente Multiuso                                                                                 ', N'limpeza geral                                                                                                                                         ')
INSERT [dbo].[produto] ([quantidade], [codigo], [produto], [descricao]) VALUES (15, 2, N'Desinfetante                                                                                        ', N'Produto químico                                                                                                                                       ')
INSERT [dbo].[produto] ([quantidade], [codigo], [produto], [descricao]) VALUES (10, 3, N'Limpador de Vidros                                                                                  ', N'limpar vidros e espelhos                                                                                                                              ')
INSERT [dbo].[produto] ([quantidade], [codigo], [produto], [descricao]) VALUES (6, 4, N'Sabão em Pó                                                                                         ', N' lavagem de roupas                                                                                                                                    ')
INSERT [dbo].[produto] ([quantidade], [codigo], [produto], [descricao]) VALUES (3, 5, N'Limpa-Forno                                                                                         ', N'Remoção de Gorduras                                                                                                                                   ')
INSERT [dbo].[produto] ([quantidade], [codigo], [produto], [descricao]) VALUES (12, 6, N'Limpa-Pisos                                                                                         ', N'limpeza de pisos                                                                                                                                      ')
INSERT [dbo].[produto] ([quantidade], [codigo], [produto], [descricao]) VALUES (22, 7, N'Álcool Líquido                                                                                      ', N'desinfetar superfícies                                                                                                                                ')
INSERT [dbo].[produto] ([quantidade], [codigo], [produto], [descricao]) VALUES (31, 8, N'Esponja de Limpeza                                                                                  ', N' remoção de sujeira                                                                                                                                   ')
INSERT [dbo].[produto] ([quantidade], [codigo], [produto], [descricao]) VALUES (17, 9, N'Vassoura                                                                                            ', N'varrer pisos                                                                                                                                          ')
INSERT [dbo].[produto] ([quantidade], [codigo], [produto], [descricao]) VALUES (16, 10, N'Esfregão                                                                                            ', N'limpeza de pisos                                                                                                                                      ')
INSERT [dbo].[produto] ([quantidade], [codigo], [produto], [descricao]) VALUES (10, 11, N'Balde de Limpeza                                                                                    ', N'transportar água e soluções                                                                                                                           ')
INSERT [dbo].[produto] ([quantidade], [codigo], [produto], [descricao]) VALUES (18, 12, N'Pá para Lixo                                                                                        ', N' recolher lixo e detritos                                                                                                                             ')
INSERT [dbo].[produto] ([quantidade], [codigo], [produto], [descricao]) VALUES (37, 13, N'Luvas de Borracha                                                                                   ', N'Protegem as mãos                                                                                                                                      ')
GO
USE [master]
GO
ALTER DATABASE [estoquess] SET  READ_WRITE 
GO
