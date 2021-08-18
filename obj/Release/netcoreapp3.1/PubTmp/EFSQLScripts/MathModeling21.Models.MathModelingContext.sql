IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210622031209_Initial')
BEGIN
    CREATE TABLE [Articles] (
        [Id] int NOT NULL IDENTITY,
        [Title] nvarchar(max) NULL,
        [Body] nvarchar(max) NULL,
        [PostDate] datetime2 NOT NULL,
        [ImagesStr] nvarchar(max) NULL,
        CONSTRAINT [PK_Articles] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210622031209_Initial')
BEGIN
    CREATE TABLE [Events] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Body] nvarchar(max) NULL,
        [Date] datetime2 NOT NULL,
        [Image] nvarchar(max) NULL,
        CONSTRAINT [PK_Events] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210622031209_Initial')
BEGIN
    CREATE TABLE [Faq] (
        [Id] int NOT NULL IDENTITY,
        [Question] nvarchar(max) NULL,
        [Answer] nvarchar(max) NULL,
        CONSTRAINT [PK_Faq] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210622031209_Initial')
BEGIN
    CREATE TABLE [Media] (
        [Id] int NOT NULL IDENTITY,
        [Image] nvarchar(max) NULL,
        [Year] int NOT NULL,
        CONSTRAINT [PK_Media] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210622031209_Initial')
BEGIN
    CREATE TABLE [Members] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Role] nvarchar(max) NULL,
        [Gif] nvarchar(max) NULL,
        [FacebookUrl] nvarchar(max) NULL,
        [InstagramUrl] nvarchar(max) NULL,
        [LinkedInUrl] nvarchar(max) NULL,
        CONSTRAINT [PK_Members] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210622031209_Initial')
BEGIN
    CREATE TABLE [Messages] (
        [Id] int NOT NULL IDENTITY,
        [FullName] nvarchar(max) NULL,
        [PhoneNumber] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        [Body] nvarchar(max) NULL,
        [PostDate] datetime2 NOT NULL,
        CONSTRAINT [PK_Messages] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210622031209_Initial')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Body', N'ImagesStr', N'PostDate', N'Title') AND [object_id] = OBJECT_ID(N'[Articles]'))
        SET IDENTITY_INSERT [Articles] ON;
    INSERT INTO [Articles] ([Id], [Body], [ImagesStr], [PostDate], [Title])
    VALUES (1, N'This page shares my best articles to read on topics like health, happiness, creativity, productivity and more. The central question that drives my work is, “How can we live better?” To answer that question, I like to write about science-based ways to solve practical problems.
    You’ll find interesting articles to read on topics like how to stop procrastinating as well as personal recommendations like my list of the best books to read and my minimalist travel guide.Ready to dive in? You can use the categories below to browse my best articles.', N'asffsfssfshoian-26.jpg,feffsfsf3434vietnam-travel.jpg', '2021-06-22T10:12:09.2469151+07:00', N'Sample Article');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Body', N'ImagesStr', N'PostDate', N'Title') AND [object_id] = OBJECT_ID(N'[Articles]'))
        SET IDENTITY_INSERT [Articles] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210622031209_Initial')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Body', N'Date', N'Image', N'Name') AND [object_id] = OBJECT_ID(N'[Events]'))
        SET IDENTITY_INSERT [Events] ON;
    INSERT INTO [Events] ([Id], [Body], [Date], [Image], [Name])
    VALUES (1, N'This Info Session covers fundamental knowledge about math modeling. This Info Session covers fundamental knowledge about math modeling.', '2021-07-23T00:00:00.0000000', N'asffsfssfshoian-26.jpg', N'Sample Event');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Body', N'Date', N'Image', N'Name') AND [object_id] = OBJECT_ID(N'[Events]'))
        SET IDENTITY_INSERT [Events] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210622031209_Initial')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Answer', N'Question') AND [object_id] = OBJECT_ID(N'[Faq]'))
        SET IDENTITY_INSERT [Faq] ON;
    INSERT INTO [Faq] ([Id], [Answer], [Question])
    VALUES (1, N'Xin lỗi bạn. Đối tượng tham gia là học sinh cấp ba.', N'Mình là sinh viên năm nhất. Mình có thể tham gia cuộc thi không?');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Answer', N'Question') AND [object_id] = OBJECT_ID(N'[Faq]'))
        SET IDENTITY_INSERT [Faq] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210622031209_Initial')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Image', N'Year') AND [object_id] = OBJECT_ID(N'[Media]'))
        SET IDENTITY_INSERT [Media] ON;
    INSERT INTO [Media] ([Id], [Image], [Year])
    VALUES (1, N'feffsfsf3434vietnam-travel.jpg', 2018);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Image', N'Year') AND [object_id] = OBJECT_ID(N'[Media]'))
        SET IDENTITY_INSERT [Media] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210622031209_Initial')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'FacebookUrl', N'Gif', N'InstagramUrl', N'LinkedInUrl', N'Name', N'Role') AND [object_id] = OBJECT_ID(N'[Members]'))
        SET IDENTITY_INSERT [Members] ON;
    INSERT INTO [Members] ([Id], [FacebookUrl], [Gif], [InstagramUrl], [LinkedInUrl], [Name], [Role])
    VALUES (1, N'https://www.facebook.com/hai.nguyenngoc.129794', N'', N'', N'', N'Nguyễn Ngọc Hải', N'Trưởng Ban Tổ Chức');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'FacebookUrl', N'Gif', N'InstagramUrl', N'LinkedInUrl', N'Name', N'Role') AND [object_id] = OBJECT_ID(N'[Members]'))
        SET IDENTITY_INSERT [Members] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210622031209_Initial')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Body', N'Email', N'FullName', N'PhoneNumber', N'PostDate') AND [object_id] = OBJECT_ID(N'[Messages]'))
        SET IDENTITY_INSERT [Messages] ON;
    INSERT INTO [Messages] ([Id], [Body], [Email], [FullName], [PhoneNumber], [PostDate])
    VALUES (1, N'Mong admin facebook rep tin nhắn em sớm ạ. Em cảm ơn.', N'levinguyen@email.co', N'Levi Nguyen', N'0379111111', '2021-06-22T10:12:09.2496407+07:00');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Body', N'Email', N'FullName', N'PhoneNumber', N'PostDate') AND [object_id] = OBJECT_ID(N'[Messages]'))
        SET IDENTITY_INSERT [Messages] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210622031209_Initial')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210622031209_Initial', N'3.1.15');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210622044003_FixEvent')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Events]') AND [c].[name] = N'Date');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Events] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [Events] DROP COLUMN [Date];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210622044003_FixEvent')
BEGIN
    ALTER TABLE [Events] ADD [DateEnd] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210622044003_FixEvent')
BEGIN
    ALTER TABLE [Events] ADD [DateStart] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210622044003_FixEvent')
BEGIN
    UPDATE [Articles] SET [PostDate] = '2021-06-22T11:40:03.1358228+07:00'
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210622044003_FixEvent')
BEGIN
    UPDATE [Events] SET [DateEnd] = '2021-07-25T00:00:00.0000000', [DateStart] = '2021-07-23T00:00:00.0000000'
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210622044003_FixEvent')
BEGIN
    UPDATE [Messages] SET [PostDate] = '2021-06-22T11:40:03.1387669+07:00'
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210622044003_FixEvent')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210622044003_FixEvent', N'3.1.15');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210706091931_MemberAddImageField')
BEGIN
    ALTER TABLE [Members] ADD [Image] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210706091931_MemberAddImageField')
BEGIN
    UPDATE [Articles] SET [PostDate] = '2021-07-06T16:19:31.0897006+07:00'
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210706091931_MemberAddImageField')
BEGIN
    UPDATE [Members] SET [Image] = N''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210706091931_MemberAddImageField')
BEGIN
    UPDATE [Messages] SET [PostDate] = '2021-07-06T16:19:31.0923432+07:00'
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210706091931_MemberAddImageField')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210706091931_MemberAddImageField', N'3.1.15');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210707083530_MessageAddReviewStatus')
BEGIN
    ALTER TABLE [Messages] ADD [ReviewStatus] bit NOT NULL DEFAULT CAST(0 AS bit);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210707083530_MessageAddReviewStatus')
BEGIN
    UPDATE [Articles] SET [PostDate] = '2021-07-07T15:35:30.5062229+07:00'
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210707083530_MessageAddReviewStatus')
BEGIN
    UPDATE [Messages] SET [PostDate] = '2021-07-07T15:35:30.5088231+07:00'
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210707083530_MessageAddReviewStatus')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210707083530_MessageAddReviewStatus', N'3.1.15');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210711071253_AddIdentityTable')
BEGIN
    CREATE TABLE [AspNetRoles] (
        [Id] nvarchar(450) NOT NULL,
        [Name] nvarchar(256) NULL,
        [NormalizedName] nvarchar(256) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210711071253_AddIdentityTable')
BEGIN
    CREATE TABLE [AspNetUsers] (
        [Id] nvarchar(450) NOT NULL,
        [UserName] nvarchar(256) NULL,
        [NormalizedUserName] nvarchar(256) NULL,
        [Email] nvarchar(256) NULL,
        [NormalizedEmail] nvarchar(256) NULL,
        [EmailConfirmed] bit NOT NULL,
        [PasswordHash] nvarchar(max) NULL,
        [SecurityStamp] nvarchar(max) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        [PhoneNumber] nvarchar(max) NULL,
        [PhoneNumberConfirmed] bit NOT NULL,
        [TwoFactorEnabled] bit NOT NULL,
        [LockoutEnd] datetimeoffset NULL,
        [LockoutEnabled] bit NOT NULL,
        [AccessFailedCount] int NOT NULL,
        CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210711071253_AddIdentityTable')
BEGIN
    CREATE TABLE [AspNetRoleClaims] (
        [Id] int NOT NULL IDENTITY,
        [RoleId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210711071253_AddIdentityTable')
BEGIN
    CREATE TABLE [AspNetUserClaims] (
        [Id] int NOT NULL IDENTITY,
        [UserId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210711071253_AddIdentityTable')
BEGIN
    CREATE TABLE [AspNetUserLogins] (
        [LoginProvider] nvarchar(450) NOT NULL,
        [ProviderKey] nvarchar(450) NOT NULL,
        [ProviderDisplayName] nvarchar(max) NULL,
        [UserId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
        CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210711071253_AddIdentityTable')
BEGIN
    CREATE TABLE [AspNetUserRoles] (
        [UserId] nvarchar(450) NOT NULL,
        [RoleId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
        CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210711071253_AddIdentityTable')
BEGIN
    CREATE TABLE [AspNetUserTokens] (
        [UserId] nvarchar(450) NOT NULL,
        [LoginProvider] nvarchar(450) NOT NULL,
        [Name] nvarchar(450) NOT NULL,
        [Value] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
        CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210711071253_AddIdentityTable')
BEGIN
    UPDATE [Articles] SET [PostDate] = '2021-07-11T14:12:53.5024689+07:00'
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210711071253_AddIdentityTable')
BEGIN
    UPDATE [Messages] SET [PostDate] = '2021-07-11T14:12:53.5050523+07:00'
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210711071253_AddIdentityTable')
BEGIN
    CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210711071253_AddIdentityTable')
BEGIN
    CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210711071253_AddIdentityTable')
BEGIN
    CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210711071253_AddIdentityTable')
BEGIN
    CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210711071253_AddIdentityTable')
BEGIN
    CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210711071253_AddIdentityTable')
BEGIN
    CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210711071253_AddIdentityTable')
BEGIN
    CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210711071253_AddIdentityTable')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210711071253_AddIdentityTable', N'3.1.15');
END;

GO

