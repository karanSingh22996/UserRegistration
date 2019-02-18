CREATE PROCEDURE [dbo].[spPostUser]
@Fname NVARCHAR(30),
@Lname NVARCHAR(30),
@mail NVARCHAR(50),
@Pass NVARCHAR(8),
@Mno VARCHAR(10)
AS
BEGIN
INSERT INTO signup(FirstName,LastName,Email,Pass,MobileNo) values(@Fname,@Lname,@mail,@Pass,@Mno)
END
GO