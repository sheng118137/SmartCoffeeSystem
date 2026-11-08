-- =============================================================================
-- SmartCoffeeSystem - CoffeeShop 資料庫初始化與測試資料腳本
-- 使用方式：在 SQL Server Management Studio (SSMS) 開啟此檔案並按 F5 執行即可
-- =============================================================================
USE [master];
GO
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'CoffeeShop')
BEGIN
    CREATE DATABASE [CoffeeShop];
END
GO
USE [CoffeeShop];
GO

IF OBJECT_ID('dbo.OrderDetails', 'U') IS NOT NULL DROP TABLE dbo.OrderDetails;
IF OBJECT_ID('dbo.Orders', 'U') IS NOT NULL DROP TABLE dbo.Orders;
IF OBJECT_ID('dbo.ProductOptionMapping', 'U') IS NOT NULL DROP TABLE dbo.ProductOptionMapping;
IF OBJECT_ID('dbo.ProductOptionItems', 'U') IS NOT NULL DROP TABLE dbo.ProductOptionItems;
IF OBJECT_ID('dbo.ProductOptionGroups', 'U') IS NOT NULL DROP TABLE dbo.ProductOptionGroups;
IF OBJECT_ID('dbo.Products', 'U') IS NOT NULL DROP TABLE dbo.Products;
IF OBJECT_ID('dbo.Categories', 'U') IS NOT NULL DROP TABLE dbo.Categories;
IF OBJECT_ID('dbo.Members', 'U') IS NOT NULL DROP TABLE dbo.Members;
IF OBJECT_ID('dbo.MemberLevels', 'U') IS NOT NULL DROP TABLE dbo.MemberLevels;
IF OBJECT_ID('dbo.EmployeePermissions', 'U') IS NOT NULL DROP TABLE dbo.EmployeePermissions;
IF OBJECT_ID('dbo.Account', 'U') IS NOT NULL DROP TABLE dbo.Account;
IF OBJECT_ID('dbo.Employees', 'U') IS NOT NULL DROP TABLE dbo.Employees;
IF OBJECT_ID('dbo.LoginLog', 'U') IS NOT NULL DROP TABLE dbo.LoginLog;
GO

CREATE TABLE [dbo].[Categories] (
    [CategoryID] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [CategoryName] NVARCHAR(20) NOT NULL,
    [IconName] VARCHAR(30) NULL,
    [SortOrder] INT NULL
);

CREATE TABLE [dbo].[Employees] (
    [EmployeeId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [EmployeeName] NVARCHAR(50) NULL,
    [EmployeeTitle] NVARCHAR(30) NULL,
    [Email] VARCHAR(50) NULL,
    [EmployeeStatus] TINYINT NULL,
    [EmployeePhone] VARCHAR(15) NULL,
    [EmployeeAddress] NVARCHAR(50) NULL,
    [CreateTime] DATETIME NULL DEFAULT (GETDATE())
);

CREATE TABLE [dbo].[Account] (
    [EmployeeId] INT NOT NULL PRIMARY KEY,
    [Account] VARCHAR(50) NOT NULL,
    [PasswordHash] VARCHAR(128) NOT NULL,
    [CreateTime] DATETIME NOT NULL DEFAULT (GETDATE()),
    [UpdateTime] DATETIME NOT NULL,
    [IsLocked] BIT NOT NULL DEFAULT (0),
    [LockedUntil] DATETIME NULL,
    [FailedLoginCount] INT NOT NULL DEFAULT (0)
);

CREATE TABLE [dbo].[EmployeePermissions] (
    [EmployeeId] INT NOT NULL,
    [PermissionKey] VARCHAR(50) NOT NULL,
    CONSTRAINT [PK_EmployeePermissions] PRIMARY KEY ([EmployeeId], [PermissionKey])
);

CREATE TABLE [dbo].[LoginLog] (
    [LogID] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [Username] VARCHAR(50) NOT NULL,
    [AttemptTime] DATETIME NOT NULL,
    [IPAddress] VARCHAR(50) NOT NULL,
    [MachineName] NVARCHAR(50) NOT NULL,
    [Status] NVARCHAR(10) NOT NULL
);

CREATE TABLE [dbo].[MemberLevels] (
    [LevelID] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [LevelName] NVARCHAR(50) NOT NULL,
    [DiscountRate] DECIMAL(3,2) NOT NULL DEFAULT (1.00),
    [PointMultiplier] DECIMAL(3,2) NOT NULL DEFAULT (1.00),
    [UpgradeCost] INT NOT NULL DEFAULT (0),
    [IsActive] BIT NULL
);

CREATE TABLE [dbo].[Members] (
    [MemberID] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [LevelID] INT NULL DEFAULT (1),
    [Phone] NVARCHAR(50) NOT NULL,
    [MemberName] NVARCHAR(60) NOT NULL,
    [JoinDate] DATETIME NOT NULL,
    [DefaultCarrierType] NVARCHAR(20) NULL,
    [DefaultCarrierNum] VARCHAR(50) NULL,
    [DefaultTaxID] VARCHAR(8) NULL,
    [Point] INT NULL DEFAULT (0),
    [IsActive] BIT NULL
);

CREATE TABLE [dbo].[Products] (
    [ProductID] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [CategoryID] INT NULL,
    [EmployeeId] INT NULL,
    [ProductName] NVARCHAR(50) NULL,
    [Stock] INT NULL,
    [CreateAt] DATETIME NULL DEFAULT (GETDATE()),
    [Price] INT NULL,
    [ImagePath] NVARCHAR(255) NULL,
    [IsActive] BIT NULL,
    [Sort] INT NULL
);

CREATE TABLE [dbo].[ProductOptionGroups] (
    [GroupID] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [GroupName] NVARCHAR(50) NOT NULL,
    [DisplayOrder] INT NOT NULL
);

CREATE TABLE [dbo].[ProductOptionItems] (
    [ItemID] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [GroupID] INT NOT NULL,
    [ItemName] NVARCHAR(50) NOT NULL,
    [ExtraPrice] INT NULL,
    [DisplayOrder] INT NOT NULL
);

CREATE TABLE [dbo].[ProductOptionMapping] (
    [ProductID] INT NOT NULL,
    [GroupID] INT NOT NULL,
    CONSTRAINT [PK_ProductOptionMapping] PRIMARY KEY ([ProductID], [GroupID])
);

CREATE TABLE [dbo].[Orders] (
    [OrderID] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [OrderDate] DATETIME NULL,
    [OrderType] NVARCHAR(10) NULL,
    [MemberID] INT NULL,
    [OriginalTotal] INT NULL,
    [DiscountAmount] INT NULL,
    [FinalAmount] INT NULL,
    [PaymentMethod] NVARCHAR(50) NULL,
    [CarrierType] NVARCHAR(50) NULL,
    [CarrierNum] NVARCHAR(50) NULL,
    [OrderStatus] TINYINT NULL,
    [OrderSort] INT NULL
);

CREATE TABLE [dbo].[OrderDetails] (
    [OrderDetailID] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [OrderID] INT NOT NULL,
    [ProductID] INT NOT NULL,
    [Quantity] INT NOT NULL DEFAULT (1),
    [SpecString] NVARCHAR(255) NULL,
    [UnitPrice] INT NOT NULL,
    [ProductName] NVARCHAR(100) NULL,
    [Subtotal] INT NULL
);
GO
-- Data for Categories (4 rows)
SET IDENTITY_INSERT [dbo].[Categories] ON;
INSERT INTO [dbo].[Categories] ([CategoryID], [CategoryName], [IconName], [SortOrder]) VALUES (1, N'精品咖啡', N'MugHot', 1);
INSERT INTO [dbo].[Categories] ([CategoryID], [CategoryName], [IconName], [SortOrder]) VALUES (2, N'經典義式咖啡', N'Coffee', 2);
INSERT INTO [dbo].[Categories] ([CategoryID], [CategoryName], [IconName], [SortOrder]) VALUES (3, N'輕食', N'Burger', 3);
INSERT INTO [dbo].[Categories] ([CategoryID], [CategoryName], [IconName], [SortOrder]) VALUES (4, N'糕點', N'BirthdayCake', 4);
SET IDENTITY_INSERT [dbo].[Categories] OFF;
GO

-- Data for Employees (25 rows)
SET IDENTITY_INSERT [dbo].[Employees] ON;
INSERT INTO [dbo].[Employees] ([EmployeeId], [EmployeeName], [EmployeeTitle], [Email], [EmployeeStatus], [EmployeePhone], [EmployeeAddress], [CreateTime]) VALUES (1001, N'陳冠廷', N'專案經理', N'kuanting.chen@example.com', 1, N'0912-345-678', N'台北市信義區信義路五段7號', '2026-07-01 09:00:00.000');
INSERT INTO [dbo].[Employees] ([EmployeeId], [EmployeeName], [EmployeeTitle], [Email], [EmployeeStatus], [EmployeePhone], [EmployeeAddress], [CreateTime]) VALUES (1002, N'林郁婷', N'前端工程師', N'yuting.lin@example.com', 1, N'0923-456-789', N'新北市板橋區中山路一段161號', '2026-07-02 09:30:00.000');
INSERT INTO [dbo].[Employees] ([EmployeeId], [EmployeeName], [EmployeeTitle], [Email], [EmployeeStatus], [EmployeePhone], [EmployeeAddress], [CreateTime]) VALUES (1003, N'黃偉哲', N'後端工程師', N'weizhe.huang@example.com', 1, N'0934-567-890', N'台中市西屯區台灣大道三段99號', '2026-07-03 10:15:00.000');
INSERT INTO [dbo].[Employees] ([EmployeeId], [EmployeeName], [EmployeeTitle], [Email], [EmployeeStatus], [EmployeePhone], [EmployeeAddress], [CreateTime]) VALUES (1004, N'張雅婷', N'UI/UX 設計師', N'yating.chang@example.com', 1, N'0945-678-901', N'高雄市苓雅區四維三路2號', '2026-07-04 11:00:00.000');
INSERT INTO [dbo].[Employees] ([EmployeeId], [EmployeeName], [EmployeeTitle], [Email], [EmployeeStatus], [EmployeePhone], [EmployeeAddress], [CreateTime]) VALUES (1005, N'李建宏', N'資料分析師', N'jianhong.lee@example.com', 1, N'0956-789-012', N'台南市安平區永華路二段6號', '2026-07-05 13:30:00.000');
INSERT INTO [dbo].[Employees] ([EmployeeId], [EmployeeName], [EmployeeTitle], [Email], [EmployeeStatus], [EmployeePhone], [EmployeeAddress], [CreateTime]) VALUES (1006, N'吳佩玲', N'行銷專員', N'peiling.wu@example.com', 1, N'0967-890-123', N'桃園市桃園區縣府路1號', '2026-07-06 14:00:00.000');
INSERT INTO [dbo].[Employees] ([EmployeeId], [EmployeeName], [EmployeeTitle], [Email], [EmployeeStatus], [EmployeePhone], [EmployeeAddress], [CreateTime]) VALUES (1007, N'劉志豪', N'業務經理', N'zhihao.liu@example.com', 1, N'0978-901-234', N'新竹市東區中正路120號', '2026-07-07 15:20:00.000');
INSERT INTO [dbo].[Employees] ([EmployeeId], [EmployeeName], [EmployeeTitle], [Email], [EmployeeStatus], [EmployeePhone], [EmployeeAddress], [CreateTime]) VALUES (1008, N'蔡依珊', N'人事專員', N'yishan.tsai@example.com', 1, N'0989-012-345', N'基隆市中正區信二路301號', '2026-07-08 09:45:00.000');
INSERT INTO [dbo].[Employees] ([EmployeeId], [EmployeeName], [EmployeeTitle], [Email], [EmployeeStatus], [EmployeePhone], [EmployeeAddress], [CreateTime]) VALUES (1009, N'楊宗翰', N'客服專員', N'zonghan.yang@example.com', 1, N'0991-123-456', N'宜蘭縣宜蘭市中山路一段755號', '2026-07-09 10:30:00.000');
INSERT INTO [dbo].[Employees] ([EmployeeId], [EmployeeName], [EmployeeTitle], [Email], [EmployeeStatus], [EmployeePhone], [EmployeeAddress], [CreateTime]) VALUES (1010, N'洪淑芬', N'財務會計', N'shufen.hong@example.com', 1, N'0911-234-567', N'彰化縣彰化市中山路二段416號', '2026-07-10 11:15:00.000');
INSERT INTO [dbo].[Employees] ([EmployeeId], [EmployeeName], [EmployeeTitle], [Email], [EmployeeStatus], [EmployeePhone], [EmployeeAddress], [CreateTime]) VALUES (1011, N'賴俊傑', N'系統管理員', N'junjie.lai@example.com', 1, N'0922-345-678', N'屏東縣屏東市自由路527號', '2026-07-11 13:00:00.000');
INSERT INTO [dbo].[Employees] ([EmployeeId], [EmployeeName], [EmployeeTitle], [Email], [EmployeeStatus], [EmployeePhone], [EmployeeAddress], [CreateTime]) VALUES (1012, N'周美玲', N'UI/UX 設計師', N'meiling.zhou@example.com', 1, N'0933-456-789', N'苗栗縣苗栗市府前路1號', '2026-07-12 14:10:00.000');
INSERT INTO [dbo].[Employees] ([EmployeeId], [EmployeeName], [EmployeeTitle], [Email], [EmployeeStatus], [EmployeePhone], [EmployeeAddress], [CreateTime]) VALUES (1013, N'徐國豪', N'軟體工程師', N'guohao.xu@example.com', 1, N'0944-567-890', N'南投縣南投市中興路660號', '2026-07-13 15:00:00.000');
INSERT INTO [dbo].[Employees] ([EmployeeId], [EmployeeName], [EmployeeTitle], [Email], [EmployeeStatus], [EmployeePhone], [EmployeeAddress], [CreateTime]) VALUES (1014, N'郭靜宜', N'產品經理', N'jingyi.guo@example.com', 1, N'0955-678-901', N'雲林縣斗六市親民路20號', '2026-07-14 09:10:00.000');
INSERT INTO [dbo].[Employees] ([EmployeeId], [EmployeeName], [EmployeeTitle], [Email], [EmployeeStatus], [EmployeePhone], [EmployeeAddress], [CreateTime]) VALUES (1015, N'陳家豪', N'維護工程師', N'jiahao.chen@example.com', 1, N'0966-789-012', N'嘉義市東區中山路199號', '2026-07-15 10:20:00.000');
INSERT INTO [dbo].[Employees] ([EmployeeId], [EmployeeName], [EmployeeTitle], [Email], [EmployeeStatus], [EmployeePhone], [EmployeeAddress], [CreateTime]) VALUES (1016, N'林怡君', N'公關專員', N'yijun.lin@example.com', 1, N'0977-890-123', N'花蓮縣花蓮市府前路17號', '2026-07-16 11:30:00.000');
INSERT INTO [dbo].[Employees] ([EmployeeId], [EmployeeName], [EmployeeTitle], [Email], [EmployeeStatus], [EmployeePhone], [EmployeeAddress], [CreateTime]) VALUES (1017, N'黃明志', N'正職人員', N'zhiming.huang@example.com', 1, N'0988-901-234', N'台東縣台東市中正路270號', '2026-07-17 13:40:00.000');
INSERT INTO [dbo].[Employees] ([EmployeeId], [EmployeeName], [EmployeeTitle], [Email], [EmployeeStatus], [EmployeePhone], [EmployeeAddress], [CreateTime]) VALUES (1018, N'張雅琪', N'法務專員', N'yaqi.chang@example.com', 2, N'0999-012-345', N'澎湖縣馬公市治平路32號', '2026-07-18 14:50:00.000');
INSERT INTO [dbo].[Employees] ([EmployeeId], [EmployeeName], [EmployeeTitle], [Email], [EmployeeStatus], [EmployeePhone], [EmployeeAddress], [CreateTime]) VALUES (1019, N'李明哲', N'業務專員', N'mingzhe.lee@example.com', 1, N'0910-111-222', N'金門縣金城鎮民生路60號', '2026-07-19 16:00:00.000');
INSERT INTO [dbo].[Employees] ([EmployeeId], [EmployeeName], [EmployeeTitle], [Email], [EmployeeStatus], [EmployeePhone], [EmployeeAddress], [CreateTime]) VALUES (1020, N'王小華', N'助理工程師', N'xiaohua.wang@example.com', 1, N'0920-222-333', N'連江縣南竿鄉介壽村76號', '2026-07-20 16:30:00.000');
INSERT INTO [dbo].[Employees] ([EmployeeId], [EmployeeName], [EmployeeTitle], [Email], [EmployeeStatus], [EmployeePhone], [EmployeeAddress], [CreateTime]) VALUES (1021, N'劉瑞德', N'資安工程師', N'cckl@cc.com.tw', 1, N'0988-888-072', N'台北市台北路2段116號', '2026-07-31 02:01:44.993');
INSERT INTO [dbo].[Employees] ([EmployeeId], [EmployeeName], [EmployeeTitle], [Email], [EmployeeStatus], [EmployeePhone], [EmployeeAddress], [CreateTime]) VALUES (2001, N'周潤發', N'總經理', N'888@gmail.com', 1, N'0988-888-888', N'高雄市大寮區發財路888號', '2026-07-11 12:35:27.140');
INSERT INTO [dbo].[Employees] ([EmployeeId], [EmployeeName], [EmployeeTitle], [Email], [EmployeeStatus], [EmployeePhone], [EmployeeAddress], [CreateTime]) VALUES (2002, N'劉德華', N'副總經理', N'88888@gmail.com', 1, N'0987-888-888', N'高雄市仁武區中山路627號', '2026-07-12 00:00:00.000');
INSERT INTO [dbo].[Employees] ([EmployeeId], [EmployeeName], [EmployeeTitle], [Email], [EmployeeStatus], [EmployeePhone], [EmployeeAddress], [CreateTime]) VALUES (2003, N'周星馳', N'業務專員', N'888888@gmail.com', 1, N'0966-666-666', N'高雄市大樹區愛河路725號', '2026-07-26 00:00:00.000');
INSERT INTO [dbo].[Employees] ([EmployeeId], [EmployeeName], [EmployeeTitle], [Email], [EmployeeStatus], [EmployeePhone], [EmployeeAddress], [CreateTime]) VALUES (3001, N'許龍', N'店長', N'12313@gmail.com', 1, N'0999-999-889', N'高雄市大寮區向上路999號', '2026-07-31 05:57:09.013');
SET IDENTITY_INSERT [dbo].[Employees] OFF;
GO

-- Data for Account (5 rows)
INSERT INTO [dbo].[Account] ([EmployeeId], [Account], [PasswordHash], [CreateTime], [UpdateTime], [IsLocked], [LockedUntil], [FailedLoginCount]) VALUES (1007, N'Liugihao', N'$2a$11$QcAb3gjHlEZNgi34dElPWeQ5DYUbsgfO88gpZEHY3xvtk7osFw6J2', '2026-07-31 02:32:39.137', '2026-07-31 02:32:39.137', 0, NULL, 0);
INSERT INTO [dbo].[Account] ([EmployeeId], [Account], [PasswordHash], [CreateTime], [UpdateTime], [IsLocked], [LockedUntil], [FailedLoginCount]) VALUES (2001, N'master', N'$2a$11$Dz4u4lq3k6B/hOPNdglatO6ZI4.5ZZdpNqdQ4SRTnH94etePqoNF.', '2026-07-29 03:30:36.130', '2026-07-31 02:03:12.217', 0, NULL, 0);
INSERT INTO [dbo].[Account] ([EmployeeId], [Account], [PasswordHash], [CreateTime], [UpdateTime], [IsLocked], [LockedUntil], [FailedLoginCount]) VALUES (2002, N'Liu', N'$2a$11$TjO3uCyg6DpycVZqd/Xht.jwJmhachYvjE5mg0bEYMLGZS9MLfIBS', '2026-07-29 04:13:25.217', '2026-07-30 05:23:09.013', 0, NULL, 0);
INSERT INTO [dbo].[Account] ([EmployeeId], [Account], [PasswordHash], [CreateTime], [UpdateTime], [IsLocked], [LockedUntil], [FailedLoginCount]) VALUES (2003, N'chou', N'$2a$11$/pi1sHjEm8NtOC9QPz1NyuJxSbPjo7n1N9lg/FUK.5iy0oDFbP9Z.', '2026-07-29 04:53:35.633', '2026-07-31 05:24:48.620', 0, NULL, 0);
INSERT INTO [dbo].[Account] ([EmployeeId], [Account], [PasswordHash], [CreateTime], [UpdateTime], [IsLocked], [LockedUntil], [FailedLoginCount]) VALUES (3001, N'long', N'$2a$11$p8YknIe9Huis8h.bJKLIhOzl0katrE7DiQ00.zlOkf8LoUmnAHo/K', '2026-07-31 05:57:24.363', '2026-07-31 05:57:45.527', 0, NULL, 0);
GO

-- Data for EmployeePermissions (74 rows)
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1004, N'Dashboard_Manage');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1004, N'Member_CRUD');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1004, N'MemberLevel_CRUD');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1004, N'Permission_CRUD');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1004, N'POS_System');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1004, N'Product_CRUD');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1004, N'ProductOption_CRUD');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1004, N'Revenue_View');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1005, N'Dashboard_Manage');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1005, N'Permission_CRUD');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1005, N'POS_System');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1005, N'Product_CRUD');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1005, N'ProductOption_CRUD');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1005, N'Revenue_View');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1007, N'Dashboard_Manage');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1007, N'Employee_CRUD');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1007, N'Member_CRUD');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1007, N'MemberLevel_CRUD');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1007, N'POS_System');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1007, N'Product_CRUD');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1007, N'ProductOption_CRUD');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1007, N'Revenue_View');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1008, N'Dashboard_Manage');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1008, N'Employee_CRUD');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1008, N'POS_System');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1012, N'Dashboard_Manage');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1012, N'Member_CRUD');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1012, N'MemberLevel_CRUD');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1012, N'Permission_CRUD');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1012, N'POS_System');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1012, N'Product_CRUD');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1012, N'ProductOption_CRUD');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1012, N'Revenue_View');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1015, N'Account_CRUD');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1015, N'Dashboard_Manage');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1015, N'Database_Backup');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1015, N'Employee_CRUD');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1015, N'LoginLog_View');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1015, N'Member_CRUD');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1015, N'MemberLevel_CRUD');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1015, N'Permission_CRUD');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1015, N'POS_System');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1015, N'Product_CRUD');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1015, N'ProductOption_CRUD');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1015, N'Revenue_View');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1016, N'Member_CRUD');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1016, N'MemberLevel_CRUD');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1016, N'POS_System');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1016, N'Product_CRUD');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1016, N'ProductOption_CRUD');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1021, N'Account_CRUD');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1021, N'Dashboard_Manage');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1021, N'Database_Backup');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1021, N'Employee_CRUD');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1021, N'LoginLog_View');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1021, N'Member_CRUD');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1021, N'MemberLevel_CRUD');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1021, N'Permission_CRUD');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1021, N'POS_System');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1021, N'Product_CRUD');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1021, N'ProductOption_CRUD');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (1021, N'Revenue_View');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (2001, N'Account_CRUD');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (2001, N'Dashboard_Manage');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (2001, N'Database_Backup');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (2001, N'Employee_CRUD');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (2001, N'LoginLog_View');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (2001, N'Member_CRUD');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (2001, N'MemberLevel_CRUD');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (2001, N'Permission_CRUD');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (2001, N'POS_System');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (2001, N'Product_CRUD');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (2001, N'ProductOption_CRUD');
INSERT INTO [dbo].[EmployeePermissions] ([EmployeeId], [PermissionKey]) VALUES (2001, N'Revenue_View');
GO

-- Data for MemberLevels (4 rows)
SET IDENTITY_INSERT [dbo].[MemberLevels] ON;
INSERT INTO [dbo].[MemberLevels] ([LevelID], [LevelName], [DiscountRate], [PointMultiplier], [UpgradeCost], [IsActive]) VALUES (1, N'一般會員', 1.00, 0.01, 0, NULL);
INSERT INTO [dbo].[MemberLevels] ([LevelID], [LevelName], [DiscountRate], [PointMultiplier], [UpgradeCost], [IsActive]) VALUES (2, N'白金 VIP', 0.90, 0.05, 1000, NULL);
INSERT INTO [dbo].[MemberLevels] ([LevelID], [LevelName], [DiscountRate], [PointMultiplier], [UpgradeCost], [IsActive]) VALUES (3, N'銀級會員', 0.95, 0.02, 300, NULL);
INSERT INTO [dbo].[MemberLevels] ([LevelID], [LevelName], [DiscountRate], [PointMultiplier], [UpgradeCost], [IsActive]) VALUES (4, N'金級會員', 0.93, 0.03, 500, NULL);
SET IDENTITY_INSERT [dbo].[MemberLevels] OFF;
GO

-- Data for Members (8 rows)
SET IDENTITY_INSERT [dbo].[Members] ON;
INSERT INTO [dbo].[Members] ([MemberID], [LevelID], [Phone], [MemberName], [JoinDate], [DefaultCarrierType], [DefaultCarrierNum], [DefaultTaxID], [Point], [IsActive]) VALUES (1, 1, N'0988888888', N'金城武', '2026-07-22 20:23:12.177', N'手機條碼', N'/5D2H2A', N'04888888', 2, 1);
INSERT INTO [dbo].[Members] ([MemberID], [LevelID], [Phone], [MemberName], [JoinDate], [DefaultCarrierType], [DefaultCarrierNum], [DefaultTaxID], [Point], [IsActive]) VALUES (2, 2, N'0999999999', N'古天樂', '2026-07-22 21:11:13.000', N'公司統編', NULL, N'04998879', 1946, 1);
INSERT INTO [dbo].[Members] ([MemberID], [LevelID], [Phone], [MemberName], [JoinDate], [DefaultCarrierType], [DefaultCarrierNum], [DefaultTaxID], [Point], [IsActive]) VALUES (3, 1, N'0977777777', N'劉仲禎', '2026-07-30 22:47:38.433', NULL, N'/AB11235', NULL, 62, 0);
INSERT INTO [dbo].[Members] ([MemberID], [LevelID], [Phone], [MemberName], [JoinDate], [DefaultCarrierType], [DefaultCarrierNum], [DefaultTaxID], [Point], [IsActive]) VALUES (4, 2, N'0966666666', N'金帥哥', '2026-07-30 23:10:10.157', NULL, N'/AC12115', NULL, 0, 0);
INSERT INTO [dbo].[Members] ([MemberID], [LevelID], [Phone], [MemberName], [JoinDate], [DefaultCarrierType], [DefaultCarrierNum], [DefaultTaxID], [Point], [IsActive]) VALUES (5, 1, N'0966654555', N'陳淑華', '2026-07-30 23:23:22.967', NULL, N'/5S1D2Y', N'04992517', 0, 0);
INSERT INTO [dbo].[Members] ([MemberID], [LevelID], [Phone], [MemberName], [JoinDate], [DefaultCarrierType], [DefaultCarrierNum], [DefaultTaxID], [Point], [IsActive]) VALUES (6, 1, N'0955555555', N'陳守信', '2026-07-30 23:33:57.653', N'手機條碼', N'/CC12356', NULL, 0, 0);
INSERT INTO [dbo].[Members] ([MemberID], [LevelID], [Phone], [MemberName], [JoinDate], [DefaultCarrierType], [DefaultCarrierNum], [DefaultTaxID], [Point], [IsActive]) VALUES (7, 4, N'0977777777', N'頁大同', '2026-07-31 05:59:17.330', N'手機條碼', N'/6A2YH66', N'04991235', 200, 1);
INSERT INTO [dbo].[Members] ([MemberID], [LevelID], [Phone], [MemberName], [JoinDate], [DefaultCarrierType], [DefaultCarrierNum], [DefaultTaxID], [Point], [IsActive]) VALUES (8, 3, N'0966666666', N'陳添冰', '2026-07-31 06:01:53.000', N'手機條碼', N'/AC11865', NULL, 300, 1);
SET IDENTITY_INSERT [dbo].[Members] OFF;
GO

-- Data for Products (13 rows)
SET IDENTITY_INSERT [dbo].[Products] ON;
INSERT INTO [dbo].[Products] ([ProductID], [CategoryID], [EmployeeId], [ProductName], [Stock], [CreateAt], [Price], [ImagePath], [IsActive], [Sort]) VALUES (1, 1, 1, N'莊園級美式', 100, '2026-07-11 00:12:44.933', 60, N'莊園咖啡.jpg', 1, 1);
INSERT INTO [dbo].[Products] ([ProductID], [CategoryID], [EmployeeId], [ProductName], [Stock], [CreateAt], [Price], [ImagePath], [IsActive], [Sort]) VALUES (2, 1, 1, N'耶加雪菲手沖', 50, '2026-07-11 00:12:44.933', 90, N'Europe.jpg', 1, 2);
INSERT INTO [dbo].[Products] ([ProductID], [CategoryID], [EmployeeId], [ProductName], [Stock], [CreateAt], [Price], [ImagePath], [IsActive], [Sort]) VALUES (3, 2, 2, N'莊園級拿鐵', 98, '2026-07-11 00:12:44.933', 80, N'Orange.jpg', 1, 1);
INSERT INTO [dbo].[Products] ([ProductID], [CategoryID], [EmployeeId], [ProductName], [Stock], [CreateAt], [Price], [ImagePath], [IsActive], [Sort]) VALUES (4, 2, 2, N'小農雪點鮮奶茶', 79, '2026-07-11 00:12:44.933', 60, N'焦糖.jpg', 1, 2);
INSERT INTO [dbo].[Products] ([ProductID], [CategoryID], [EmployeeId], [ProductName], [Stock], [CreateAt], [Price], [ImagePath], [IsActive], [Sort]) VALUES (5, 3, 2, N'磚壓麥香牛肉排', 30, '2026-07-11 00:12:44.933', 40, N'肉排.jpg', 1, 2);
INSERT INTO [dbo].[Products] ([ProductID], [CategoryID], [EmployeeId], [ProductName], [Stock], [CreateAt], [Price], [ImagePath], [IsActive], [Sort]) VALUES (6, 3, 3, N'軟歐藏心貝果', 40, '2026-07-11 00:12:44.933', 55, N'貝果.jpg', 1, 1);
INSERT INTO [dbo].[Products] ([ProductID], [CategoryID], [EmployeeId], [ProductName], [Stock], [CreateAt], [Price], [ImagePath], [IsActive], [Sort]) VALUES (7, 4, 2, N'法式檸檬塔', 15, '2026-07-11 00:12:44.933', 60, N'檸檬塔.png', 1, 1);
INSERT INTO [dbo].[Products] ([ProductID], [CategoryID], [EmployeeId], [ProductName], [Stock], [CreateAt], [Price], [ImagePath], [IsActive], [Sort]) VALUES (8, 4, 3, N'經典波士頓派', 19, '2026-07-11 00:12:44.933', 65, N'經典起司.png', 1, 2);
INSERT INTO [dbo].[Products] ([ProductID], [CategoryID], [EmployeeId], [ProductName], [Stock], [CreateAt], [Price], [ImagePath], [IsActive], [Sort]) VALUES (9, 1, 1, N'阿拉比卡咖啡', 100, '2026-07-26 23:18:07.717', 120, N'20210601_113840.jpg', 1, 5);
INSERT INTO [dbo].[Products] ([ProductID], [CategoryID], [EmployeeId], [ProductName], [Stock], [CreateAt], [Price], [ImagePath], [IsActive], [Sort]) VALUES (10, 2, 1, N'卡布奇諾', 0, '2026-07-27 00:03:37.907', 80, N'coffee-types-04.jpg', 1, 3);
INSERT INTO [dbo].[Products] ([ProductID], [CategoryID], [EmployeeId], [ProductName], [Stock], [CreateAt], [Price], [ImagePath], [IsActive], [Sort]) VALUES (11, 1, 1, N'摩卡咖啡', 100, '2026-07-27 01:46:35.590', 70, N'coffee-types-05.jpg', 1, 4);
INSERT INTO [dbo].[Products] ([ProductID], [CategoryID], [EmployeeId], [ProductName], [Stock], [CreateAt], [Price], [ImagePath], [IsActive], [Sort]) VALUES (13, 1, 1, N'焦糖瑪奇朵', 100, '2026-07-27 13:47:24.530', 80, N'coffee-types-06.jpg', 1, 3);
INSERT INTO [dbo].[Products] ([ProductID], [CategoryID], [EmployeeId], [ProductName], [Stock], [CreateAt], [Price], [ImagePath], [IsActive], [Sort]) VALUES (16, 1, 1, N'黑糖拿鐵', 10, '2026-07-31 05:16:05.220', 90, N'黑糖拿鐵.png', 1, 6);
SET IDENTITY_INSERT [dbo].[Products] OFF;
GO

-- Data for ProductOptionGroups (5 rows)
SET IDENTITY_INSERT [dbo].[ProductOptionGroups] ON;
INSERT INTO [dbo].[ProductOptionGroups] ([GroupID], [GroupName], [DisplayOrder]) VALUES (1, N'冰塊選擇', 10);
INSERT INTO [dbo].[ProductOptionGroups] ([GroupID], [GroupName], [DisplayOrder]) VALUES (2, N'甜度選擇', 5);
INSERT INTO [dbo].[ProductOptionGroups] ([GroupID], [GroupName], [DisplayOrder]) VALUES (3, N'餐具需求', 30);
INSERT INTO [dbo].[ProductOptionGroups] ([GroupID], [GroupName], [DisplayOrder]) VALUES (4, N'尺寸選擇', 20);
INSERT INTO [dbo].[ProductOptionGroups] ([GroupID], [GroupName], [DisplayOrder]) VALUES (6, N'加料', 31);
SET IDENTITY_INSERT [dbo].[ProductOptionGroups] OFF;
GO

-- Data for ProductOptionItems (21 rows)
SET IDENTITY_INSERT [dbo].[ProductOptionItems] ON;
INSERT INTO [dbo].[ProductOptionItems] ([ItemID], [GroupID], [ItemName], [ExtraPrice], [DisplayOrder]) VALUES (1, 1, N'正常冰', 0, 20);
INSERT INTO [dbo].[ProductOptionItems] ([ItemID], [GroupID], [ItemName], [ExtraPrice], [DisplayOrder]) VALUES (2, 1, N'少冰', 0, 30);
INSERT INTO [dbo].[ProductOptionItems] ([ItemID], [GroupID], [ItemName], [ExtraPrice], [DisplayOrder]) VALUES (3, 1, N'微冰', 0, 50);
INSERT INTO [dbo].[ProductOptionItems] ([ItemID], [GroupID], [ItemName], [ExtraPrice], [DisplayOrder]) VALUES (4, 1, N'去冰(小碎冰)', 0, 40);
INSERT INTO [dbo].[ProductOptionItems] ([ItemID], [GroupID], [ItemName], [ExtraPrice], [DisplayOrder]) VALUES (5, 1, N'完全去冰', 0, 60);
INSERT INTO [dbo].[ProductOptionItems] ([ItemID], [GroupID], [ItemName], [ExtraPrice], [DisplayOrder]) VALUES (6, 2, N'正常甜', 0, 10);
INSERT INTO [dbo].[ProductOptionItems] ([ItemID], [GroupID], [ItemName], [ExtraPrice], [DisplayOrder]) VALUES (7, 2, N'8分糖', 0, 20);
INSERT INTO [dbo].[ProductOptionItems] ([ItemID], [GroupID], [ItemName], [ExtraPrice], [DisplayOrder]) VALUES (8, 2, N'7分糖', 0, 30);
INSERT INTO [dbo].[ProductOptionItems] ([ItemID], [GroupID], [ItemName], [ExtraPrice], [DisplayOrder]) VALUES (9, 2, N'半糖', 0, 40);
INSERT INTO [dbo].[ProductOptionItems] ([ItemID], [GroupID], [ItemName], [ExtraPrice], [DisplayOrder]) VALUES (10, 2, N'3分糖', 0, 50);
INSERT INTO [dbo].[ProductOptionItems] ([ItemID], [GroupID], [ItemName], [ExtraPrice], [DisplayOrder]) VALUES (11, 2, N'微糖', 0, 60);
INSERT INTO [dbo].[ProductOptionItems] ([ItemID], [GroupID], [ItemName], [ExtraPrice], [DisplayOrder]) VALUES (12, 2, N'1分糖', 0, 70);
INSERT INTO [dbo].[ProductOptionItems] ([ItemID], [GroupID], [ItemName], [ExtraPrice], [DisplayOrder]) VALUES (13, 2, N'無糖', 0, 80);
INSERT INTO [dbo].[ProductOptionItems] ([ItemID], [GroupID], [ItemName], [ExtraPrice], [DisplayOrder]) VALUES (14, 3, N'需要餐具', 0, 10);
INSERT INTO [dbo].[ProductOptionItems] ([ItemID], [GroupID], [ItemName], [ExtraPrice], [DisplayOrder]) VALUES (15, 3, N'不需要餐具', 0, 20);
INSERT INTO [dbo].[ProductOptionItems] ([ItemID], [GroupID], [ItemName], [ExtraPrice], [DisplayOrder]) VALUES (16, 1, N'熱飲', 0, 61);
INSERT INTO [dbo].[ProductOptionItems] ([ItemID], [GroupID], [ItemName], [ExtraPrice], [DisplayOrder]) VALUES (17, 4, N'M', 0, 10);
INSERT INTO [dbo].[ProductOptionItems] ([ItemID], [GroupID], [ItemName], [ExtraPrice], [DisplayOrder]) VALUES (18, 4, N'L', 5, 20);
INSERT INTO [dbo].[ProductOptionItems] ([ItemID], [GroupID], [ItemName], [ExtraPrice], [DisplayOrder]) VALUES (19, 4, N'XL', 10, 30);
INSERT INTO [dbo].[ProductOptionItems] ([ItemID], [GroupID], [ItemName], [ExtraPrice], [DisplayOrder]) VALUES (23, 1, N'超多冰', 2, 10);
INSERT INTO [dbo].[ProductOptionItems] ([ItemID], [GroupID], [ItemName], [ExtraPrice], [DisplayOrder]) VALUES (24, 6, N'加珍珠', 10, 1);
SET IDENTITY_INSERT [dbo].[ProductOptionItems] OFF;
GO

-- Data for ProductOptionMapping (19 rows)
INSERT INTO [dbo].[ProductOptionMapping] ([ProductID], [GroupID]) VALUES (1, 1);
INSERT INTO [dbo].[ProductOptionMapping] ([ProductID], [GroupID]) VALUES (1, 2);
INSERT INTO [dbo].[ProductOptionMapping] ([ProductID], [GroupID]) VALUES (1, 4);
INSERT INTO [dbo].[ProductOptionMapping] ([ProductID], [GroupID]) VALUES (2, 1);
INSERT INTO [dbo].[ProductOptionMapping] ([ProductID], [GroupID]) VALUES (2, 2);
INSERT INTO [dbo].[ProductOptionMapping] ([ProductID], [GroupID]) VALUES (2, 4);
INSERT INTO [dbo].[ProductOptionMapping] ([ProductID], [GroupID]) VALUES (3, 1);
INSERT INTO [dbo].[ProductOptionMapping] ([ProductID], [GroupID]) VALUES (3, 2);
INSERT INTO [dbo].[ProductOptionMapping] ([ProductID], [GroupID]) VALUES (3, 4);
INSERT INTO [dbo].[ProductOptionMapping] ([ProductID], [GroupID]) VALUES (4, 1);
INSERT INTO [dbo].[ProductOptionMapping] ([ProductID], [GroupID]) VALUES (4, 2);
INSERT INTO [dbo].[ProductOptionMapping] ([ProductID], [GroupID]) VALUES (4, 4);
INSERT INTO [dbo].[ProductOptionMapping] ([ProductID], [GroupID]) VALUES (5, 3);
INSERT INTO [dbo].[ProductOptionMapping] ([ProductID], [GroupID]) VALUES (6, 3);
INSERT INTO [dbo].[ProductOptionMapping] ([ProductID], [GroupID]) VALUES (7, 3);
INSERT INTO [dbo].[ProductOptionMapping] ([ProductID], [GroupID]) VALUES (8, 3);
INSERT INTO [dbo].[ProductOptionMapping] ([ProductID], [GroupID]) VALUES (10, 1);
INSERT INTO [dbo].[ProductOptionMapping] ([ProductID], [GroupID]) VALUES (10, 2);
INSERT INTO [dbo].[ProductOptionMapping] ([ProductID], [GroupID]) VALUES (10, 4);
GO

-- Data for Orders (42 rows)
SET IDENTITY_INSERT [dbo].[Orders] ON;
INSERT INTO [dbo].[Orders] ([OrderID], [OrderDate], [OrderType], [MemberID], [OriginalTotal], [DiscountAmount], [FinalAmount], [PaymentMethod], [CarrierType], [CarrierNum], [OrderStatus], [OrderSort]) VALUES (1, '2026-07-22 18:31:14.820', N'內用', NULL, 65, 0, 65, N'LINE Pay', N'手機條碼', N'/5D2YH4S', 2, 12);
INSERT INTO [dbo].[Orders] ([OrderID], [OrderDate], [OrderType], [MemberID], [OriginalTotal], [DiscountAmount], [FinalAmount], [PaymentMethod], [CarrierType], [CarrierNum], [OrderStatus], [OrderSort]) VALUES (2, '2026-07-22 18:32:45.557', N'內用', 1, 150, 15, 135, N'LINE Pay', N'公司統編', N'04171882', 2, 11);
INSERT INTO [dbo].[Orders] ([OrderID], [OrderDate], [OrderType], [MemberID], [OriginalTotal], [DiscountAmount], [FinalAmount], [PaymentMethod], [CarrierType], [CarrierNum], [OrderStatus], [OrderSort]) VALUES (3, '2026-07-22 20:55:55.973', N'內用', 1, 90, 9, 81, N'信用卡', N'公司統編', N'04888888', 2, 13);
INSERT INTO [dbo].[Orders] ([OrderID], [OrderDate], [OrderType], [MemberID], [OriginalTotal], [DiscountAmount], [FinalAmount], [PaymentMethod], [CarrierType], [CarrierNum], [OrderStatus], [OrderSort]) VALUES (4, '2026-07-22 21:40:05.697', N'內用', NULL, 65, 0, 65, N'LINE Pay', N'紙本發票', NULL, 2, 14);
INSERT INTO [dbo].[Orders] ([OrderID], [OrderDate], [OrderType], [MemberID], [OriginalTotal], [DiscountAmount], [FinalAmount], [PaymentMethod], [CarrierType], [CarrierNum], [OrderStatus], [OrderSort]) VALUES (5, '2026-07-22 21:58:49.227', N'內用', 2, 90, 9, 81, N'LINE Pay', N'公司統編', N'04998879', 2, 15);
INSERT INTO [dbo].[Orders] ([OrderID], [OrderDate], [OrderType], [MemberID], [OriginalTotal], [DiscountAmount], [FinalAmount], [PaymentMethod], [CarrierType], [CarrierNum], [OrderStatus], [OrderSort]) VALUES (6, '2026-07-23 21:49:26.530', N'內用', NULL, 90, 0, 90, N'LINE Pay', N'紙本發票', NULL, 2, 10);
INSERT INTO [dbo].[Orders] ([OrderID], [OrderDate], [OrderType], [MemberID], [OriginalTotal], [DiscountAmount], [FinalAmount], [PaymentMethod], [CarrierType], [CarrierNum], [OrderStatus], [OrderSort]) VALUES (7, '2026-07-26 20:58:13.490', N'內用', 1, 70, 7, 63, N'LINE Pay', N'公司統編', N'04888888', 2, 9);
INSERT INTO [dbo].[Orders] ([OrderID], [OrderDate], [OrderType], [MemberID], [OriginalTotal], [DiscountAmount], [FinalAmount], [PaymentMethod], [CarrierType], [CarrierNum], [OrderStatus], [OrderSort]) VALUES (8, '2026-07-27 00:00:01.720', N'內用', NULL, 70, 0, 70, N'信用卡', N'紙本發票', NULL, 2, 8);
INSERT INTO [dbo].[Orders] ([OrderID], [OrderDate], [OrderType], [MemberID], [OriginalTotal], [DiscountAmount], [FinalAmount], [PaymentMethod], [CarrierType], [CarrierNum], [OrderStatus], [OrderSort]) VALUES (9, '2026-07-27 02:17:19.273', N'外帶', 1, 225, 22, 203, N'現金', N'手機條碼', N'/5D2H2A', 2, 7);
INSERT INTO [dbo].[Orders] ([OrderID], [OrderDate], [OrderType], [MemberID], [OriginalTotal], [DiscountAmount], [FinalAmount], [PaymentMethod], [CarrierType], [CarrierNum], [OrderStatus], [OrderSort]) VALUES (10, '2026-07-27 02:18:18.557', N'內用', 2, 100, 10, 90, N'LINE Pay', N'公司統編', N'04998879', 2, 6);
INSERT INTO [dbo].[Orders] ([OrderID], [OrderDate], [OrderType], [MemberID], [OriginalTotal], [DiscountAmount], [FinalAmount], [PaymentMethod], [CarrierType], [CarrierNum], [OrderStatus], [OrderSort]) VALUES (11, '2026-07-27 12:22:13.130', N'內用', 1, 440, 44, 396, N'LINE Pay', N'手機條碼', N'/5D2H2A', 2, 4);
INSERT INTO [dbo].[Orders] ([OrderID], [OrderDate], [OrderType], [MemberID], [OriginalTotal], [DiscountAmount], [FinalAmount], [PaymentMethod], [CarrierType], [CarrierNum], [OrderStatus], [OrderSort]) VALUES (12, '2026-07-27 13:43:48.983', N'內用', 1, 270, 27, 243, N'現金', N'手機條碼', N'/5D2H2A', 2, 5);
INSERT INTO [dbo].[Orders] ([OrderID], [OrderDate], [OrderType], [MemberID], [OriginalTotal], [DiscountAmount], [FinalAmount], [PaymentMethod], [CarrierType], [CarrierNum], [OrderStatus], [OrderSort]) VALUES (13, '2026-07-28 12:17:45.423', N'內用', NULL, 100, 0, 100, N'現金', N'紙本發票', NULL, 2, 3);
INSERT INTO [dbo].[Orders] ([OrderID], [OrderDate], [OrderType], [MemberID], [OriginalTotal], [DiscountAmount], [FinalAmount], [PaymentMethod], [CarrierType], [CarrierNum], [OrderStatus], [OrderSort]) VALUES (14, '2026-07-29 22:27:01.957', N'內用', 1, 60, 6, 54, N'LINE Pay', N'公司統編', N'04888888', 2, 2);
INSERT INTO [dbo].[Orders] ([OrderID], [OrderDate], [OrderType], [MemberID], [OriginalTotal], [DiscountAmount], [FinalAmount], [PaymentMethod], [CarrierType], [CarrierNum], [OrderStatus], [OrderSort]) VALUES (15, '2026-07-30 20:57:28.770', N'內用', 1, 70, 7, 63, N'信用卡', N'手機條碼', N'/5D2H2A', 2, 1);
INSERT INTO [dbo].[Orders] ([OrderID], [OrderDate], [OrderType], [MemberID], [OriginalTotal], [DiscountAmount], [FinalAmount], [PaymentMethod], [CarrierType], [CarrierNum], [OrderStatus], [OrderSort]) VALUES (16, '2026-07-30 21:17:03.100', N'內用', NULL, 234, 0, 234, N'現金', N'紙本發票', NULL, 2, 1);
INSERT INTO [dbo].[Orders] ([OrderID], [OrderDate], [OrderType], [MemberID], [OriginalTotal], [DiscountAmount], [FinalAmount], [PaymentMethod], [CarrierType], [CarrierNum], [OrderStatus], [OrderSort]) VALUES (17, '2026-07-30 21:19:35.323', N'內用', NULL, 568, 0, 568, N'現金', N'紙本發票', NULL, 2, 1);
INSERT INTO [dbo].[Orders] ([OrderID], [OrderDate], [OrderType], [MemberID], [OriginalTotal], [DiscountAmount], [FinalAmount], [PaymentMethod], [CarrierType], [CarrierNum], [OrderStatus], [OrderSort]) VALUES (18, '2026-07-30 21:20:09.147', N'外帶', NULL, 424, 0, 424, N'現金', N'紙本發票', NULL, 2, 1);
INSERT INTO [dbo].[Orders] ([OrderID], [OrderDate], [OrderType], [MemberID], [OriginalTotal], [DiscountAmount], [FinalAmount], [PaymentMethod], [CarrierType], [CarrierNum], [OrderStatus], [OrderSort]) VALUES (19, '2026-07-30 21:38:51.903', N'內用', NULL, 788, 0, 788, N'現金', N'紙本發票', NULL, 2, 1);
INSERT INTO [dbo].[Orders] ([OrderID], [OrderDate], [OrderType], [MemberID], [OriginalTotal], [DiscountAmount], [FinalAmount], [PaymentMethod], [CarrierType], [CarrierNum], [OrderStatus], [OrderSort]) VALUES (20, '2026-07-30 21:41:36.700', N'內用', 1, 788, 78, 710, N'現金', N'手機條碼', N'/5D2H2A', 2, 1);
INSERT INTO [dbo].[Orders] ([OrderID], [OrderDate], [OrderType], [MemberID], [OriginalTotal], [DiscountAmount], [FinalAmount], [PaymentMethod], [CarrierType], [CarrierNum], [OrderStatus], [OrderSort]) VALUES (21, '2026-07-30 21:48:49.740', N'內用', NULL, 424, 0, 424, N'現金', N'紙本發票', NULL, 2, 1);
INSERT INTO [dbo].[Orders] ([OrderID], [OrderDate], [OrderType], [MemberID], [OriginalTotal], [DiscountAmount], [FinalAmount], [PaymentMethod], [CarrierType], [CarrierNum], [OrderStatus], [OrderSort]) VALUES (22, '2026-07-30 21:49:49.207', N'內用', NULL, 62, 0, 62, N'現金', N'紙本發票', NULL, 3, 1);
INSERT INTO [dbo].[Orders] ([OrderID], [OrderDate], [OrderType], [MemberID], [OriginalTotal], [DiscountAmount], [FinalAmount], [PaymentMethod], [CarrierType], [CarrierNum], [OrderStatus], [OrderSort]) VALUES (23, '2026-07-30 21:49:57.240', N'內用', NULL, 92, 0, 92, N'現金', N'紙本發票', NULL, 2, 1);
INSERT INTO [dbo].[Orders] ([OrderID], [OrderDate], [OrderType], [MemberID], [OriginalTotal], [DiscountAmount], [FinalAmount], [PaymentMethod], [CarrierType], [CarrierNum], [OrderStatus], [OrderSort]) VALUES (24, '2026-07-30 22:10:54.197', N'內用', NULL, 62, 0, 62, N'現金', N'紙本發票', NULL, 2, 1);
INSERT INTO [dbo].[Orders] ([OrderID], [OrderDate], [OrderType], [MemberID], [OriginalTotal], [DiscountAmount], [FinalAmount], [PaymentMethod], [CarrierType], [CarrierNum], [OrderStatus], [OrderSort]) VALUES (25, '2026-07-31 00:20:27.590', N'內用', 2, 72, 6, 66, N'現金', N'公司統編', N'04998879', 2, 1);
INSERT INTO [dbo].[Orders] ([OrderID], [OrderDate], [OrderType], [MemberID], [OriginalTotal], [DiscountAmount], [FinalAmount], [PaymentMethod], [CarrierType], [CarrierNum], [OrderStatus], [OrderSort]) VALUES (26, '2026-07-31 00:23:04.333', N'內用', 1, 92, 0, 0, N'現金', N'手機條碼', N'/5D2H2A', 2, 1);
INSERT INTO [dbo].[Orders] ([OrderID], [OrderDate], [OrderType], [MemberID], [OriginalTotal], [DiscountAmount], [FinalAmount], [PaymentMethod], [CarrierType], [CarrierNum], [OrderStatus], [OrderSort]) VALUES (27, '2026-07-31 00:35:42.327', N'內用', 2, 92, 7, 0, N'點數付款', N'公司統編', N'04998879', 2, 1);
INSERT INTO [dbo].[Orders] ([OrderID], [OrderDate], [OrderType], [MemberID], [OriginalTotal], [DiscountAmount], [FinalAmount], [PaymentMethod], [CarrierType], [CarrierNum], [OrderStatus], [OrderSort]) VALUES (28, '2026-07-31 00:51:28.410', N'內用', 2, 92, 7, 85, N'現金', N'公司統編', N'04998879', 2, 1);
INSERT INTO [dbo].[Orders] ([OrderID], [OrderDate], [OrderType], [MemberID], [OriginalTotal], [DiscountAmount], [FinalAmount], [PaymentMethod], [CarrierType], [CarrierNum], [OrderStatus], [OrderSort]) VALUES (29, '2026-07-31 00:53:05.620', N'內用', NULL, 62, 0, 62, N'現金', N'紙本發票', NULL, 2, 1);
INSERT INTO [dbo].[Orders] ([OrderID], [OrderDate], [OrderType], [MemberID], [OriginalTotal], [DiscountAmount], [FinalAmount], [PaymentMethod], [CarrierType], [CarrierNum], [OrderStatus], [OrderSort]) VALUES (30, '2026-07-31 00:57:32.120', N'內用', 2, 92, 7, 0, N'點數付款', N'公司統編', N'04998879', 2, 1);
INSERT INTO [dbo].[Orders] ([OrderID], [OrderDate], [OrderType], [MemberID], [OriginalTotal], [DiscountAmount], [FinalAmount], [PaymentMethod], [CarrierType], [CarrierNum], [OrderStatus], [OrderSort]) VALUES (31, '2026-07-31 00:57:43.757', N'內用', 1, 92, 0, 92, N'現金', N'手機條碼', N'/5D2H2A', 2, 1);
INSERT INTO [dbo].[Orders] ([OrderID], [OrderDate], [OrderType], [MemberID], [OriginalTotal], [DiscountAmount], [FinalAmount], [PaymentMethod], [CarrierType], [CarrierNum], [OrderStatus], [OrderSort]) VALUES (32, '2026-07-31 00:57:56.140', N'內用', 2, 292, 21, 271, N'現金', N'公司統編', N'04998879', 2, 1);
INSERT INTO [dbo].[Orders] ([OrderID], [OrderDate], [OrderType], [MemberID], [OriginalTotal], [DiscountAmount], [FinalAmount], [PaymentMethod], [CarrierType], [CarrierNum], [OrderStatus], [OrderSort]) VALUES (33, '2026-07-31 01:05:33.920', N'內用', 1, 62, 0, 42, N'LINE Pay', N'手機條碼', N'/5D2H2A', 2, 1);
INSERT INTO [dbo].[Orders] ([OrderID], [OrderDate], [OrderType], [MemberID], [OriginalTotal], [DiscountAmount], [FinalAmount], [PaymentMethod], [CarrierType], [CarrierNum], [OrderStatus], [OrderSort]) VALUES (34, '2026-07-31 01:06:07.523', N'內用', 1, 92, 0, 92, N'現金', N'手機條碼', N'/5D2H2A', 2, 1);
INSERT INTO [dbo].[Orders] ([OrderID], [OrderDate], [OrderType], [MemberID], [OriginalTotal], [DiscountAmount], [FinalAmount], [PaymentMethod], [CarrierType], [CarrierNum], [OrderStatus], [OrderSort]) VALUES (35, '2026-07-31 01:06:20.813', N'內用', 1, 120, 0, 120, N'現金', N'手機條碼', N'/5D2H2A', 2, 1);
INSERT INTO [dbo].[Orders] ([OrderID], [OrderDate], [OrderType], [MemberID], [OriginalTotal], [DiscountAmount], [FinalAmount], [PaymentMethod], [CarrierType], [CarrierNum], [OrderStatus], [OrderSort]) VALUES (36, '2026-07-31 01:07:17.350', N'內用', 1, 92, 0, 92, N'現金', N'手機條碼', N'/5D2H2A', 2, 1);
INSERT INTO [dbo].[Orders] ([OrderID], [OrderDate], [OrderType], [MemberID], [OriginalTotal], [DiscountAmount], [FinalAmount], [PaymentMethod], [CarrierType], [CarrierNum], [OrderStatus], [OrderSort]) VALUES (37, '2026-07-31 01:07:29.683', N'內用', 1, 120, 0, 120, N'現金', N'手機條碼', N'/5D2H2A', 2, 1);
INSERT INTO [dbo].[Orders] ([OrderID], [OrderDate], [OrderType], [MemberID], [OriginalTotal], [DiscountAmount], [FinalAmount], [PaymentMethod], [CarrierType], [CarrierNum], [OrderStatus], [OrderSort]) VALUES (38, '2026-07-31 01:14:10.990', N'內用', 2, 92, 7, 0, N'點數付款', N'公司統編', N'04998879', 2, 1);
INSERT INTO [dbo].[Orders] ([OrderID], [OrderDate], [OrderType], [MemberID], [OriginalTotal], [DiscountAmount], [FinalAmount], [PaymentMethod], [CarrierType], [CarrierNum], [OrderStatus], [OrderSort]) VALUES (39, '2026-07-31 03:02:38.600', N'內用', 2, 65, 7, 0, N'現金', N'公司統編', N'04998879', 2, 1);
INSERT INTO [dbo].[Orders] ([OrderID], [OrderDate], [OrderType], [MemberID], [OriginalTotal], [DiscountAmount], [FinalAmount], [PaymentMethod], [CarrierType], [CarrierNum], [OrderStatus], [OrderSort]) VALUES (40, '2026-07-31 05:10:42.943', N'內用', 2, 90, 9, 61, N'LINE Pay', N'公司統編', N'04998879', 1, 1);
INSERT INTO [dbo].[Orders] ([OrderID], [OrderDate], [OrderType], [MemberID], [OriginalTotal], [DiscountAmount], [FinalAmount], [PaymentMethod], [CarrierType], [CarrierNum], [OrderStatus], [OrderSort]) VALUES (41, '2026-07-31 05:13:34.413', N'外帶', 1, 90, 0, 90, N'信用卡', N'手機條碼', N'/5D2H2A', 1, 1);
INSERT INTO [dbo].[Orders] ([OrderID], [OrderDate], [OrderType], [MemberID], [OriginalTotal], [DiscountAmount], [FinalAmount], [PaymentMethod], [CarrierType], [CarrierNum], [OrderStatus], [OrderSort]) VALUES (42, '2026-07-31 05:14:10.947', N'外帶', 1, 160, 0, 160, N'信用卡', N'手機條碼', N'/5D2H2A', 1, 1);
SET IDENTITY_INSERT [dbo].[Orders] OFF;
GO

-- Data for OrderDetails (86 rows)
SET IDENTITY_INSERT [dbo].[OrderDetails] ON;
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (1, 1, 8, 1, N'', 65, N'經典波士頓派', 65);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (2, 2, 2, 1, N'', 90, N'耶加雪菲手沖', 90);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (3, 2, 1, 1, N'', 60, N'莊園級美式', 60);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (4, 3, 2, 1, N'', 90, N'耶加雪菲手沖', 90);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (5, 4, 8, 1, N'', 65, N'經典波士頓派', 65);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (6, 5, 2, 1, N'
備註: HIHI', 90, N'耶加雪菲手沖', 90);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (7, 6, 2, 1, N'微冰 / 半糖', 90, N'耶加雪菲手沖', 90);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (8, 7, 1, 1, N'XL / 微冰 / 7分糖 / 123', 70, N'莊園級美式', 70);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (9, 8, 1, 1, N'XL / 熱飲 / 無糖', 70, N'莊園級美式', 70);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (10, 9, 9, 1, N'我要奶精x1', 120, N'阿拉比卡咖啡', 120);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (11, 9, 8, 1, N'不需要餐具', 65, N'經典波士頓派', 65);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (12, 9, 5, 1, N'不需要餐具', 40, N'磚壓麥香豬肉排', 40);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (13, 10, 2, 1, N'XL / 熱飲 / 微糖', 100, N'耶加雪菲手沖', 100);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (14, 11, 1, 2, N'XL / 熱飲 / 7分糖 / 我要美女店員的電話', 70, N'莊園級美式', 140);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (15, 11, 2, 3, N'XL / 微冰 / 7分糖', 100, N'耶加雪菲手沖', 300);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (16, 12, 1, 3, N'XL / 微冰 / 微糖', 70, N'莊園級美式', 210);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (17, 12, 7, 1, N'不需要餐具', 60, N'法式檸檬塔', 60);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (18, 13, 2, 1, N'XL / 熱飲 / 微糖', 100, N'耶加雪菲手沖', 100);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (19, 14, 1, 1, N'M / 正常冰 / 正常甜', 60, N'莊園級美式', 60);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (20, 15, 1, 1, N'XL / 微糖 / 少冰', 70, N'莊園級美式', 70);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (21, 16, 1, 1, N'M / 正常甜 / 超多冰', 62, N'莊園級美式', 62);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (22, 16, 2, 1, N'M / 正常甜 / 超多冰', 92, N'耶加雪菲手沖', 92);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (23, 16, 13, 1, N'', 80, N'焦糖瑪奇朵', 80);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (24, 17, 1, 1, N'M / 正常甜 / 超多冰', 62, N'莊園級美式', 62);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (25, 17, 2, 1, N'M / 正常甜 / 超多冰', 92, N'耶加雪菲手沖', 92);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (26, 17, 13, 1, N'', 80, N'焦糖瑪奇朵', 80);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (27, 17, 9, 1, N'', 120, N'阿拉比卡咖啡', 120);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (28, 17, 11, 1, N'', 70, N'摩卡咖啡', 70);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (29, 17, 3, 1, N'M / 正常甜 / 超多冰', 82, N'莊園級拿鐵', 82);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (30, 17, 4, 1, N'M / 正常甜 / 超多冰', 62, N'小農雪點鮮奶茶', 62);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (31, 18, 1, 1, N'M / 正常甜 / 超多冰', 62, N'莊園級美式', 62);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (32, 18, 2, 1, N'M / 正常甜 / 超多冰', 92, N'耶加雪菲手沖', 92);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (33, 18, 13, 1, N'', 80, N'焦糖瑪奇朵', 80);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (34, 18, 11, 1, N'', 70, N'摩卡咖啡', 70);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (35, 18, 9, 1, N'', 120, N'阿拉比卡咖啡', 120);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (36, 19, 1, 1, N'M / 正常甜 / 超多冰', 62, N'莊園級美式', 62);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (37, 19, 2, 1, N'M / 正常甜 / 超多冰', 92, N'耶加雪菲手沖', 92);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (38, 19, 13, 1, N'', 80, N'焦糖瑪奇朵', 80);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (39, 19, 11, 1, N'', 70, N'摩卡咖啡', 70);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (40, 19, 9, 1, N'', 120, N'阿拉比卡咖啡', 120);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (41, 19, 3, 1, N'M / 正常甜 / 超多冰', 82, N'莊園級拿鐵', 82);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (42, 19, 4, 1, N'M / 正常甜 / 超多冰', 62, N'小農雪點鮮奶茶', 62);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (43, 19, 6, 1, N'需要餐具', 55, N'軟歐藏心貝果', 55);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (44, 19, 5, 1, N'需要餐具', 40, N'磚壓麥香牛肉排', 40);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (45, 19, 7, 1, N'需要餐具', 60, N'法式檸檬塔', 60);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (46, 19, 8, 1, N'需要餐具', 65, N'經典波士頓派', 65);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (47, 20, 1, 1, N'M / 正常甜 / 超多冰', 62, N'莊園級美式', 62);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (48, 20, 2, 1, N'M / 正常甜 / 超多冰', 92, N'耶加雪菲手沖', 92);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (49, 20, 13, 1, N'', 80, N'焦糖瑪奇朵', 80);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (50, 20, 9, 1, N'', 120, N'阿拉比卡咖啡', 120);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (51, 20, 11, 1, N'', 70, N'摩卡咖啡', 70);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (52, 20, 7, 1, N'需要餐具', 60, N'法式檸檬塔', 60);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (53, 20, 8, 1, N'需要餐具', 65, N'經典波士頓派', 65);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (54, 20, 6, 1, N'需要餐具', 55, N'軟歐藏心貝果', 55);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (55, 20, 5, 1, N'需要餐具', 40, N'磚壓麥香牛肉排', 40);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (56, 20, 3, 1, N'M / 正常甜 / 超多冰', 82, N'莊園級拿鐵', 82);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (57, 20, 4, 1, N'M / 正常甜 / 超多冰', 62, N'小農雪點鮮奶茶', 62);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (58, 21, 1, 1, N'M / 正常甜 / 超多冰', 62, N'莊園級美式', 62);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (59, 21, 2, 1, N'M / 正常甜 / 超多冰', 92, N'耶加雪菲手沖', 92);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (60, 21, 13, 1, N'', 80, N'焦糖瑪奇朵', 80);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (61, 21, 11, 1, N'', 70, N'摩卡咖啡', 70);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (62, 21, 9, 1, N'', 120, N'阿拉比卡咖啡', 120);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (63, 22, 1, 1, N'M / 正常甜 / 超多冰', 62, N'莊園級美式', 62);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (64, 23, 2, 1, N'M / 正常甜 / 超多冰', 92, N'耶加雪菲手沖', 92);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (65, 24, 1, 1, N'M / 正常甜 / 超多冰', 62, N'莊園級美式', 62);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (66, 25, 1, 1, N'XL / 正常甜 / 超多冰', 72, N'莊園級美式', 72);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (67, 26, 2, 1, N'M / 正常甜 / 超多冰', 92, N'耶加雪菲手沖', 92);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (68, 27, 2, 1, N'M / 正常甜 / 超多冰', 92, N'耶加雪菲手沖', 92);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (69, 28, 2, 1, N'M / 正常甜 / 超多冰', 92, N'耶加雪菲手沖', 92);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (70, 29, 1, 1, N'M / 正常甜 / 超多冰', 62, N'莊園級美式', 62);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (71, 30, 2, 1, N'M / 正常甜 / 超多冰', 92, N'耶加雪菲手沖', 92);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (72, 31, 2, 1, N'M / 正常甜 / 超多冰', 92, N'耶加雪菲手沖', 92);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (73, 32, 13, 1, N'', 80, N'焦糖瑪奇朵', 80);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (74, 32, 2, 1, N'M / 正常甜 / 超多冰', 92, N'耶加雪菲手沖', 92);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (75, 32, 9, 1, N'', 120, N'阿拉比卡咖啡', 120);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (76, 33, 1, 1, N'M / 正常甜 / 超多冰', 62, N'莊園級美式', 62);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (77, 34, 2, 1, N'M / 正常甜 / 超多冰', 92, N'耶加雪菲手沖', 92);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (78, 35, 9, 1, N'', 120, N'阿拉比卡咖啡', 120);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (79, 36, 2, 1, N'M / 正常甜 / 超多冰', 92, N'耶加雪菲手沖', 92);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (80, 37, 9, 1, N'', 120, N'阿拉比卡咖啡', 120);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (81, 38, 10, 1, N'XL / 微糖 / 超多冰', 92, N'卡布奇諾', 92);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (82, 39, 8, 1, N'需要餐具', 65, N'經典波士頓派', 65);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (83, 40, 10, 1, N'XL / 微糖 / 微冰', 90, N'卡布奇諾', 90);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (84, 41, 3, 1, N'XL / 微糖 / 少冰', 90, N'莊園級拿鐵', 90);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (85, 42, 3, 1, N'XL / 正常甜 / 微冰', 90, N'莊園級拿鐵', 90);
INSERT INTO [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [SpecString], [UnitPrice], [ProductName], [Subtotal]) VALUES (86, 42, 4, 1, N'XL / 微糖 / 正常冰', 70, N'小農雪點鮮奶茶', 70);
SET IDENTITY_INSERT [dbo].[OrderDetails] OFF;
GO

-- Data for LoginLog (86 rows)
SET IDENTITY_INSERT [dbo].[LoginLog] ON;
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (14, N'master', '2026-07-29 22:25:57.227', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (15, N'master', '2026-07-29 22:37:14.460', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (16, N'master', '2026-07-29 22:38:00.513', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (17, N'master', '2026-07-29 22:40:50.683', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (18, N'master', '2026-07-30 04:41:25.490', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (19, N'Master', '2026-07-30 04:46:29.350', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (20, N'Master', '2026-07-30 04:59:29.320', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Failed');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (25, N'chou', '2026-07-30 05:20:04.470', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Failed');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (26, N'chou', '2026-07-30 05:20:05.173', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Failed');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (27, N'chou', '2026-07-30 05:20:05.810', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Failed');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (28, N'chou', '2026-07-30 05:20:06.113', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Failed');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (29, N'chou', '2026-07-30 05:20:06.347', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Failed');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (30, N'chou', '2026-07-30 05:20:06.783', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Failed');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (31, N'chou', '2026-07-30 05:20:10.313', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Failed');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (32, N'chou', '2026-07-30 05:21:52.850', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Failed');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (33, N'master', '2026-07-30 05:22:34.200', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (34, N'liu', '2026-07-30 05:23:31.860', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Failed');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (35, N'Liu', '2026-07-30 05:23:42.240', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (36, N'123', '2026-07-30 05:24:44.553', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Failed');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (37, N'21313', '2026-07-30 05:25:32.170', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Failed');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (38, N'21313', '2026-07-30 05:25:33.353', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Failed');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (39, N'21313', '2026-07-30 05:25:33.893', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Failed');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (40, N'21313', '2026-07-30 05:25:34.403', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Failed');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (41, N'21313', '2026-07-30 05:25:34.873', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Failed');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (42, N'21313', '2026-07-30 05:25:35.317', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Failed');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (43, N'21313', '2026-07-30 05:25:35.873', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Failed');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (44, N'21313', '2026-07-30 05:25:36.240', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Failed');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (45, N'21313', '2026-07-30 05:25:38.340', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Failed');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (46, N'21313', '2026-07-30 05:25:38.510', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Failed');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (47, N'21313', '2026-07-30 05:25:38.667', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Failed');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (48, N'21313', '2026-07-30 05:25:38.827', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Failed');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (49, N'21313', '2026-07-30 05:25:38.980', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Failed');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (50, N'21313', '2026-07-30 05:25:39.140', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Failed');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (51, N'21313', '2026-07-30 05:25:39.317', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Failed');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (52, N'21313', '2026-07-30 05:25:39.483', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Failed');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (53, N'21313', '2026-07-30 05:25:39.670', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Failed');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (54, N'21313', '2026-07-30 05:25:39.860', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Failed');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (55, N'21313', '2026-07-30 05:25:40.050', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Failed');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (56, N'21313', '2026-07-30 05:25:40.257', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Failed');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (57, N'21313', '2026-07-30 05:25:40.490', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Failed');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (58, N'master', '2026-07-30 05:26:22.490', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (59, N'master', '2026-07-30 05:27:09.550', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (60, N'master', '2026-07-30 07:14:14.833', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (61, N'master', '2026-07-30 07:14:29.100', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (62, N'master', '2026-07-30 07:18:37.270', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (63, N'master', '2026-07-30 07:30:06.900', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (64, N'master', '2026-07-30 07:41:42.690', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (65, N'master', '2026-07-30 07:51:41.217', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (66, N'master', '2026-07-30 07:54:37.077', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (67, N'master', '2026-07-31 02:30:32.650', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (68, N'Liugihao', '2026-07-31 02:34:05.947', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (69, N'master', '2026-07-31 02:35:09.353', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (70, N'Liugihao', '2026-07-31 02:36:19.517', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (71, N'Liugihao', '2026-07-31 02:39:30.813', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (72, N'master', '2026-07-31 02:43:35.117', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (73, N'master', '2026-07-31 02:49:53.630', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (74, N'master', '2026-07-31 02:51:32.287', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (75, N'master', '2026-07-31 02:52:28.790', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (76, N'master', '2026-07-31 02:54:09.683', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (77, N'master', '2026-07-31 02:57:16.057', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (78, N'master', '2026-07-31 03:00:18.367', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (79, N'Liugihao', '2026-07-31 03:00:39.507', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (80, N'Liugihao', '2026-07-31 03:01:47.940', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (81, N'master', '2026-07-31 03:07:42.173', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (82, N'Liugihao', '2026-07-31 03:09:42.247', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (83, N'master', '2026-07-31 03:11:28.053', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (84, N'master', '2026-07-31 03:12:17.013', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (85, N'master', '2026-07-31 03:12:50.670', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (86, N'master', '2026-07-31 03:13:26.570', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (87, N'Liugihao', '2026-07-31 03:13:55.753', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (88, N'master', '2026-07-31 03:16:19.003', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (89, N'Liugihao', '2026-07-31 03:16:38.317', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (90, N'master', '2026-07-31 04:08:51.177', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (91, N'master', '2026-07-31 04:53:13.827', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (92, N'master', '2026-07-31 05:23:49.070', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (93, N'master', '2026-07-31 05:34:06.973', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (94, N'master', '2026-07-31 05:37:58.510', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (95, N'master', '2026-07-31 05:42:58.583', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (96, N'master', '2026-07-31 05:46:13.387', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (97, N'master', '2026-07-31 05:48:34.700', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (98, N'master', '2026-07-31 05:49:27.727', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (99, N'master', '2026-07-31 05:56:40.567', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (100, N'master', '2026-07-31 06:00:42.933', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (101, N'master', '2026-07-31 06:05:09.570', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (102, N'master', '2026-07-31 06:06:37.277', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
INSERT INTO [dbo].[LoginLog] ([LogID], [Username], [AttemptTime], [IPAddress], [MachineName], [Status]) VALUES (103, N'master', '2026-07-31 06:08:18.700', N'192.168.1.252', N'DESKTOP-5HF1CBQ', N'Success');
SET IDENTITY_INSERT [dbo].[LoginLog] OFF;
GO

