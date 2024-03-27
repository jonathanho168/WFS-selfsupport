CREATE TABLE AuditLog
(
    AuditID BIGINT IDENTITY(1,1) PRIMARY KEY,
    ObjectName NVARCHAR(255) NOT NULL, -- The name of the object (e.g. Active Directory) where the change occurred
    RecordID NVARCHAR(1000) NOT NULL, -- A unique identifier of the record that was changed, such as a GUID
    ChangedBy NVARCHAR(255) NOT NULL, -- The username or identifier of the person who made the change
    ChangeTime DATETIME NOT NULL, -- The timestamp when the change was made
    System NVARCHAR(255) NOT NULL, -- The service (e.g. SelfSupport) that made the change
    Module NVARCHAR(255) NOT NULL, -- The module that executed the change (e.g. timesheet unapproval)
    Description NVARCHAR(1000) NOT NULL, -- Brief description of who made what change
);