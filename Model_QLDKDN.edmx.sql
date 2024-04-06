
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/06/2024 14:14:28
-- Generated from EDMX file: D:\Visual Studio App\QuanLyDangKyDoanhNghiep\Model_QLDKDN.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [tuanpa2_QuanLyDangKyDoanhNghiep];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_dan_toc_quoc_tich]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[dan_toc] DROP CONSTRAINT [FK_dan_toc_quoc_tich];
GO
IF OBJECT_ID(N'[dbo].[FK_external_account_dan_toc]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[external_account] DROP CONSTRAINT [FK_external_account_dan_toc];
GO
IF OBJECT_ID(N'[dbo].[FK_doanh_nghiep_external_account]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[doanh_nghiep] DROP CONSTRAINT [FK_doanh_nghiep_external_account];
GO
IF OBJECT_ID(N'[dbo].[FK_doanh_nghiep_internal_account]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[doanh_nghiep] DROP CONSTRAINT [FK_doanh_nghiep_internal_account];
GO
IF OBJECT_ID(N'[dbo].[FK_doanh_nghiep_nganh_nghe]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[doanh_nghiep] DROP CONSTRAINT [FK_doanh_nghiep_nganh_nghe];
GO
IF OBJECT_ID(N'[dbo].[FK_DoanhNghiep_loai_hinh]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[doanh_nghiep] DROP CONSTRAINT [FK_DoanhNghiep_loai_hinh];
GO
IF OBJECT_ID(N'[dbo].[FK_external_account_quoc_tich]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[external_account] DROP CONSTRAINT [FK_external_account_quoc_tich];
GO
IF OBJECT_ID(N'[dbo].[FK_internal_account_nhan_vien]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[internal_account] DROP CONSTRAINT [FK_internal_account_nhan_vien];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[dan_toc]', 'U') IS NOT NULL
    DROP TABLE [dbo].[dan_toc];
GO
IF OBJECT_ID(N'[dbo].[doanh_nghiep]', 'U') IS NOT NULL
    DROP TABLE [dbo].[doanh_nghiep];
GO
IF OBJECT_ID(N'[dbo].[external_account]', 'U') IS NOT NULL
    DROP TABLE [dbo].[external_account];
GO
IF OBJECT_ID(N'[dbo].[internal_account]', 'U') IS NOT NULL
    DROP TABLE [dbo].[internal_account];
GO
IF OBJECT_ID(N'[dbo].[loai_hinh]', 'U') IS NOT NULL
    DROP TABLE [dbo].[loai_hinh];
GO
IF OBJECT_ID(N'[dbo].[nganh_nghe]', 'U') IS NOT NULL
    DROP TABLE [dbo].[nganh_nghe];
GO
IF OBJECT_ID(N'[dbo].[nhan_vien]', 'U') IS NOT NULL
    DROP TABLE [dbo].[nhan_vien];
GO
IF OBJECT_ID(N'[dbo].[quoc_tich]', 'U') IS NOT NULL
    DROP TABLE [dbo].[quoc_tich];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'dan_toc'
CREATE TABLE [dbo].[dan_toc] (
    [id] int IDENTITY(1,1) NOT NULL,
    [ten_dan_toc] nvarchar(50)  NOT NULL,
    [id_quoc_tich] int  NOT NULL
);
GO

-- Creating table 'doanh_nghiep'
CREATE TABLE [dbo].[doanh_nghiep] (
    [id] int IDENTITY(1,1) NOT NULL,
    [ten] nvarchar(200)  NOT NULL,
    [loai_hinh_id] int  NOT NULL,
    [nganh_nghe_id] int  NOT NULL,
    [dia_chi] nvarchar(500)  NOT NULL,
    [so_dien_thoai] nvarchar(50)  NOT NULL,
    [email_doanh_nghiep] nvarchar(50)  NOT NULL,
    [external_account_id] int  NOT NULL,
    [is_approved] bit  NOT NULL,
    [approved_by] int  NULL,
    [approved_time] datetime  NULL
);
GO

-- Creating table 'external_account'
CREATE TABLE [dbo].[external_account] (
    [id] int IDENTITY(1,1) NOT NULL,
    [email] nvarchar(200)  NOT NULL,
    [password] nvarchar(200)  NOT NULL,
    [ho_ten] nvarchar(200)  NOT NULL,
    [gioi_tinh] smallint  NULL,
    [ngay_sinh] datetime  NOT NULL,
    [id_quoc_tich] int  NULL,
    [id_dan_toc] int  NULL,
    [so_dien_thoai] nvarchar(50)  NOT NULL,
    [so_fax] nvarchar(50)  NULL,
    [web_site] nvarchar(200)  NULL,
    [create_time] datetime  NOT NULL,
    [is_locked] bit  NOT NULL
);
GO

-- Creating table 'internal_account'
CREATE TABLE [dbo].[internal_account] (
    [id] int  NOT NULL,
    [username] nvarchar(50)  NOT NULL,
    [password] nvarchar(200)  NOT NULL,
    [create_time] datetime  NOT NULL,
    [is_locked] bit  NOT NULL,
    [id_nhan_vien] int  NOT NULL
);
GO

-- Creating table 'loai_hinh'
CREATE TABLE [dbo].[loai_hinh] (
    [id] int IDENTITY(1,1) NOT NULL,
    [ten_loai_hinh] nvarchar(200)  NOT NULL
);
GO

-- Creating table 'nganh_nghe'
CREATE TABLE [dbo].[nganh_nghe] (
    [id] int IDENTITY(1,1) NOT NULL,
    [ten_nganh_nghe] nvarchar(500)  NOT NULL
);
GO

-- Creating table 'nhan_vien'
CREATE TABLE [dbo].[nhan_vien] (
    [id] int IDENTITY(1,1) NOT NULL,
    [ho_ten] nvarchar(200)  NOT NULL,
    [gioi_tinh] bit  NOT NULL,
    [ngay_sinh] datetime  NOT NULL,
    [so_cccd] nvarchar(50)  NOT NULL,
    [ngay_cap] datetime  NOT NULL,
    [noi_cap] nvarchar(500)  NOT NULL
);
GO

-- Creating table 'quoc_tich'
CREATE TABLE [dbo].[quoc_tich] (
    [id] int IDENTITY(1,1) NOT NULL,
    [ten_quoc_tich] nvarchar(200)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'dan_toc'
ALTER TABLE [dbo].[dan_toc]
ADD CONSTRAINT [PK_dan_toc]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'doanh_nghiep'
ALTER TABLE [dbo].[doanh_nghiep]
ADD CONSTRAINT [PK_doanh_nghiep]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'external_account'
ALTER TABLE [dbo].[external_account]
ADD CONSTRAINT [PK_external_account]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'internal_account'
ALTER TABLE [dbo].[internal_account]
ADD CONSTRAINT [PK_internal_account]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'loai_hinh'
ALTER TABLE [dbo].[loai_hinh]
ADD CONSTRAINT [PK_loai_hinh]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'nganh_nghe'
ALTER TABLE [dbo].[nganh_nghe]
ADD CONSTRAINT [PK_nganh_nghe]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'nhan_vien'
ALTER TABLE [dbo].[nhan_vien]
ADD CONSTRAINT [PK_nhan_vien]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'quoc_tich'
ALTER TABLE [dbo].[quoc_tich]
ADD CONSTRAINT [PK_quoc_tich]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [id_quoc_tich] in table 'dan_toc'
ALTER TABLE [dbo].[dan_toc]
ADD CONSTRAINT [FK_dan_toc_quoc_tich]
    FOREIGN KEY ([id_quoc_tich])
    REFERENCES [dbo].[quoc_tich]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dan_toc_quoc_tich'
CREATE INDEX [IX_FK_dan_toc_quoc_tich]
ON [dbo].[dan_toc]
    ([id_quoc_tich]);
GO

-- Creating foreign key on [id_dan_toc] in table 'external_account'
ALTER TABLE [dbo].[external_account]
ADD CONSTRAINT [FK_external_account_dan_toc]
    FOREIGN KEY ([id_dan_toc])
    REFERENCES [dbo].[dan_toc]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_external_account_dan_toc'
CREATE INDEX [IX_FK_external_account_dan_toc]
ON [dbo].[external_account]
    ([id_dan_toc]);
GO

-- Creating foreign key on [external_account_id] in table 'doanh_nghiep'
ALTER TABLE [dbo].[doanh_nghiep]
ADD CONSTRAINT [FK_doanh_nghiep_external_account]
    FOREIGN KEY ([external_account_id])
    REFERENCES [dbo].[external_account]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_doanh_nghiep_external_account'
CREATE INDEX [IX_FK_doanh_nghiep_external_account]
ON [dbo].[doanh_nghiep]
    ([external_account_id]);
GO

-- Creating foreign key on [approved_by] in table 'doanh_nghiep'
ALTER TABLE [dbo].[doanh_nghiep]
ADD CONSTRAINT [FK_doanh_nghiep_internal_account]
    FOREIGN KEY ([approved_by])
    REFERENCES [dbo].[internal_account]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_doanh_nghiep_internal_account'
CREATE INDEX [IX_FK_doanh_nghiep_internal_account]
ON [dbo].[doanh_nghiep]
    ([approved_by]);
GO

-- Creating foreign key on [nganh_nghe_id] in table 'doanh_nghiep'
ALTER TABLE [dbo].[doanh_nghiep]
ADD CONSTRAINT [FK_doanh_nghiep_nganh_nghe]
    FOREIGN KEY ([nganh_nghe_id])
    REFERENCES [dbo].[nganh_nghe]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_doanh_nghiep_nganh_nghe'
CREATE INDEX [IX_FK_doanh_nghiep_nganh_nghe]
ON [dbo].[doanh_nghiep]
    ([nganh_nghe_id]);
GO

-- Creating foreign key on [loai_hinh_id] in table 'doanh_nghiep'
ALTER TABLE [dbo].[doanh_nghiep]
ADD CONSTRAINT [FK_DoanhNghiep_loai_hinh]
    FOREIGN KEY ([loai_hinh_id])
    REFERENCES [dbo].[loai_hinh]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DoanhNghiep_loai_hinh'
CREATE INDEX [IX_FK_DoanhNghiep_loai_hinh]
ON [dbo].[doanh_nghiep]
    ([loai_hinh_id]);
GO

-- Creating foreign key on [id_quoc_tich] in table 'external_account'
ALTER TABLE [dbo].[external_account]
ADD CONSTRAINT [FK_external_account_quoc_tich]
    FOREIGN KEY ([id_quoc_tich])
    REFERENCES [dbo].[quoc_tich]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_external_account_quoc_tich'
CREATE INDEX [IX_FK_external_account_quoc_tich]
ON [dbo].[external_account]
    ([id_quoc_tich]);
GO

-- Creating foreign key on [id_nhan_vien] in table 'internal_account'
ALTER TABLE [dbo].[internal_account]
ADD CONSTRAINT [FK_internal_account_nhan_vien]
    FOREIGN KEY ([id_nhan_vien])
    REFERENCES [dbo].[nhan_vien]
        ([id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_internal_account_nhan_vien'
CREATE INDEX [IX_FK_internal_account_nhan_vien]
ON [dbo].[internal_account]
    ([id_nhan_vien]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------