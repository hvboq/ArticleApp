CREATE TABLE [dbo].[Users]
(
	[Email] NVarChar(255) PRIMARY KEY Not Null,
	[Password] NVarChar(255) Not Null,

	[CreatedBy] NVarChar(255) null, -- 등록자
	[Created] DateTime default(GetDate()), -- 생성일
	[ModifiedBy] NVarChar(255) Null, -- 수정자
	[Modified] DateTime null, -- 수정일
)
GO
 