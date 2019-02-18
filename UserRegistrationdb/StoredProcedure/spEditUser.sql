CREATE PROCEDURE [dbo].[spUpdateUser]
@Id INT,
@Fname NVARCHAR(30),
@Lname NVARCHAR(30),
@mail NVARCHAR(50),
@Pass NVARCHAR(8),
@Mno VARCHAR(10)
AS
BEGIN
UPDATE signup SET FirstName = @Fname,LastName=@Lname,Email=@mail,Pass=@Pass,MobileNo=@Mno WHERE Id=@Id
END
GO