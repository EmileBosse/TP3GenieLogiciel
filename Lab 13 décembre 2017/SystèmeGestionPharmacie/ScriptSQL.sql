
CREATE DATABASE SystèmeGestionPharmacieDB
GO
Use SystèmeGestionPharmacieDB
Go
CREATE TABLE [dbo].[tblPrescription] ([ID] [uniqueidentifier] NOT NULL,numéro nvarchar(255), datePresciption datetime, copiePrescription varbinary(max), 
CONSTRAINT [PK_tblPrescription] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
) 
) ON [PRIMARY]

GO
CREATE TABLE [dbo].[tblPatient] ([ID] [uniqueidentifier] NOT NULL,numéroAssuranceMaladie nvarchar(255), nom nvarchar(255), prénom nvarchar(255), adresse nvarchar(255), numéroTéléphone nvarchar(255), dateNaissance datetime, 
CONSTRAINT [PK_tblPatient] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
) 
) ON [PRIMARY]

GO
CREATE TABLE [dbo].[tblMédicament] ([ID] [uniqueidentifier] NOT NULL,numéro nvarchar(255), nom nvarchar(255), manièreLivraison nvarchar(255), endroit nvarchar(255), nombreUnitésParJour decimal(10,2), nombreJours int, quantitéStock decimal(10,2), prixVente decimal(10,2), 
CONSTRAINT [PK_tblMédicament] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
) 
) ON [PRIMARY]

GO
CREATE TABLE [dbo].[tblTransactionVente] ([ID] [uniqueidentifier] NOT NULL,numéro nvarchar(255), dateTransactionVente datetime, montantTotal decimal(10,2), IDPaiement  uniqueidentifier NOT NULL, 
CONSTRAINT [PK_tblTransactionVente] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
) 
) ON [PRIMARY]

GO
CREATE TABLE [dbo].[tblRuptureDeStock] ([ID] [uniqueidentifier] NOT NULL,dateRuptureDeStock datetime, quantitéDemandée decimal(10,2), 
CONSTRAINT [PK_tblRuptureDeStock] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
) 
) ON [PRIMARY]

GO
CREATE TABLE [dbo].[tblMédecin] ([ID] [uniqueidentifier] NOT NULL,numéroLicense nvarchar(255), nom nvarchar(255), prénom nvarchar(255), adresse nvarchar(255), numéroTéléphone nvarchar(255), 
CONSTRAINT [PK_tblMédecin] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
) 
) ON [PRIMARY]

GO
CREATE TABLE [dbo].[tblPharmacie] ([ID] [uniqueidentifier] NOT NULL,numéro nvarchar(255), nom nvarchar(255), nomRésponsable nvarchar(255), adresse nvarchar(255), numéroTéléphone nvarchar(255), 
CONSTRAINT [PK_tblPharmacie] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
) 
) ON [PRIMARY]

GO
CREATE TABLE [dbo].[tblLigneTransactionVente] ([ID] [uniqueidentifier] NOT NULL,numéro int, montantLigne decimal(10,2), copieÉtiquette varbinary(max), IDTransactionVente  uniqueidentifier NOT NULL, 
CONSTRAINT [PK_tblLigneTransactionVente] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
) 
) ON [PRIMARY]

GO
CREATE TABLE [dbo].[tblUtilisateur] ([ID] [uniqueidentifier] NOT NULL,nomConnexion nvarchar(255), motDePasse nvarchar(255), 
CONSTRAINT [PK_tblUtilisateur] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
) 
) ON [PRIMARY]

GO
CREATE TABLE [dbo].[tblSession] ([ID] [uniqueidentifier] NOT NULL,dateConnexion datetime, dateDeconnexion datetime, 
CONSTRAINT [PK_tblSession] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
) 
) ON [PRIMARY]

GO
CREATE TABLE [dbo].[tblPharmacien] ([ID] [uniqueidentifier] NOT NULL,numéroLicense nvarchar(255), nom nvarchar(255), prénom nvarchar(255), adresse nvarchar(255), numéroTéléphone nvarchar(255), 
CONSTRAINT [PK_tblPharmacien] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
) 
) ON [PRIMARY]

GO
CREATE TABLE [dbo].[tblPaiement] ([ID] [uniqueidentifier] NOT NULL,numéro nvarchar(255), datePaiement datetime, montant decimal(10,2), typePaiement nvarchar(255), 
CONSTRAINT [PK_tblPaiement] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
) 
) ON [PRIMARY]

GO
CREATE TABLE [dbo].[tblPrescriptionLignePrescriptionMédicament] (ID uniqueidentifier NOT NULL,IDPrescription [uniqueidentifier] NOT NULL,IDMédicament  uniqueidentifier NOT NULL,numéro nvarchar(255), nom nvarchar(255), nombreUnitésParJour decimal(10,2), nombreJours int, quantité decimal(10,2), nombreRenouvellements int, nombreRenouvellementsRestants int, 
CONSTRAINT [PK_tblPrescriptionLignePrescriptionMédicament] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)
) ON [PRIMARY]

GO
