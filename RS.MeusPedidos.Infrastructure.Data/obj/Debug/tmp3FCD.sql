CREATE TABLE [dbo].[Avaliacao] (
    [Id] [uniqueidentifier] NOT NULL,
    [CandidatoId] [uniqueidentifier] NOT NULL,
    [CreatedOn] [datetime],
    [CreatedBy] [varchar](65),
    [ModifiedOn] [datetime],
    [ModifiedBy] [varchar](65),
    CONSTRAINT [PK_dbo.Avaliacao] PRIMARY KEY ([Id])
)
CREATE TABLE [dbo].[Candidato] (
    [Id] [uniqueidentifier] NOT NULL,
    [Nome] [varchar](65),
    [Email] [varchar](65),
    [Perfil] [varchar](65),
    [CreatedOn] [datetime],
    [CreatedBy] [varchar](65),
    [ModifiedOn] [datetime],
    [ModifiedBy] [varchar](65),
    CONSTRAINT [PK_dbo.Candidato] PRIMARY KEY ([Id])
)
CREATE TABLE [dbo].[Resposta] (
    [AvaliacaoId] [uniqueidentifier] NOT NULL,
    [ConhecimentoId] [uniqueidentifier] NOT NULL,
    [Pontos] [smallint] NOT NULL,
    [CreatedOn] [datetime],
    [CreatedBy] [varchar](65),
    [ModifiedOn] [datetime],
    [ModifiedBy] [varchar](65),
    CONSTRAINT [PK_dbo.Resposta] PRIMARY KEY ([AvaliacaoId], [ConhecimentoId])
)
CREATE TABLE [dbo].[Conhecimento] (
    [Id] [uniqueidentifier] NOT NULL,
    [Nome] [varchar](65),
    [CreatedOn] [datetime],
    [CreatedBy] [varchar](65),
    [ModifiedOn] [datetime],
    [ModifiedBy] [varchar](65),
    CONSTRAINT [PK_dbo.Conhecimento] PRIMARY KEY ([Id])
)
CREATE TABLE [dbo].[Condicao] (
    [ConhecimentoId] [uniqueidentifier] NOT NULL,
    [PerfilId] [uniqueidentifier] NOT NULL,
    [Pontos] [smallint] NOT NULL,
    [CreatedOn] [datetime],
    [CreatedBy] [varchar](65),
    [ModifiedOn] [datetime],
    [ModifiedBy] [varchar](65),
    CONSTRAINT [PK_dbo.Condicao] PRIMARY KEY ([ConhecimentoId], [PerfilId])
)
CREATE TABLE [dbo].[Perfil] (
    [Id] [uniqueidentifier] NOT NULL,
    [Nome] [varchar](65),
    [EmailId] [uniqueidentifier],
    [CreatedOn] [datetime],
    [CreatedBy] [varchar](65),
    [ModifiedOn] [datetime],
    [ModifiedBy] [varchar](65),
    CONSTRAINT [PK_dbo.Perfil] PRIMARY KEY ([Id])
)
CREATE TABLE [dbo].[Email] (
    [Id] [uniqueidentifier] NOT NULL,
    [Identificador] [varchar](65),
    [Assunto] [varchar](65),
    [Conteudo] [varchar](255),
    [CreatedOn] [datetime],
    [CreatedBy] [varchar](65),
    [ModifiedOn] [datetime],
    [ModifiedBy] [varchar](65),
    CONSTRAINT [PK_dbo.Email] PRIMARY KEY ([Id])
)
CREATE INDEX [IX_CandidatoId] ON [dbo].[Avaliacao]([CandidatoId])
CREATE INDEX [IX_AvaliacaoId] ON [dbo].[Resposta]([AvaliacaoId])
CREATE INDEX [IX_ConhecimentoId] ON [dbo].[Resposta]([ConhecimentoId])
CREATE INDEX [IX_ConhecimentoId] ON [dbo].[Condicao]([ConhecimentoId])
CREATE INDEX [IX_PerfilId] ON [dbo].[Condicao]([PerfilId])
CREATE INDEX [IX_EmailId] ON [dbo].[Perfil]([EmailId])
ALTER TABLE [dbo].[Avaliacao] ADD CONSTRAINT [FK_dbo.Avaliacao_dbo.Candidato_CandidatoId] FOREIGN KEY ([CandidatoId]) REFERENCES [dbo].[Candidato] ([Id]) ON DELETE CASCADE
ALTER TABLE [dbo].[Resposta] ADD CONSTRAINT [FK_dbo.Resposta_dbo.Conhecimento_ConhecimentoId] FOREIGN KEY ([ConhecimentoId]) REFERENCES [dbo].[Conhecimento] ([Id]) ON DELETE CASCADE
ALTER TABLE [dbo].[Resposta] ADD CONSTRAINT [FK_dbo.Resposta_dbo.Avaliacao_AvaliacaoId] FOREIGN KEY ([AvaliacaoId]) REFERENCES [dbo].[Avaliacao] ([Id]) ON DELETE CASCADE
ALTER TABLE [dbo].[Condicao] ADD CONSTRAINT [FK_dbo.Condicao_dbo.Conhecimento_ConhecimentoId] FOREIGN KEY ([ConhecimentoId]) REFERENCES [dbo].[Conhecimento] ([Id]) ON DELETE CASCADE
ALTER TABLE [dbo].[Condicao] ADD CONSTRAINT [FK_dbo.Condicao_dbo.Perfil_PerfilId] FOREIGN KEY ([PerfilId]) REFERENCES [dbo].[Perfil] ([Id]) ON DELETE CASCADE
ALTER TABLE [dbo].[Perfil] ADD CONSTRAINT [FK_dbo.Perfil_dbo.Email_EmailId] FOREIGN KEY ([EmailId]) REFERENCES [dbo].[Email] ([Id])
CREATE TABLE [dbo].[__MigrationHistory] (
    [MigrationId] [nvarchar](150) NOT NULL,
    [ContextKey] [nvarchar](300) NOT NULL,
    [Model] [varbinary](max) NOT NULL,
    [ProductVersion] [nvarchar](32) NOT NULL,
    CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY ([MigrationId], [ContextKey])
)
INSERT [dbo].[__MigrationHistory]([MigrationId], [ContextKey], [Model], [ProductVersion])
VALUES (N'201703241808172_AutomaticMigration', N'RS.MeusPedidos.Infrastructure.Data.Migrations.Configuration',  0x1F8B0800000000000400ED5D5B6FEB36127E5FA0FF41D0E322B592142DBA81DD22754E8A609B0BE29C62DF0E18897684EAE28A5490A0D85FB60FFB93F62F2C75E75D946CF99223E42591C8E1909CF93833E24CFEF79FFF4E7F7E0B03EB1526C88FA3997D3639B52D18B9B1E747AB999DE2E5B73FDA3FFFF4CDDFA69FBCF0CDFABD6AF75DD68EF48CD0CC7EC1787DE138C87D81214093D0779318C54B3C71E3D0015EEC9C9F9EFEC3393B73202161135A96357D4C23EC8730FF83FC398F2317AE710A82DBD883012A9F93378B9CAA75074288D6C08533FB7131B985297A809EEFC56872132D13807092BA384DE0E40A6030B97A2604317CC3C8B62E031F1026173058DA1688A218034CA670F119C1054EE268B558930720787A5F43D26E090204CBA95D34CD4D67797A9ECDD2693A56A4DC14E138EC48F0ECBB72D91CBE7BAFC5B7EB65250BFB896C007ECF669D2FEECCBE7C0564A95C10DB163FDAC53C48B296C2E25F91567E34A9BB9E58D20627B5E010F9CA7E4EAC791A64FB358B608A13109C580FE973E0BBFF84EF4FF11F309A456910D0FC128EC93BE60179F490C46B98E0F747B82C6771E3D996C3F673F88E7537AA4F31BD5F539FFC7E47C606CF01ACA5C1D1769F83884C16E078533A0904187AF7514585C8327C225A62D8F197F7AA23116CA2BEB6750BDE7E83D10ABFCCEC1FBEB7AD6BFF0D7AD58392A5CF914F949DF4211AD43A10514E7FE9F761B1EA39008F77E0D55FE562AADA17DB7A8441DE02BDF8EB020B1A99FD42B5BB4EE2F0310E686D685E7F59C469E212069E62759B2790AC203667F291C05A8C3058649DB46C322D658C520D34ACD2AD64CC4E9D0619B478412D5B57BCA8BB7E9578711767FA32ACA67E22CB180C3DC8034C96C38F32C2E27661B1868276C83146C60A4874C85841522FB0A950AB3BD6543DF70F35F5A28898236D4F6CD817E812298AB0A44B3B4C31E36D6297707C6C40EA8198E531AA48DC44F8EC87D14C3A143CD8A6FDA106049995626CD1519228E5B622FE856DD9702B6D20584BF2569B594B0C439D0D26AAF7FE81EC83DA4C23B06CD9FF8AC9D1AFB133AAF74A65953610A045DEAA2BB4B4F9613D918567568F3F7D91259F7F2F54C97BEE1F51F4A68EB44BE17CF481A26DDA333513A351F4D1B04B6F69F4042FDED2D0439C29B79523AEE3B36A23E1B078A5E6AD7CBF91FD530DDF15A38A7EFB47A80F6AF3E471229ECF116A0ED24C6AD760A569C469B8296B651451C25449B06CD070443F17008579B9119A94E3760593BCDB578925371E39588868BBC08B93A1F5EF12A1343F0D07F6D7B26FBCA9A71BE7FCFBD1313C3CC42B7040857746D0C2239D14774CA085C86AECFA390F7C3C8C0A7FB313FB147996C157C2623599201A59558229FE9AA008E16566FF5D58343DED7ADA0D6D2A46CFD23EB37924BA8FAE600031B42EDDE20AC21C200208E2CE91B5F2D82704BC609241080888DA2102877E8445A4F323D75F83A07D065C574398CC58AB07E1DF5CC1358C32986BDF1B93D199AFFA221BF568DCCAB52DD4D4A1244E2F88721743252E2DFE06253075BCC05C165B22310C71CA1B3A3481D44E630722A9DD2323A16C8B93EC422E198056498CDC106C04A53266CD65508EFF0DC5F2C060099E4E266702CD5EB2231B7E0722235B4793616BC76EBFD0556E732BAEF021882DC115EF17B5C9DF014114CBFA2EC189DD0B939155B1D81D499B3C36AF128E964F808D8834770ECC25AFE52BC0B11C94DA69EC4016B57B743407A5FCDB79BBBD2FBDC867E04D6C556EDA1893C8B4B9C26CE84E481668A70E85641D4CC6D75F00DABE44161E6F1626213D605279FC4DE8ABBC252F09A47D46B08CA5A1D2BBE7A523234DE6CF4F0DD956E3688B022B00274BA676BAA08C0EE5EAB6D0A9364846A591D23666280C91F3C360783BB5FC7855102A6D9C1622C5412B2351D9332D0472B350D6BFB49EB9EE946049F69ABE1F48B5D45C23E465DE2C92524F8295334183CC6227143546DC784464E76EB02E8A4F82E2CA1838F61D5C7B7A3E8D8C691647EFCCB3E41805D87885D8D09EB8306ACFB2DDB7A4F8AEB544B308526F92A25129CAF6A4A2D2508D3CC8BC25237FA9BF0C701E52FB2AF65802C5DD1971210C0CF90EA63C3517EA3CD02C8ADE781F523114B72C75A0AA34293B18959B00ABCC16345971CDEA5431FADA62A9DF4D9D220FB07C3075140983D35BB05EFBD18A4A202C9F588B227B70FEEDA27BEE5C58D0705C2449A1ABB9AD47C2710256907B9B498D07AFFD04E12C47F119641F50E65E283493D8678A33BD1A5030C1C4FDAB4EFBAA4BF67BA99C5DD22929534E34784BDAD764F29966E4EB00652226F6B5B2444F108044F2D5731E076918A92D78756F26844F93D1C6F635F49AEF800CB5E671675AD9673709ADECB1392DFAEB1F4D8C7EDE9D1ACF1AFD5CA43675B8ED17DC1B4108050F94156B23A1A72DB8E1A45E69C01A48BDA6EF30525F5C1BA2FB174FCC2994F6194D42EA1EE86854D60E4D44EEA3E8A88C1A77701AD71CECC3E95BEDA27757377557D5EA3351197AF9B5E11A8D9C71A14746D85AC2926AAAD52561469FCA67A33E1DB13E71BEC4808798C6A73239C7B4DD0FF5281B05FE1005BE0C500C2AEB4540B5979C2BBAEE18F0EB6FAAA209351E1DA326515F0386D3237940D2408B541D0FF59CA8AFCB084ECF182238722D2923F9C32989F47385818E28FA0DA3225C02004B8879654EB3BEE7CF784DD5C34E1E5379919F3B3ACBA7A3FA1DBCFA09A17BBE493D7A1DC2E742F5D3326CDE5E005088A3174D6C8B2CD3ABEF6531F4C53BC2302C3475F167300F7C32DFA6C12D88FC2544B848E3B1CF4FCFCEB942818753B4CF41C80B249F1DA495FBD80DDB4132521AF97FA6D02F110426DB289E27D214AEA7DC441E7C9BD97FE5442EAC9B7F7DA1E89C58F709D9E40BEBD4FAF7E689D48426C479224D43A943D2509357F30A12F7052442624D37B262A64F5F06C5CC9F3E1CF62817777C424A67E26E671B99FA6CDB215945D7B74973D48681B4411EA63E9A3A62BD209AA2B319444BEB77F43B3518521B71C556F1402108023FB339C6F3E730344E931BF0751E41A3A40D27699208F2D11442DA3B907235957AF153111921FD032B9A34B9F0EB0473AE8E4F2F9D2969A854663C53F628EAB264EB63907469DD99EDEC255765664B461157534646352F2A33EAC53EF462B36A2D54BAD2CE0BA848AED0F72D11D32FAF5C738575B84CC98F5A6985CA62D9474EB798C7D3B36442DF1205BA8B64831526389EC4EF07930A29ECBFE8E856C184CF63EB555AA5D7E6AB3E760F54F8E403D53A31DEA90F04151D36719720A1BE457780F54A0EE9B86972E77757F661D7C78D26F9E0408F9B9E7546F65A54641F92D4CD2CDDA5181D466510314195DF3D45D10F7DCD8FE27A0E71299F33912B5CBE1E2541F40541648374AF17A22D17221BA2573191D65222D2C9F42936A2AD35A218A54B25124D211219F5076902A0BC4889BA46898CF2BECB970852CAE57E8A4A2D0564AAAF5A430EAB328920D562B6906EF2BCA4B239189B4F9D71C5FA971C614492BABDAB9B1AAB22F4B5F82DEE68457193AA22C68CEE74E706AB1AB2B9D0F2C7059B79BAF9D4872F07620635834CBA43950FF14A30B179A8FF1C4E8C2EE4AF1A12D9FF118FA0CB583B759B9B6819579617C751D5848F65430C087A83CB04FB4BE062F2DA8508E5D5D17F07419AE3C233F46EA2FB14AF534CA60CC3E780B97D9D196FBAF1F352262CCFD3FB755E127D1B53206C660710BC8F7E49FDC0ABF9BE163FDEA8486456E1AF903C2FF692189918AEDE6B4A77716448A85CBEDA987D82E13A20C4D07DB400AFB00F6F9F11FC0DAE80FB5EDDEC561369DF0876D9A7573E58252044258DA63FF993C8B017BEFDF47F505CD819407F0000 , N'6.1.3-40302')

