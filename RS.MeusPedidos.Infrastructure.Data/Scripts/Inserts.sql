﻿INSERT [dbo].[Conhecimento] ([Id], [Nome], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (N'5455f539-5d08-4e5a-a1bf-24acc8d300dd', N'Django', CAST(N'2017-03-23T08:13:17.300' AS DateTime), NULL, CAST(N'2017-03-23T08:19:05.037' AS DateTime), NULL)
INSERT [dbo].[Conhecimento] ([Id], [Nome], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (N'28ebd434-60e8-4209-9395-33c6986abd4f', N'Desenvolvimento iOS', CAST(N'2017-03-23T08:19:05.027' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Conhecimento] ([Id], [Nome], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (N'34f24135-bc34-4c63-a7b3-5ad05d3d7b99', N'Python', CAST(N'2017-03-23T08:00:06.080' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Conhecimento] ([Id], [Nome], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (N'80c4ddee-cb10-4d25-80fb-5df4b78bc3fb', N'Javascript', CAST(N'2017-03-23T07:59:59.410' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Conhecimento] ([Id], [Nome], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (N'c0ec21d8-58ed-4961-8b51-667dbca59540', N'HTML', CAST(N'2017-03-23T07:59:48.813' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Conhecimento] ([Id], [Nome], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (N'38ffdcae-d7d9-4ce3-a548-db4810fac1cc', N'Desenvolvimento Android', CAST(N'2017-03-23T08:19:11.453' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Conhecimento] ([Id], [Nome], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (N'3c6d938d-362e-43c0-a15f-f6ed716a9586', N'CSS', CAST(N'2017-03-23T07:59:53.990' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Email] ([Id], [Assunto], [Conteudo], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [Identificador]) VALUES (N'5db2771c-6b25-4ec1-821c-9f03c12911ea', N'Obrigado por se candidatar', N'Obrigado por se candidatar, assim que tivermos uma vaga disponível para programador Back-End entraremos em contato.', CAST(N'2017-03-23T15:28:55.170' AS DateTime), NULL, CAST(N'2017-03-23T15:34:58.180' AS DateTime), NULL, N'Back-end')
INSERT [dbo].[Email] ([Id], [Assunto], [Conteudo], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [Identificador]) VALUES (N'41a11454-854e-4221-b66a-d1ccc1ec3a5d', N'Obrigado por se candidatar', N'Obrigado por se candidatar, assim que tivermos uma vaga disponível para programador Front-End entraremos em contato.', CAST(N'2017-03-23T15:28:34.053' AS DateTime), NULL, CAST(N'2017-03-23T15:35:04.807' AS DateTime), NULL, N'Front-End')
INSERT [dbo].[Email] ([Id], [Assunto], [Conteudo], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [Identificador]) VALUES (N'6a346fab-a788-4eec-8e72-d39ae0d8599a', N'Obrigado por se candidatar', N'Obrigado por se candidatar, assim que tivermos uma vaga disponível para programador Mobile entraremos em contato.', CAST(N'2017-03-23T15:29:30.340' AS DateTime), NULL, CAST(N'2017-03-23T15:35:11.190' AS DateTime), NULL, N'Mobile')
INSERT [dbo].[Perfil] ([Id], [Nome], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [EmailId]) VALUES (N'b2d64e27-4490-4847-b44e-2dc2fec97fe9', N'Mobile', CAST(N'2017-03-23T10:11:55.360' AS DateTime), NULL, CAST(N'2017-03-23T15:42:32.657' AS DateTime), NULL, N'6a346fab-a788-4eec-8e72-d39ae0d8599a')
INSERT [dbo].[Perfil] ([Id], [Nome], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [EmailId]) VALUES (N'24b4a1fe-4f44-417b-b5e6-9f3e4b2a668d', N'Mobile', CAST(N'2017-03-23T12:42:53.487' AS DateTime), NULL, CAST(N'2017-03-23T15:42:36.287' AS DateTime), NULL, N'6a346fab-a788-4eec-8e72-d39ae0d8599a')
INSERT [dbo].[Perfil] ([Id], [Nome], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [EmailId]) VALUES (N'7c74ae92-fa93-4492-bd79-a70f91e0d55f', N'Back-end', CAST(N'2017-03-23T09:35:10.493' AS DateTime), NULL, CAST(N'2017-03-23T15:42:44.030' AS DateTime), NULL, N'5db2771c-6b25-4ec1-821c-9f03c12911ea')
INSERT [dbo].[Perfil] ([Id], [Nome], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [EmailId]) VALUES (N'7ff25304-b7c9-436d-af6e-e6edd97c85be', N'Front-end', CAST(N'2017-03-23T09:30:49.627' AS DateTime), NULL, CAST(N'2017-03-23T15:42:49.193' AS DateTime), NULL, N'41a11454-854e-4221-b66a-d1ccc1ec3a5d')
INSERT [dbo].[Condicao] ([ConhecimentoId], [PerfilId], [Pontos], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (N'5455f539-5d08-4e5a-a1bf-24acc8d300dd', N'b2d64e27-4490-4847-b44e-2dc2fec97fe9', 0, CAST(N'2017-03-23T10:11:55.360' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Condicao] ([ConhecimentoId], [PerfilId], [Pontos], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (N'5455f539-5d08-4e5a-a1bf-24acc8d300dd', N'24b4a1fe-4f44-417b-b5e6-9f3e4b2a668d', 0, CAST(N'2017-03-23T12:42:53.487' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Condicao] ([ConhecimentoId], [PerfilId], [Pontos], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (N'5455f539-5d08-4e5a-a1bf-24acc8d300dd', N'7c74ae92-fa93-4492-bd79-a70f91e0d55f', 7, CAST(N'2017-03-23T09:35:10.503' AS DateTime), NULL, CAST(N'2017-03-23T10:11:32.423' AS DateTime), NULL)
INSERT [dbo].[Condicao] ([ConhecimentoId], [PerfilId], [Pontos], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (N'5455f539-5d08-4e5a-a1bf-24acc8d300dd', N'7ff25304-b7c9-436d-af6e-e6edd97c85be', 0, CAST(N'2017-03-23T09:30:49.637' AS DateTime), NULL, CAST(N'2017-03-23T10:11:01.417' AS DateTime), NULL)
INSERT [dbo].[Condicao] ([ConhecimentoId], [PerfilId], [Pontos], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (N'28ebd434-60e8-4209-9395-33c6986abd4f', N'b2d64e27-4490-4847-b44e-2dc2fec97fe9', 7, CAST(N'2017-03-23T10:11:55.360' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Condicao] ([ConhecimentoId], [PerfilId], [Pontos], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (N'28ebd434-60e8-4209-9395-33c6986abd4f', N'24b4a1fe-4f44-417b-b5e6-9f3e4b2a668d', 0, CAST(N'2017-03-23T12:42:53.490' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Condicao] ([ConhecimentoId], [PerfilId], [Pontos], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (N'28ebd434-60e8-4209-9395-33c6986abd4f', N'7c74ae92-fa93-4492-bd79-a70f91e0d55f', 0, CAST(N'2017-03-23T09:35:10.503' AS DateTime), NULL, CAST(N'2017-03-23T10:18:34.183' AS DateTime), NULL)
INSERT [dbo].[Condicao] ([ConhecimentoId], [PerfilId], [Pontos], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (N'28ebd434-60e8-4209-9395-33c6986abd4f', N'7ff25304-b7c9-436d-af6e-e6edd97c85be', 0, CAST(N'2017-03-23T09:30:49.637' AS DateTime), NULL, CAST(N'2017-03-23T10:11:01.417' AS DateTime), NULL)
INSERT [dbo].[Condicao] ([ConhecimentoId], [PerfilId], [Pontos], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (N'34f24135-bc34-4c63-a7b3-5ad05d3d7b99', N'b2d64e27-4490-4847-b44e-2dc2fec97fe9', 0, CAST(N'2017-03-23T10:11:55.360' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Condicao] ([ConhecimentoId], [PerfilId], [Pontos], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (N'34f24135-bc34-4c63-a7b3-5ad05d3d7b99', N'24b4a1fe-4f44-417b-b5e6-9f3e4b2a668d', 0, CAST(N'2017-03-23T12:42:53.490' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Condicao] ([ConhecimentoId], [PerfilId], [Pontos], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (N'34f24135-bc34-4c63-a7b3-5ad05d3d7b99', N'7c74ae92-fa93-4492-bd79-a70f91e0d55f', 7, CAST(N'2017-03-23T09:35:10.503' AS DateTime), NULL, CAST(N'2017-03-23T10:11:32.423' AS DateTime), NULL)
INSERT [dbo].[Condicao] ([ConhecimentoId], [PerfilId], [Pontos], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (N'34f24135-bc34-4c63-a7b3-5ad05d3d7b99', N'7ff25304-b7c9-436d-af6e-e6edd97c85be', 0, CAST(N'2017-03-23T09:30:49.637' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Condicao] ([ConhecimentoId], [PerfilId], [Pontos], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (N'80c4ddee-cb10-4d25-80fb-5df4b78bc3fb', N'b2d64e27-4490-4847-b44e-2dc2fec97fe9', 0, CAST(N'2017-03-23T10:11:55.360' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Condicao] ([ConhecimentoId], [PerfilId], [Pontos], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (N'80c4ddee-cb10-4d25-80fb-5df4b78bc3fb', N'24b4a1fe-4f44-417b-b5e6-9f3e4b2a668d', 0, CAST(N'2017-03-23T12:42:53.490' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Condicao] ([ConhecimentoId], [PerfilId], [Pontos], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (N'80c4ddee-cb10-4d25-80fb-5df4b78bc3fb', N'7c74ae92-fa93-4492-bd79-a70f91e0d55f', 0, CAST(N'2017-03-23T09:35:10.503' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Condicao] ([ConhecimentoId], [PerfilId], [Pontos], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (N'80c4ddee-cb10-4d25-80fb-5df4b78bc3fb', N'7ff25304-b7c9-436d-af6e-e6edd97c85be', 7, CAST(N'2017-03-23T09:30:49.637' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Condicao] ([ConhecimentoId], [PerfilId], [Pontos], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (N'c0ec21d8-58ed-4961-8b51-667dbca59540', N'b2d64e27-4490-4847-b44e-2dc2fec97fe9', 0, CAST(N'2017-03-23T10:11:55.360' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Condicao] ([ConhecimentoId], [PerfilId], [Pontos], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (N'c0ec21d8-58ed-4961-8b51-667dbca59540', N'24b4a1fe-4f44-417b-b5e6-9f3e4b2a668d', 0, CAST(N'2017-03-23T12:42:53.490' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Condicao] ([ConhecimentoId], [PerfilId], [Pontos], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (N'c0ec21d8-58ed-4961-8b51-667dbca59540', N'7c74ae92-fa93-4492-bd79-a70f91e0d55f', 0, CAST(N'2017-03-23T09:35:10.503' AS DateTime), NULL, CAST(N'2017-03-23T10:11:32.423' AS DateTime), NULL)
INSERT [dbo].[Condicao] ([ConhecimentoId], [PerfilId], [Pontos], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (N'c0ec21d8-58ed-4961-8b51-667dbca59540', N'7ff25304-b7c9-436d-af6e-e6edd97c85be', 7, CAST(N'2017-03-23T09:30:49.637' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Condicao] ([ConhecimentoId], [PerfilId], [Pontos], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (N'38ffdcae-d7d9-4ce3-a548-db4810fac1cc', N'b2d64e27-4490-4847-b44e-2dc2fec97fe9', 0, CAST(N'2017-03-23T10:11:55.360' AS DateTime), NULL, CAST(N'2017-03-23T12:42:38.487' AS DateTime), NULL)
INSERT [dbo].[Condicao] ([ConhecimentoId], [PerfilId], [Pontos], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (N'38ffdcae-d7d9-4ce3-a548-db4810fac1cc', N'24b4a1fe-4f44-417b-b5e6-9f3e4b2a668d', 7, CAST(N'2017-03-23T12:42:53.490' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Condicao] ([ConhecimentoId], [PerfilId], [Pontos], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (N'38ffdcae-d7d9-4ce3-a548-db4810fac1cc', N'7c74ae92-fa93-4492-bd79-a70f91e0d55f', 0, CAST(N'2017-03-23T09:35:10.503' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Condicao] ([ConhecimentoId], [PerfilId], [Pontos], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (N'38ffdcae-d7d9-4ce3-a548-db4810fac1cc', N'7ff25304-b7c9-436d-af6e-e6edd97c85be', 0, CAST(N'2017-03-23T09:30:49.637' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Condicao] ([ConhecimentoId], [PerfilId], [Pontos], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (N'3c6d938d-362e-43c0-a15f-f6ed716a9586', N'b2d64e27-4490-4847-b44e-2dc2fec97fe9', 0, CAST(N'2017-03-23T10:11:55.360' AS DateTime), NULL, CAST(N'2017-03-23T10:12:30.090' AS DateTime), NULL)
INSERT [dbo].[Condicao] ([ConhecimentoId], [PerfilId], [Pontos], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (N'3c6d938d-362e-43c0-a15f-f6ed716a9586', N'24b4a1fe-4f44-417b-b5e6-9f3e4b2a668d', 0, CAST(N'2017-03-23T12:42:53.490' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Condicao] ([ConhecimentoId], [PerfilId], [Pontos], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (N'3c6d938d-362e-43c0-a15f-f6ed716a9586', N'7c74ae92-fa93-4492-bd79-a70f91e0d55f', 0, CAST(N'2017-03-23T09:35:10.503' AS DateTime), NULL, CAST(N'2017-03-23T10:11:32.423' AS DateTime), NULL)
INSERT [dbo].[Condicao] ([ConhecimentoId], [PerfilId], [Pontos], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (N'3c6d938d-362e-43c0-a15f-f6ed716a9586', N'7ff25304-b7c9-436d-af6e-e6edd97c85be', 7, CAST(N'2017-03-23T09:30:49.637' AS DateTime), NULL, NULL, NULL)
