CREATE TABLE [dbo].[Articles]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1), -- 일련번호
	[TITLE] NVARCHAR(255) Not NULL, -- 제목

	[Content] NVarChar(Max) Not Null, -- 내용

	[CreatedBy] NVarChar(255) null, -- 등록자
	[Created] DateTime default(GetDate()), -- 생성일
	[ModifiedBy] NVarChar(255) Null, -- 수정자
	[Modified] DateTime null, -- 수정일,

	[Topic] NVarChar(255) Null , -- 주제

	[Value] NVarChar(255) Null -- 투표시 값
	)
GO