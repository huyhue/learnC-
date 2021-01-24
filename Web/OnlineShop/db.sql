create proc [dbo].[Sp_Account_Login]
 @UserName varchar(20),
 @Password varchar(50)
 as 
 begin
  declare @count int
  declare @res bit
  select @count = count(*) from Account where UserName = @UserName and Password = @Password
  if @count > 0
	set @res = 1
else
set @res = 0
select @res
end

create proc Sp_Category_ListAll
as
select * from Category where Status = 1
order by [Order] asc

create proc [dbo].[Sp_Category_Insert]
 @Name varchar(50),
 @Alias varchar(50),
 @ParentID int,
 @Order int,
 @Status bit
 as 
 begin
	insert into Category(Name,Alias,ParentID,CreatedDate,[Order],Status)
	values(@Name,@Alias,@ParentID,getdate(),@Order,@Status)
end