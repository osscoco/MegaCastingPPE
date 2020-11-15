USE [Megacasting]
GO
SET IDENTITY_INSERT [dbo].[Artiste] ON 
GO
INSERT [dbo].[Artiste] ([ID_ART], [Prenom_ART], [Nom_ART], [Date_Nai_ART], [Mail_ART], [Pass_ART]) VALUES (1,'John','Lenais', CAST('1990-10-23' AS Date),'jlenais@mc.fr','Not24getjl')
GO
SET IDENTITY_INSERT [dbo].[Artiste] OFF
GO
SET IDENTITY_INSERT [dbo].[Statut] ON 
GO
INSERT [dbo].[Statut] ([ID_Statut], [Libellée_Statut]) VALUES (1,'En ligne')
GO
INSERT [dbo].[Statut] ([ID_Statut], [Libellée_Statut]) VALUES (2,'En cours')
GO
INSERT [dbo].[Statut] ([ID_Statut], [Libellée_Statut]) VALUES (3,'Non disponible')
GO
SET IDENTITY_INSERT [dbo].[Statut] OFF
GO
SET IDENTITY_INSERT [dbo].[Contrat] ON 
GO
INSERT [dbo].[Contrat] ([ID_Contrat], [Libelle_Contrat]) VALUES (1,'CDD')
GO
INSERT [dbo].[Contrat] ([ID_Contrat], [Libelle_Contrat]) VALUES (2,'CDI')
GO
INSERT [dbo].[Contrat] ([ID_Contrat], [Libelle_Contrat]) VALUES (3,'Intérim')
GO
SET IDENTITY_INSERT [dbo].[Contrat] OFF
GO
SET IDENTITY_INSERT [dbo].[Employe] ON 
GO
INSERT [dbo].[Employe] ([ID_EMP], [Prenom_EMP], [Nom_EMP], [Mail_EMP], [Pass_EMP]) VALUES (1,'Amber','Duflot','aduflot@mc.fr','Not24getad')
GO
INSERT [dbo].[Employe] ([ID_EMP], [Prenom_EMP], [Nom_EMP], [Mail_EMP], [Pass_EMP]) VALUES (2,'Stephan','Poure','spoure@mc.fr','Not24getsp')
GO
INSERT [dbo].[Employe] ([ID_EMP], [Prenom_EMP], [Nom_EMP], [Mail_EMP], [Pass_EMP]) VALUES (3,'Albert','Zer','azer@mc.fr','Not24getaz')
GO
SET IDENTITY_INSERT [dbo].[Employe] OFF
GO
SET IDENTITY_INSERT [dbo].[Metier] ON 
GO
INSERT [dbo].[Metier] ([ID_Metier], [Libellée_Metier]) VALUES (1,'Musicien')
GO
INSERT [dbo].[Metier] ([ID_Metier], [Libellée_Metier]) VALUES (2,'Danseur')
GO
INSERT [dbo].[Metier] ([ID_Metier], [Libellée_Metier]) VALUES (3,'Chanteur')
GO
SET IDENTITY_INSERT [dbo].[Metier] OFF
GO
SET IDENTITY_INSERT [dbo].[Professionnel] ON 
GO
INSERT [dbo].[Professionnel] ([ID_PRO], [Prenom_PRO], [Nom_PRO], [Mail_PRO], [Pass_PRO]) VALUES (1,'Jeff','Urtens','jurtense@mc.fr','Not24getju')
GO
INSERT [dbo].[Professionnel] ([ID_PRO], [Prenom_PRO], [Nom_PRO], [Mail_PRO], [Pass_PRO]) VALUES (2,'Bill','Gates','bgates@mc.fr','Not24getbg')
GO
INSERT [dbo].[Professionnel] ([ID_PRO], [Prenom_PRO], [Nom_PRO], [Mail_PRO], [Pass_PRO]) VALUES (3,'Fred','Kilard','fkilard@mc.fr','Not24getfk')
GO
INSERT [dbo].[Professionnel] ([ID_PRO], [Prenom_PRO], [Nom_PRO], [Mail_PRO], [Pass_PRO]) VALUES (4,'Kyliann','Dufort','kdufort@mc.fr','Not24getkd')
GO
INSERT [dbo].[Professionnel] ([ID_PRO], [Prenom_PRO], [Nom_PRO], [Mail_PRO], [Pass_PRO]) VALUES (5,'Quentin','Dutronc','qdutronc@mc.fr','Not24getqd')
GO
SET IDENTITY_INSERT [dbo].[Professionnel] OFF
GO
SET IDENTITY_INSERT [dbo].[Ville] ON 
GO
INSERT [dbo].[Ville] ([ID_Ville], [Libellée_VILLE]) VALUES (1,'Laval')
GO
INSERT [dbo].[Ville] ([ID_Ville], [Libellée_VILLE]) VALUES (2,'Rennes')
GO
INSERT [dbo].[Ville] ([ID_Ville], [Libellée_VILLE]) VALUES (3,'Angers')
GO
INSERT [dbo].[Ville] ([ID_Ville], [Libellée_VILLE]) VALUES (4,'Nantes')
GO
SET IDENTITY_INSERT [dbo].[Ville] OFF
GO
SET IDENTITY_INSERT [dbo].[Annonce] ON 
GO
INSERT [dbo].[Annonce] ([ID_ANN], [Intitulée_ANN], [Date_Pub_ANN], [Date_Deb_ANN], [Date_Fin_ANN], [IdContrat], [IdPro], [IdEmp], [IdVille], [IdMetier]) VALUES (17,'Nouveau', CAST('2020-11-09' AS Date), CAST('2020-11-06' AS Date), CAST('2020-11-09' AS Date), 1, 1, 1, 1, 1)
GO
SET IDENTITY_INSERT [dbo].[Annonce] OFF
GO
