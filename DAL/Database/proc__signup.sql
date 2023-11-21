USE [AIRBOOK]
GO

/****** Object:  StoredProcedure [dbo].[proc__signup]    Script Date: 11/17/2023 6:47:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[proc__signup]
@Email varchar(50),
@Pwd varchar(20),
@Real_name nvarchar(50),
@Username varchar(20),
@DoB date,
@Gender nvarchar(10),
@Nation nvarchar(20),
@User_address nvarchar(50),
@Phone_number varchar(11),
@CCCD varchar(12),
@Date_create datetime,
@User_ID varchar(20) = OUTPUT
AS

BEGIN
  DECLARE @userId varchar(20)

  SET @userId = CONCAT('AC', NEWID())

  INSERT INTO users(
		User_ID,
		Role_ID,
		Email,
		Pwd,
		Real_name,
		Username,
		DoB,
		Gender,
		Nation,
		User_address,
		Phone_number,
		CCCD,
		Date_create
	) VALUES (@userId, 'ROLE4', @Email, @Pwd, @Real_name,@Username, @DoB, @Gender, @Nation, @User_address, @Phone_number, @CCCD, @Date_create)

  SET @User_ID = @userId

END

select * from users
GO


