
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 01/15/2013 18:27:26
-- Generated from EDMX file: c:\users\zodiac\documents\visual studio 2012\Projects\CDCatalog\CDCatalog\CDCatalog.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [CDCatalog];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Album_Artist]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Album] DROP CONSTRAINT [FK_Album_Artist];
GO
IF OBJECT_ID(N'[dbo].[FK_Song_Album]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Song] DROP CONSTRAINT [FK_Song_Album];
GO
IF OBJECT_ID(N'[dbo].[FK_Song_Artist]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Song] DROP CONSTRAINT [FK_Song_Artist];
GO
IF OBJECT_ID(N'[dbo].[FK_Song_Genre]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Song] DROP CONSTRAINT [FK_Song_Genre];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Album]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Album];
GO
IF OBJECT_ID(N'[dbo].[Artist]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Artist];
GO
IF OBJECT_ID(N'[dbo].[Genre]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Genre];
GO
IF OBJECT_ID(N'[dbo].[Song]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Song];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Albums'
CREATE TABLE [dbo].[Albums] (
    [AlbumID] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(50)  NOT NULL,
    [Year] int  NOT NULL,
    [ArtistID] int  NOT NULL
);
GO

-- Creating table 'Artists'
CREATE TABLE [dbo].[Artists] (
    [ArtistID] int IDENTITY(1,1) NOT NULL,
    [Artist1] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Songs'
CREATE TABLE [dbo].[Songs] (
    [SongID] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(50)  NOT NULL,
    [ArtistID] int  NOT NULL,
    [AlbumID] int  NULL,
    [TrackNumber] nvarchar(50)  NULL,
    [Genre] int  NOT NULL,
    [TrackLength] int  NOT NULL,
    [Rating] int  NOT NULL,
    [GenreID] int  NOT NULL
);
GO

-- Creating table 'Genres'
CREATE TABLE [dbo].[Genres] (
    [GenreID] int IDENTITY(1,1) NOT NULL,
    [Genre1] nvarchar(50)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [AlbumID] in table 'Albums'
ALTER TABLE [dbo].[Albums]
ADD CONSTRAINT [PK_Albums]
    PRIMARY KEY CLUSTERED ([AlbumID] ASC);
GO

-- Creating primary key on [ArtistID] in table 'Artists'
ALTER TABLE [dbo].[Artists]
ADD CONSTRAINT [PK_Artists]
    PRIMARY KEY CLUSTERED ([ArtistID] ASC);
GO

-- Creating primary key on [SongID] in table 'Songs'
ALTER TABLE [dbo].[Songs]
ADD CONSTRAINT [PK_Songs]
    PRIMARY KEY CLUSTERED ([SongID] ASC);
GO

-- Creating primary key on [GenreID] in table 'Genres'
ALTER TABLE [dbo].[Genres]
ADD CONSTRAINT [PK_Genres]
    PRIMARY KEY CLUSTERED ([GenreID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ArtistID] in table 'Albums'
ALTER TABLE [dbo].[Albums]
ADD CONSTRAINT [FK_Album_Artist]
    FOREIGN KEY ([ArtistID])
    REFERENCES [dbo].[Artists]
        ([ArtistID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Album_Artist'
CREATE INDEX [IX_FK_Album_Artist]
ON [dbo].[Albums]
    ([ArtistID]);
GO

-- Creating foreign key on [AlbumID] in table 'Songs'
ALTER TABLE [dbo].[Songs]
ADD CONSTRAINT [FK_Song_Album]
    FOREIGN KEY ([AlbumID])
    REFERENCES [dbo].[Albums]
        ([AlbumID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Song_Album'
CREATE INDEX [IX_FK_Song_Album]
ON [dbo].[Songs]
    ([AlbumID]);
GO

-- Creating foreign key on [ArtistID] in table 'Songs'
ALTER TABLE [dbo].[Songs]
ADD CONSTRAINT [FK_Song_Artist]
    FOREIGN KEY ([ArtistID])
    REFERENCES [dbo].[Artists]
        ([ArtistID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Song_Artist'
CREATE INDEX [IX_FK_Song_Artist]
ON [dbo].[Songs]
    ([ArtistID]);
GO

-- Creating foreign key on [GenreID] in table 'Songs'
ALTER TABLE [dbo].[Songs]
ADD CONSTRAINT [FK_Song_Genre]
    FOREIGN KEY ([GenreID])
    REFERENCES [dbo].[Genres]
        ([GenreID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Song_Genre'
CREATE INDEX [IX_FK_Song_Genre]
ON [dbo].[Songs]
    ([GenreID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------