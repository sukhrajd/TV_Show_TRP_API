SET IDENTITY_INSERT [dbo].[TVShow_TRP] ON
INSERT INTO [dbo].[TVShow_TRP] ([Id], [Show_Name], [Channel_Name], [Producer_Name], [Show_TRP]) VALUES (1, N'Man vs Wild', N'Discovery ', N'Stephen Rankin', CAST(8.10 AS Decimal(18, 2)))
INSERT INTO [dbo].[TVShow_TRP] ([Id], [Show_Name], [Channel_Name], [Producer_Name], [Show_TRP]) VALUES (2, N'Game of Thrones ', N'HBO', N'David Benioff', CAST(9.30 AS Decimal(18, 2)))
INSERT INTO [dbo].[TVShow_TRP] ([Id], [Show_Name], [Channel_Name], [Producer_Name], [Show_TRP]) VALUES (3, N'Shortland Street', N'TVNZ', N'Don Reynolds', CAST(4.70 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[TVShow_TRP] OFF
