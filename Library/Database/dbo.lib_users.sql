CREATE TABLE [dbo].[lib_users]
(
	[user_name] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [user_password] VARCHAR(50) NOT NULL, 
    [user_is_system] INT NOT NULL
)
