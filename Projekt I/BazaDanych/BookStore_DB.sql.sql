USE [BookStore]
GO
/****** Object:  Table [dbo].[Cart]    Script Date: 25.05.2020 15:46:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cart](
	[Order_ID] [nvarchar](50) NOT NULL,
	[Customer_ID] [nvarchar](50) NULL,
	[Book_name] [nvarchar](250) NULL,
	[Price] [nvarchar](50) NULL,
	[Amount] [nvarchar](50) NULL,
 CONSTRAINT [PK_Cart] PRIMARY KEY CLUSTERED 
(
	[Order_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 25.05.2020 15:46:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[Customer_ID] [varchar](55) NOT NULL,
	[First_name] [varchar](55) NULL,
	[Last_name] [varchar](55) NULL,
	[Customer_City] [varchar](55) NULL,
	[Customer_Street] [varchar](55) NULL,
	[Customer_PCode] [varchar](55) NOT NULL,
	[Customer_email] [varchar](55) NULL,
	[Customer_phone] [varchar](55) NOT NULL,
	[Customer_password] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Customer_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order_Items]    Script Date: 25.05.2020 15:46:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order_Items](
	[Item_ID] [varchar](55) NOT NULL,
	[Order_ID] [varchar](55) NOT NULL,
	[Stock_ID] [varchar](55) NOT NULL,
	[isbn] [varchar](55) NOT NULL,
	[Supplier_ID] [varchar](55) NOT NULL,
	[Retail_Price] [varchar](55) NULL,
	[Qty_sold] [varchar](55) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Item_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 25.05.2020 15:46:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Order_ID] [varchar](55) NOT NULL,
	[Customer_ID] [varchar](55) NOT NULL,
	[Order_Date] [varchar](55) NULL,
	[Credit_card_numb] [varchar](55) NOT NULL,
	[Credit_card_expiry] [varchar](55) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Order_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Returns]    Script Date: 25.05.2020 15:46:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Returns](
	[Return_ID] [varchar](55) NOT NULL,
	[Item_ID] [varchar](55) NOT NULL,
	[Stock_ID] [varchar](55) NOT NULL,
	[Retail_Price] [varchar](55) NULL,
PRIMARY KEY CLUSTERED 
(
	[Return_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[STOCK]    Script Date: 25.05.2020 15:46:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[STOCK](
	[STOCK_ID] [varchar](55) NOT NULL,
	[isbn] [varchar](55) NOT NULL,
	[Author_name] [varchar](55) NULL,
	[Title_name] [varchar](55) NULL,
	[Publisher_name] [varchar](55) NULL,
	[Published_year] [varchar](55) NULL,
	[Supplier_ID] [varchar](55) NOT NULL,
	[Retail_price] [varchar](55) NULL,
PRIMARY KEY CLUSTERED 
(
	[STOCK_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 25.05.2020 15:46:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[Supplier_ID] [varchar](55) NOT NULL,
	[Stock_ID] [varchar](55) NOT NULL,
	[Supplier_name] [varchar](55) NOT NULL,
	[Supplier_City] [varchar](55) NULL,
	[Supplier_Street] [varchar](55) NULL,
	[Supplier_PCode] [varchar](55) NOT NULL,
	[Supplier_email] [varchar](55) NULL,
	[Supplier_phone] [varchar](55) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Supplier_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Cart] ([Order_ID], [Customer_ID], [Book_name], [Price], [Amount]) VALUES (N'0', N'69', N'The Lord of the Rings : The two towers', N'20.99', N'2')
INSERT [dbo].[Cart] ([Order_ID], [Customer_ID], [Book_name], [Price], [Amount]) VALUES (N'1215849278', N'27', N'The Lord of the Rings : The two towers', N'20.99', N'2')
INSERT [dbo].[Cart] ([Order_ID], [Customer_ID], [Book_name], [Price], [Amount]) VALUES (N'1293985759', N'27', N'The Lord of the Rings : Return of the King', N'29.99', N'3')
INSERT [dbo].[Cart] ([Order_ID], [Customer_ID], [Book_name], [Price], [Amount]) VALUES (N'2', N'69', N'The Lord of the Rings : The two towers', N'20.99', N'4')
INSERT [dbo].[Cart] ([Order_ID], [Customer_ID], [Book_name], [Price], [Amount]) VALUES (N'3', N'69', N'The Lord of the Rings : Return of the King', N'29.99', N'5')
INSERT [dbo].[Customers] ([Customer_ID], [First_name], [Last_name], [Customer_City], [Customer_Street], [Customer_PCode], [Customer_email], [Customer_phone], [Customer_password]) VALUES (N'22', N'Nicki', N'Clifford', N'Dublin', N'88 south lotts', N'D4', N'Nickiclif@hotmail.com', N'0876662222', NULL)
INSERT [dbo].[Customers] ([Customer_ID], [First_name], [Last_name], [Customer_City], [Customer_Street], [Customer_PCode], [Customer_email], [Customer_phone], [Customer_password]) VALUES (N'23', N'Lyn', N'Russell', N'Dublin', N'87 Claremont ave', N'D5', N'lyna@hotmail.com', N'0877777222', NULL)
INSERT [dbo].[Customers] ([Customer_ID], [First_name], [Last_name], [Customer_City], [Customer_Street], [Customer_PCode], [Customer_email], [Customer_phone], [Customer_password]) VALUES (N'24', N'fay', N'Allen', N'Dublin', N'88 Serpentine ave', N'D3', N'fay@hotmail.com', N'0877777111', NULL)
INSERT [dbo].[Customers] ([Customer_ID], [First_name], [Last_name], [Customer_City], [Customer_Street], [Customer_PCode], [Customer_email], [Customer_phone], [Customer_password]) VALUES (N'25', N'Rose', N'Curry', N'Waterford', N'203 Glennmore road', N'6152', N'Rose@gmail.com', N'0871118930', NULL)
INSERT [dbo].[Customers] ([Customer_ID], [First_name], [Last_name], [Customer_City], [Customer_Street], [Customer_PCode], [Customer_email], [Customer_phone], [Customer_password]) VALUES (N'26', N'Geraldine', N'Allen', N'Dublin', N'233 Farney Park', N'D4', N'Geraldine@gmail.com', N'0868302810', NULL)
INSERT [dbo].[Customers] ([Customer_ID], [First_name], [Last_name], [Customer_City], [Customer_Street], [Customer_PCode], [Customer_email], [Customer_phone], [Customer_password]) VALUES (N'27', N'Len', N'Allen', N'Wexford', N'15 Waterside road', N'051', N'len@gmail.com', N'0871113940', N'1234')
INSERT [dbo].[Customers] ([Customer_ID], [First_name], [Last_name], [Customer_City], [Customer_Street], [Customer_PCode], [Customer_email], [Customer_phone], [Customer_password]) VALUES (N'29', N'Nick', N'Burridge', N'Aukland', N'333 bayside ave', N'NZ 22', N'NickB@gmail.com', N'0053-111-8930', N'4321')
INSERT [dbo].[Customers] ([Customer_ID], [First_name], [Last_name], [Customer_City], [Customer_Street], [Customer_PCode], [Customer_email], [Customer_phone], [Customer_password]) VALUES (N'30', N'Paul', N'Weldon', N'Melboure', N'33 Golden Point road', N'AUS 331-00', N'Paulyweldon@gmail.com', N'051 -200-3421 ', N'2468')
INSERT [dbo].[Customers] ([Customer_ID], [First_name], [Last_name], [Customer_City], [Customer_Street], [Customer_PCode], [Customer_email], [Customer_phone], [Customer_password]) VALUES (N'32', N'Ben', N'Freeney', N'London', N'22 Bow lane', N'P.O.BOX 152', N'BenFoom@gmail.com', N'0044 74738930', NULL)
INSERT [dbo].[Customers] ([Customer_ID], [First_name], [Last_name], [Customer_City], [Customer_Street], [Customer_PCode], [Customer_email], [Customer_phone], [Customer_password]) VALUES (N'57', N'Mike', N'Start', N'Berlin', N'203 Kreuzberg ZOSSENER STR 33, KREUZBERG', N'BER 22', N'start@gmail.com', N'0041 118930', NULL)
INSERT [dbo].[Customers] ([Customer_ID], [First_name], [Last_name], [Customer_City], [Customer_Street], [Customer_PCode], [Customer_email], [Customer_phone], [Customer_password]) VALUES (N'68', N'Cian', N'Ellis', N'Toronto', N'apt 301 tower street', N'CA 152', N'Scian@gmail.com', N'0064 7456575930', NULL)
INSERT [dbo].[Customers] ([Customer_ID], [First_name], [Last_name], [Customer_City], [Customer_Street], [Customer_PCode], [Customer_email], [Customer_phone], [Customer_password]) VALUES (N'69', N'Kuba', N'Sala', N'Tres', N'Malaf', N'32123', N'js@gmail.com', N'999888777', N'12344')
INSERT [dbo].[Customers] ([Customer_ID], [First_name], [Last_name], [Customer_City], [Customer_Street], [Customer_PCode], [Customer_email], [Customer_phone], [Customer_password]) VALUES (N'70', N'Alan', N'Alanek', N'ddd', N'ddd', N'ddd', N'ddd', N'1233213', N'4321')
INSERT [dbo].[Order_Items] ([Item_ID], [Order_ID], [Stock_ID], [isbn], [Supplier_ID], [Retail_Price], [Qty_sold]) VALUES (N'ITM007', N'ORD691', N'STK001', N'0-410-121-1', N'SUP001', N'16.99', N'1')
INSERT [dbo].[Order_Items] ([Item_ID], [Order_ID], [Stock_ID], [isbn], [Supplier_ID], [Retail_Price], [Qty_sold]) VALUES (N'ITM008', N'ORD022', N'STK002', N'0-230-166-1', N'SUP002', N'26.99', N'1')
INSERT [dbo].[Order_Items] ([Item_ID], [Order_ID], [Stock_ID], [isbn], [Supplier_ID], [Retail_Price], [Qty_sold]) VALUES (N'ITM009', N'ORD391', N'STK003', N'0-090-881-1', N'SUP003', N'22.99', N'1')
INSERT [dbo].[Order_Items] ([Item_ID], [Order_ID], [Stock_ID], [isbn], [Supplier_ID], [Retail_Price], [Qty_sold]) VALUES (N'ITM010', N'ORD067', N'STK004', N'0-22-121-1', N'SUP004', N'20.99', N'1')
INSERT [dbo].[Order_Items] ([Item_ID], [Order_ID], [Stock_ID], [isbn], [Supplier_ID], [Retail_Price], [Qty_sold]) VALUES (N'ITM011', N'ORD054', N'STK005', N'0-413-331-1', N'SUP005', N'29.99', N'1')
INSERT [dbo].[Order_Items] ([Item_ID], [Order_ID], [Stock_ID], [isbn], [Supplier_ID], [Retail_Price], [Qty_sold]) VALUES (N'ITM012', N'ORD097', N'STK006', N'9-330-121-1', N'SUP006', N'29.99', N'1')
INSERT [dbo].[Order_Items] ([Item_ID], [Order_ID], [Stock_ID], [isbn], [Supplier_ID], [Retail_Price], [Qty_sold]) VALUES (N'ITM013', N'ORD093', N'STK007', N'0-410-9921-1', N'SUP007', N'28.99', N'1')
INSERT [dbo].[Order_Items] ([Item_ID], [Order_ID], [Stock_ID], [isbn], [Supplier_ID], [Retail_Price], [Qty_sold]) VALUES (N'ITM014', N'ORD0013', N'STK008', N'0-413-121-1', N'SUP008', N'19.99', N'1')
INSERT [dbo].[Order_Items] ([Item_ID], [Order_ID], [Stock_ID], [isbn], [Supplier_ID], [Retail_Price], [Qty_sold]) VALUES (N'ITM015', N'ORD117', N'STK009', N'0-310-331-1', N'SUP009', N'21.99', N'1')
INSERT [dbo].[Order_Items] ([Item_ID], [Order_ID], [Stock_ID], [isbn], [Supplier_ID], [Retail_Price], [Qty_sold]) VALUES (N'ITM016', N'ORD127', N'STK010', N'5-110-121-1', N'SUP010', N'29.99', N'1')
INSERT [dbo].[Orders] ([Order_ID], [Customer_ID], [Order_Date], [Credit_card_numb], [Credit_card_expiry]) VALUES (N'ORD0013', N'30', N'1-11-2016', N'158-35-543', N'09-17')
INSERT [dbo].[Orders] ([Order_ID], [Customer_ID], [Order_Date], [Credit_card_numb], [Credit_card_expiry]) VALUES (N'ORD022', N'23', N'12-05-2016', N'1217-11-283', N'08-17')
INSERT [dbo].[Orders] ([Order_ID], [Customer_ID], [Order_Date], [Credit_card_numb], [Credit_card_expiry]) VALUES (N'ORD054', N'26', N'1-08-2016', N'1448-33-443', N'07-17')
INSERT [dbo].[Orders] ([Order_ID], [Customer_ID], [Order_Date], [Credit_card_numb], [Credit_card_expiry]) VALUES (N'ORD067', N'25', N'14-11-2016', N'1788-33-443', N'05-17')
INSERT [dbo].[Orders] ([Order_ID], [Customer_ID], [Order_Date], [Credit_card_numb], [Credit_card_expiry]) VALUES (N'ORD093', N'29', N'26-09-2016', N'2288-13-543', N'05-18')
INSERT [dbo].[Orders] ([Order_ID], [Customer_ID], [Order_Date], [Credit_card_numb], [Credit_card_expiry]) VALUES (N'ORD097', N'27', N'23-10-2016', N'9488-33-293', N'06-17')
INSERT [dbo].[Orders] ([Order_ID], [Customer_ID], [Order_Date], [Credit_card_numb], [Credit_card_expiry]) VALUES (N'ORD117', N'32', N'13-07-2016', N'1111-33-343', N'05-17')
INSERT [dbo].[Orders] ([Order_ID], [Customer_ID], [Order_Date], [Credit_card_numb], [Credit_card_expiry]) VALUES (N'ORD127', N'57', N'23-09-2015', N'4444-63-446', N'07-17')
INSERT [dbo].[Orders] ([Order_ID], [Customer_ID], [Order_Date], [Credit_card_numb], [Credit_card_expiry]) VALUES (N'ORD337', N'68', N'23-05-2016', N'8888-33-443', N'08-17')
INSERT [dbo].[Orders] ([Order_ID], [Customer_ID], [Order_Date], [Credit_card_numb], [Credit_card_expiry]) VALUES (N'ORD391', N'24', N'13-06-2015', N'8717-22-243', N'09-17')
INSERT [dbo].[Orders] ([Order_ID], [Customer_ID], [Order_Date], [Credit_card_numb], [Credit_card_expiry]) VALUES (N'ORD691', N'22', N'13-10-2016', N'1717-22-233', N'11-17')
INSERT [dbo].[Returns] ([Return_ID], [Item_ID], [Stock_ID], [Retail_Price]) VALUES (N'RTN001', N'ITM007', N'STK001', N'16.99')
INSERT [dbo].[Returns] ([Return_ID], [Item_ID], [Stock_ID], [Retail_Price]) VALUES (N'RTN002', N'ITM008', N'STK002', N'26.99')
INSERT [dbo].[Returns] ([Return_ID], [Item_ID], [Stock_ID], [Retail_Price]) VALUES (N'RTN003', N'ITM009', N'STK003', N'22.99')
INSERT [dbo].[Returns] ([Return_ID], [Item_ID], [Stock_ID], [Retail_Price]) VALUES (N'RTN004', N'ITM010', N'STK004', N'20.99')
INSERT [dbo].[Returns] ([Return_ID], [Item_ID], [Stock_ID], [Retail_Price]) VALUES (N'RTN005', N'ITM011', N'STK005', N'29.99')
INSERT [dbo].[Returns] ([Return_ID], [Item_ID], [Stock_ID], [Retail_Price]) VALUES (N'RTN006', N'ITM012', N'STK006', N'29.99')
INSERT [dbo].[Returns] ([Return_ID], [Item_ID], [Stock_ID], [Retail_Price]) VALUES (N'RTN007', N'ITM011', N'STK007', N'28.99')
INSERT [dbo].[Returns] ([Return_ID], [Item_ID], [Stock_ID], [Retail_Price]) VALUES (N'RTN008', N'ITM012', N'STK008', N'19.99')
INSERT [dbo].[Returns] ([Return_ID], [Item_ID], [Stock_ID], [Retail_Price]) VALUES (N'RTN009', N'ITM013', N'STK009', N'21.99')
INSERT [dbo].[Returns] ([Return_ID], [Item_ID], [Stock_ID], [Retail_Price]) VALUES (N'RTN010', N'ITM014', N'STK010', N'29.99')
INSERT [dbo].[STOCK] ([STOCK_ID], [isbn], [Author_name], [Title_name], [Publisher_name], [Published_year], [Supplier_ID], [Retail_price]) VALUES (N'STK001', N'0-332-3233-4', N'J.R.R Tolken', N'The Hobbit', N'Allen & Unwin', N'1937', N'SUP001', N'16.99')
INSERT [dbo].[STOCK] ([STOCK_ID], [isbn], [Author_name], [Title_name], [Publisher_name], [Published_year], [Supplier_ID], [Retail_price]) VALUES (N'STK002', N'0-3113-443-4', N'J.R.R Tolken', N'The Lord of the Rings : Fellowship of the ring', N'Allen & Unwin', N'2000', N'SUP002', N'26.99')
INSERT [dbo].[STOCK] ([STOCK_ID], [isbn], [Author_name], [Title_name], [Publisher_name], [Published_year], [Supplier_ID], [Retail_price]) VALUES (N'STK003', N'0-113-473-8', N'J.R.R Tolken', N'The Lord of the Rings : The two towers', N'Allen & Unwin', N'2006', N'SUP003', N'20.99')
INSERT [dbo].[STOCK] ([STOCK_ID], [isbn], [Author_name], [Title_name], [Publisher_name], [Published_year], [Supplier_ID], [Retail_price]) VALUES (N'STK004', N'0-993-433-3', N'J.R.R Tolken', N'The Lord of the Rings : Return of the King', N'Allen & Unwin', N'2014', N'SUP004', N'29.99')
INSERT [dbo].[STOCK] ([STOCK_ID], [isbn], [Author_name], [Title_name], [Publisher_name], [Published_year], [Supplier_ID], [Retail_price]) VALUES (N'STK005', N'0-293-333-6', N'Tanith Lee', N'The Castle of Dark', N'Macmilla', N'1987', N'SUP005', N'29.99')
INSERT [dbo].[STOCK] ([STOCK_ID], [isbn], [Author_name], [Title_name], [Publisher_name], [Published_year], [Supplier_ID], [Retail_price]) VALUES (N'STK006', N'0-023-179-4', N'Tanith Lee', N'The Winter Players', N'Macmilla', N'1977', N'SUP006', N'29.99')
INSERT [dbo].[STOCK] ([STOCK_ID], [isbn], [Author_name], [Title_name], [Publisher_name], [Published_year], [Supplier_ID], [Retail_price]) VALUES (N'STK007', N'0-023-179-3', N'Edgar Rice Burroughs', N'Tarzan and the forbidden city', N'New English Library', N'1914', N'SUP007', N'28.99')
INSERT [dbo].[STOCK] ([STOCK_ID], [isbn], [Author_name], [Title_name], [Publisher_name], [Published_year], [Supplier_ID], [Retail_price]) VALUES (N'STK008', N'0-113-139-6', N'Edgar Rice Burroughs', N'Tarzan of the Apes', N'New English Library', N'1999', N'SUP008', N'19.99')
INSERT [dbo].[STOCK] ([STOCK_ID], [isbn], [Author_name], [Title_name], [Publisher_name], [Published_year], [Supplier_ID], [Retail_price]) VALUES (N'STK009', N'0-444-139-6', N'Robert Ludlum', N'The Gemini Contenders', N'Dial Press', N'2009', N'SUP009', N'21.99')
INSERT [dbo].[STOCK] ([STOCK_ID], [isbn], [Author_name], [Title_name], [Publisher_name], [Published_year], [Supplier_ID], [Retail_price]) VALUES (N'STK010', N'0-433-439-6', N'Robert Ludlum', N'Chancellor Manuscript', N'Dial Press', N'1999', N'SUP010', N'29.99')
INSERT [dbo].[STOCK] ([STOCK_ID], [isbn], [Author_name], [Title_name], [Publisher_name], [Published_year], [Supplier_ID], [Retail_price]) VALUES (N'STK011', N'0-430-131-6', N'James Clavel', N'Dragon Flight', N'Atheneum', N'2007', N'SUP011', N'16.95')
INSERT [dbo].[STOCK] ([STOCK_ID], [isbn], [Author_name], [Title_name], [Publisher_name], [Published_year], [Supplier_ID], [Retail_price]) VALUES (N'STK012', N'0-410-121-1', N'Venessa Walters', N'Summer Return', N'Penguin', N'2016', N'SUP012', N'16.99')
INSERT [dbo].[STOCK] ([STOCK_ID], [isbn], [Author_name], [Title_name], [Publisher_name], [Published_year], [Supplier_ID], [Retail_price]) VALUES (N'STK013', N'0-230-166-1', N'Anne Rice', N'Tale of the Thief', N'Penguin', N'2016', N'SUP013', N'26.99')
INSERT [dbo].[STOCK] ([STOCK_ID], [isbn], [Author_name], [Title_name], [Publisher_name], [Published_year], [Supplier_ID], [Retail_price]) VALUES (N'STK014', N'0-090-881-1', N'Mark Stevenson', N'Prince and the Pauper', N'American Pushlishing Co', N'2011', N'SUP014', N'22.99')
INSERT [dbo].[STOCK] ([STOCK_ID], [isbn], [Author_name], [Title_name], [Publisher_name], [Published_year], [Supplier_ID], [Retail_price]) VALUES (N'STK015', N'0-22-121-1', N'Ribbly Scott', N'Alien', N'Morpheus', N'1996', N'SUP015', N'20.99')
INSERT [dbo].[STOCK] ([STOCK_ID], [isbn], [Author_name], [Title_name], [Publisher_name], [Published_year], [Supplier_ID], [Retail_price]) VALUES (N'STK016', N'0-413-331-1', N'James Clavell', N'Gone Girl', N'Paramount', N'2015', N'SUP016', N'29.99')
INSERT [dbo].[STOCK] ([STOCK_ID], [isbn], [Author_name], [Title_name], [Publisher_name], [Published_year], [Supplier_ID], [Retail_price]) VALUES (N'STK017', N'9-330-121-1', N'Megan Miranda', N'All the Missing Girls', N'H & R', N'2016', N'SUP017', N'29.99')
INSERT [dbo].[STOCK] ([STOCK_ID], [isbn], [Author_name], [Title_name], [Publisher_name], [Published_year], [Supplier_ID], [Retail_price]) VALUES (N'STK018', N'0-410-9921-1', N'Sarah Mass', N'Empire of Storms', N'Pearson Plc', N'2006', N'SUP018', N'28.99')
INSERT [dbo].[STOCK] ([STOCK_ID], [isbn], [Author_name], [Title_name], [Publisher_name], [Published_year], [Supplier_ID], [Retail_price]) VALUES (N'STK019', N'0-413-121-1', N'J.D Vance', N'Hillbilly Elegy', N'Wiley publisher', N'2012', N'SUP019', N'19.99')
INSERT [dbo].[STOCK] ([STOCK_ID], [isbn], [Author_name], [Title_name], [Publisher_name], [Published_year], [Supplier_ID], [Retail_price]) VALUES (N'STK020', N'0-310-331-1', N'Joe Hill', N'The Fire Man', N'Scholastic', N'2016', N'SUP019', N'21.99')
INSERT [dbo].[STOCK] ([STOCK_ID], [isbn], [Author_name], [Title_name], [Publisher_name], [Published_year], [Supplier_ID], [Retail_price]) VALUES (N'STK021', N'5-110-121-1', N'Lee Child', N'Night School', N'Pearson publisher', N'2015', N'SUP020', N'29.99')
INSERT [dbo].[Suppliers] ([Supplier_ID], [Stock_ID], [Supplier_name], [Supplier_City], [Supplier_Street], [Supplier_PCode], [Supplier_email], [Supplier_phone]) VALUES (N'SUP001', N'STK001', N'Gates & Co', N'Dublin', N'Georges Street', N'D2', N'Gatesco@gmail.com', N'2278374')
INSERT [dbo].[Suppliers] ([Supplier_ID], [Stock_ID], [Supplier_name], [Supplier_City], [Supplier_Street], [Supplier_PCode], [Supplier_email], [Supplier_phone]) VALUES (N'SUP002', N'STK002', N'Books & Co', N'London', N'Bourke Street', N'PO BOX 02', N'Booksco@gmail.com', N'22222374')
INSERT [dbo].[Suppliers] ([Supplier_ID], [Stock_ID], [Supplier_name], [Supplier_City], [Supplier_Street], [Supplier_PCode], [Supplier_email], [Supplier_phone]) VALUES (N'SUP003', N'STK003', N'Berlin LTD', N'Berlin', N'Schillstraße 8', N'B8', N'Berlinltd@gmail.com', N'12755574')
INSERT [dbo].[Suppliers] ([Supplier_ID], [Stock_ID], [Supplier_name], [Supplier_City], [Supplier_Street], [Supplier_PCode], [Supplier_email], [Supplier_phone]) VALUES (N'SUP004', N'STK004', N'Dublin Press', N'Dublin', N'Dame Street', N'D3', N'Dpress@gmail.com', N'11178374')
INSERT [dbo].[Suppliers] ([Supplier_ID], [Stock_ID], [Supplier_name], [Supplier_City], [Supplier_Street], [Supplier_PCode], [Supplier_email], [Supplier_phone]) VALUES (N'SUP005', N'STK005', N'Capital City Distribution', N'Galway', N'riverside Street', N'G5', N'CapitolCD@gmail.com', N'2278374')
INSERT [dbo].[Suppliers] ([Supplier_ID], [Stock_ID], [Supplier_name], [Supplier_City], [Supplier_Street], [Supplier_PCode], [Supplier_email], [Supplier_phone]) VALUES (N'SUP006', N'STK006', N'Press and Co', N'Bermingham', N'Little britan Street', N'PO BOX 3', N'Pressco@gmail.com', N'9998374')
INSERT [dbo].[Suppliers] ([Supplier_ID], [Stock_ID], [Supplier_name], [Supplier_City], [Supplier_Street], [Supplier_PCode], [Supplier_email], [Supplier_phone]) VALUES (N'SUP007', N'STK007', N'Books and Co', N'Belfast', N'Falls road', N'PO BOX 08', N'Booksco@gmail.com', N'99999374')
INSERT [dbo].[Suppliers] ([Supplier_ID], [Stock_ID], [Supplier_name], [Supplier_City], [Supplier_Street], [Supplier_PCode], [Supplier_email], [Supplier_phone]) VALUES (N'SUP008', N'STK008', N'Atlas Books', N'Waterford', N'green street', N'D2', N'Gatesco@gmail.com', N'2278374')
INSERT [dbo].[Suppliers] ([Supplier_ID], [Stock_ID], [Supplier_name], [Supplier_City], [Supplier_Street], [Supplier_PCode], [Supplier_email], [Supplier_phone]) VALUES (N'SUP009', N'STK009', N'Global Press', N'New York', N'Wall Street', N'NYC09', N'Global@gmail.com', N'2278374')
INSERT [dbo].[Suppliers] ([Supplier_ID], [Stock_ID], [Supplier_name], [Supplier_City], [Supplier_Street], [Supplier_PCode], [Supplier_email], [Supplier_phone]) VALUES (N'SUP010', N'STK010', N'International supply', N'los angeles', N'Sunny Street', N'LA2', N'international@gmail.com', N'2278374')
ALTER TABLE [dbo].[Order_Items]  WITH CHECK ADD FOREIGN KEY([Order_ID])
REFERENCES [dbo].[Orders] ([Order_ID])
GO
ALTER TABLE [dbo].[Order_Items]  WITH CHECK ADD FOREIGN KEY([Stock_ID])
REFERENCES [dbo].[STOCK] ([STOCK_ID])
GO
ALTER TABLE [dbo].[Order_Items]  WITH CHECK ADD FOREIGN KEY([Supplier_ID])
REFERENCES [dbo].[Suppliers] ([Supplier_ID])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([Customer_ID])
REFERENCES [dbo].[Customers] ([Customer_ID])
GO
ALTER TABLE [dbo].[Returns]  WITH CHECK ADD FOREIGN KEY([Item_ID])
REFERENCES [dbo].[Order_Items] ([Item_ID])
GO
ALTER TABLE [dbo].[Returns]  WITH CHECK ADD FOREIGN KEY([Stock_ID])
REFERENCES [dbo].[STOCK] ([STOCK_ID])
GO
ALTER TABLE [dbo].[Suppliers]  WITH CHECK ADD FOREIGN KEY([Stock_ID])
REFERENCES [dbo].[STOCK] ([STOCK_ID])
GO
/****** Object:  StoredProcedure [dbo].[AddUsers]    Script Date: 25.05.2020 15:46:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[AddUsers]
@Customer_ID varchar(50),
@First_name varchar(50),
@Last_name varchar(50),
@Customer_City varchar(50),
@Customer_Street varchar(50),
@Customer_PCode varchar(50),
@Customer_email varchar(250),
@Customer_phone varchar(50),
@Customer_password varchar(50)
AS
	INSERT INTO [dbo].[Customers](Customer_ID,First_name,Last_name,Customer_City,Customer_Street,Customer_PCode,Customer_email,Customer_phone,Customer_password)
	VALUES(@Customer_ID,@First_name,@Last_name,@Customer_City,@Customer_Street,@Customer_PCode,@Customer_email,@Customer_phone,@Customer_password)
GO
/****** Object:  StoredProcedure [dbo].[CartAdd]    Script Date: 25.05.2020 15:46:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[CartAdd]
@Order_ID int,
@Customer_ID varchar(50),
@Book_name varchar(50),
@Price varchar(50),
@Amount varchar(50)
AS
INSERT into tblCart(Order_ID,Customer_ID,Book_name,Price,Amount)
VALUES (@Order_ID,@Customer_ID,@Book_name,@Price,@Amount);

GO
/****** Object:  StoredProcedure [dbo].[CartAddBook]    Script Date: 25.05.2020 15:46:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[CartAddBook]
@Order_ID int,
@Customer_ID varchar(50),
@Book_name varchar(50),
@Price varchar(50),
@Amount varchar(50)
AS
INSERT into tblCart(Order_ID,Customer_ID,Book_name,Price,Amount)
VALUES (@Order_ID,@Customer_ID,@Book_name,@Price,@Amount);

GO
/****** Object:  StoredProcedure [dbo].[CartBookAdd]    Script Date: 25.05.2020 15:46:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[CartBookAdd]
@Order_ID int,
@Customer_ID varchar(50),
@Book_name varchar(50),
@Price varchar(50),
@Amount varchar(50)
AS
INSERT into Cart(Order_ID,Customer_ID,Book_name,Price,Amount)
VALUES (@Order_ID,@Customer_ID,@Book_name,@Price,@Amount);

GO
