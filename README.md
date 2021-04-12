# API for database interact with UWP app

  **SQL Server**

Tables
```
use cbs_test
go


create table dbo.tbl_Messages(
MessageId bigint identity(1,1) not null
,Created_Date datetime not null
,SendTo varchar(300) not null
,MessageValue  varchar(160) not null
)

ALTER TABLE dbo.tbl_Messages ADD PRIMARY KEY (MessageId); 

create table dbo.tbl_SendingMessages(
IdSent bigint identity(1,1) not null
,MessageId bigint not null
,Sent_Date datetime not null
,Confirmation_Code varchar(34) not null
)

ALTER TABLE dbo.tbl_SendingMessages ADD PRIMARY KEY (IdSent); 
ALTER TABLE dbo.tbl_SendingMessages ADD FOREIGN KEY (MessageId) REFERENCES dbo.tbl_Messages(MessageId);

```
##
César Benítez

