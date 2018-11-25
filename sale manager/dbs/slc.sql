-- Script Date: 25/11/2018 2:26 PM  - ErikEJ.SqlCeScripting version 3.5.2.75
-- Database information:
-- Database: D:\VB.NET\sale manager\sale manager\dbs\db.db3
-- ServerVersion: 3.22.0
-- DatabaseSize: 40 KB
-- Created: 25/11/2018 2:43 AM

-- User Table information:
-- Number of tables: 2
-- userGroups: -1 row(s)
-- users: -1 row(s)

SELECT 1;
PRAGMA foreign_keys=OFF;
BEGIN TRANSACTION;
CREATE TABLE [userGroups] (
  [userGroupID] INTEGER  NOT NULL
, [groupName] varchar  NOT NULL
, [Enabled] bit DEFAULT 1 NULL
, [ParentID] bigint  NULL
, CONSTRAINT [sqlite_master_PK_userGroups] PRIMARY KEY ([userGroupID])
);
CREATE TABLE [users] (
  [userID] INTEGER  NOT NULL
, [userName] char  NOT NULL
, [userEmail] varchar  NULL
, [userDisplayName] varchar  NULL
, [groupID] bigint  NULL
, CONSTRAINT [sqlite_master_PK_users] PRIMARY KEY ([userID])
, FOREIGN KEY ([groupID]) REFERENCES [userGroups] ([userGroupID]) ON DELETE SET NULL ON UPDATE CASCADE
);
CREATE UNIQUE INDEX [sqlite_autoindex_userGroups_2] ON [userGroups] ([groupName] ASC);
CREATE UNIQUE INDEX [sqlite_autoindex_userGroups_1] ON [userGroups] ([userGroupID] ASC);
CREATE UNIQUE INDEX [sqlite_autoindex_users_3] ON [users] ([userEmail] ASC);
CREATE UNIQUE INDEX [sqlite_autoindex_users_2] ON [users] ([userName] ASC);
CREATE UNIQUE INDEX [sqlite_autoindex_users_1] ON [users] ([userID] ASC);
COMMIT;

