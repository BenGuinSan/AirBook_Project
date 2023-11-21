USE [AIRBOOK]
GO

/****** Object:  StoredProcedure [dbo].[proc__login]    Script Date: 11/17/2023 6:45:01 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[proc__login]
@Email varchar(50),
@Pwd varchar(20)
as
BEGIN
	SELECT * FROM users
	WHERE Email COLLATE Latin1_General_CS_AS = @Email
	AND Pwd COLLATE Latin1_General_CS_AS = @Pwd
END
GO


