USE [master]
GO
/****** Object:  Database [SMCBaseDeDados]    Script Date: 26/02/2019 04:08:31 ******/
CREATE DATABASE [SMCBaseDeDados]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SMCBaseDeDados', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\SMCBaseDeDados.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SMCBaseDeDados_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\SMCBaseDeDados_log.ldf' , SIZE = 1040KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SMCBaseDeDados] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SMCBaseDeDados].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SMCBaseDeDados] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SMCBaseDeDados] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SMCBaseDeDados] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SMCBaseDeDados] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SMCBaseDeDados] SET ARITHABORT OFF 
GO
ALTER DATABASE [SMCBaseDeDados] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SMCBaseDeDados] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [SMCBaseDeDados] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SMCBaseDeDados] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SMCBaseDeDados] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SMCBaseDeDados] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SMCBaseDeDados] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SMCBaseDeDados] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SMCBaseDeDados] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SMCBaseDeDados] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SMCBaseDeDados] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SMCBaseDeDados] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SMCBaseDeDados] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SMCBaseDeDados] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SMCBaseDeDados] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SMCBaseDeDados] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SMCBaseDeDados] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [SMCBaseDeDados] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SMCBaseDeDados] SET RECOVERY FULL 
GO
ALTER DATABASE [SMCBaseDeDados] SET  MULTI_USER 
GO
ALTER DATABASE [SMCBaseDeDados] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SMCBaseDeDados] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SMCBaseDeDados] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SMCBaseDeDados] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'SMCBaseDeDados', N'ON'
GO
USE [SMCBaseDeDados]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 26/02/2019 04:08:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Empresa]    Script Date: 26/02/2019 04:08:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empresa](
	[IdEmpresa] [int] IDENTITY(1,1) NOT NULL,
	[RazaoSocial] [varchar](200) NULL,
	[NomeFantasia] [varchar](200) NULL,
	[AtividadePrincipal] [varchar](200) NULL,
	[Cnpj] [varchar](200) NULL,
	[InscricaoEstadual] [varchar](200) NULL,
	[CapitalRegistrado] [varchar](200) NULL,
	[PatrimonioLiquido] [varchar](200) NULL,
	[IdResponsavel] [int] NOT NULL,
	[EnderecoRua] [varchar](200) NULL,
	[EnderecoNumero] [varchar](200) NULL,
	[EnderecoBairro] [varchar](200) NULL,
	[EnderecoCidade] [varchar](200) NULL,
	[EnderecoEstado] [varchar](200) NULL,
	[EndercoCep] [varchar](200) NULL,
	[EnderecoComplemento] [varchar](200) NULL,
	[Telefone] [varchar](200) NULL,
	[Email] [varchar](200) NULL,
	[Celular] [varchar](200) NULL,
 CONSTRAINT [PK_dbo.Empresa] PRIMARY KEY CLUSTERED 
(
	[IdEmpresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ReferenciasBancarias]    Script Date: 26/02/2019 04:08:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ReferenciasBancarias](
	[IdReferencia] [int] IDENTITY(1,1) NOT NULL,
	[NomeDoBanco] [varchar](200) NULL,
	[Telefone] [varchar](200) NULL,
	[Empresa_IdEmpresa] [int] NULL,
	[Cidade] [varchar](200) NULL,
 CONSTRAINT [PK_dbo.ReferenciasBancarias] PRIMARY KEY CLUSTERED 
(
	[IdReferencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ReferenciasComerciais]    Script Date: 26/02/2019 04:08:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ReferenciasComerciais](
	[IdReferenciaComercial] [int] IDENTITY(1,1) NOT NULL,
	[NomeDaLoja] [varchar](200) NULL,
	[Telefone] [varchar](200) NULL,
	[Empresa_IdEmpresa] [int] NULL,
	[Cidade] [varchar](200) NULL,
 CONSTRAINT [PK_dbo.ReferenciasComerciais] PRIMARY KEY CLUSTERED 
(
	[IdReferenciaComercial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ResponsavelPelaEmpresa]    Script Date: 26/02/2019 04:08:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ResponsavelPelaEmpresa](
	[IdResponsavel] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](200) NULL,
	[Cpf] [varchar](200) NULL,
	[Rg] [varchar](200) NULL,
	[Telefone] [varchar](200) NULL,
	[DataDeNascimento] [varchar](200) NULL,
	[Sexo] [int] NOT NULL,
	[EstadoCivil] [int] NOT NULL,
	[OrgaoExpeditor] [varchar](200) NULL,
	[Celular] [varchar](200) NULL,
	[Email] [varchar](200) NULL,
	[NomeDoPai] [varchar](200) NULL,
	[NomeDaMae] [varchar](200) NULL,
	[Naturalidade] [varchar](200) NULL,
	[Nacionalidade] [varchar](200) NULL,
	[Profissao] [varchar](200) NULL,
 CONSTRAINT [PK_dbo.ResponsavelPelaEmpresa] PRIMARY KEY CLUSTERED 
(
	[IdResponsavel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Socios]    Script Date: 26/02/2019 04:08:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Socios](
	[IdSocio] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](200) NULL,
	[Cargo] [varchar](200) NULL,
	[Participacao] [varchar](200) NULL,
	[Telefone] [varchar](200) NULL,
	[Empresa_IdEmpresa] [int] NULL,
 CONSTRAINT [PK_dbo.Socios] PRIMARY KEY CLUSTERED 
(
	[IdSocio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Index [IX_IdResponsavel]    Script Date: 26/02/2019 04:08:31 ******/
CREATE NONCLUSTERED INDEX [IX_IdResponsavel] ON [dbo].[Empresa]
(
	[IdResponsavel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Empresa_IdEmpresa]    Script Date: 26/02/2019 04:08:31 ******/
CREATE NONCLUSTERED INDEX [IX_Empresa_IdEmpresa] ON [dbo].[ReferenciasBancarias]
(
	[Empresa_IdEmpresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Empresa_IdEmpresa]    Script Date: 26/02/2019 04:08:31 ******/
CREATE NONCLUSTERED INDEX [IX_Empresa_IdEmpresa] ON [dbo].[ReferenciasComerciais]
(
	[Empresa_IdEmpresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Empresa_IdEmpresa]    Script Date: 26/02/2019 04:08:31 ******/
CREATE NONCLUSTERED INDEX [IX_Empresa_IdEmpresa] ON [dbo].[Socios]
(
	[Empresa_IdEmpresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Empresa]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Empresa_dbo.ResponsavelPelaEmpresa_IdResponsavel] FOREIGN KEY([IdResponsavel])
REFERENCES [dbo].[ResponsavelPelaEmpresa] ([IdResponsavel])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Empresa] CHECK CONSTRAINT [FK_dbo.Empresa_dbo.ResponsavelPelaEmpresa_IdResponsavel]
GO
ALTER TABLE [dbo].[ReferenciasBancarias]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ReferenciasBancarias_dbo.Empresa_Empresa_IdEmpresa] FOREIGN KEY([Empresa_IdEmpresa])
REFERENCES [dbo].[Empresa] ([IdEmpresa])
GO
ALTER TABLE [dbo].[ReferenciasBancarias] CHECK CONSTRAINT [FK_dbo.ReferenciasBancarias_dbo.Empresa_Empresa_IdEmpresa]
GO
ALTER TABLE [dbo].[ReferenciasComerciais]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ReferenciasComerciais_dbo.Empresa_Empresa_IdEmpresa] FOREIGN KEY([Empresa_IdEmpresa])
REFERENCES [dbo].[Empresa] ([IdEmpresa])
GO
ALTER TABLE [dbo].[ReferenciasComerciais] CHECK CONSTRAINT [FK_dbo.ReferenciasComerciais_dbo.Empresa_Empresa_IdEmpresa]
GO
ALTER TABLE [dbo].[Socios]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Socios_dbo.Empresa_Empresa_IdEmpresa] FOREIGN KEY([Empresa_IdEmpresa])
REFERENCES [dbo].[Empresa] ([IdEmpresa])
GO
ALTER TABLE [dbo].[Socios] CHECK CONSTRAINT [FK_dbo.Socios_dbo.Empresa_Empresa_IdEmpresa]
GO
USE [master]
GO
ALTER DATABASE [SMCBaseDeDados] SET  READ_WRITE 
GO
