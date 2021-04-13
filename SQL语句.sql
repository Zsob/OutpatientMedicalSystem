USE master;
IF DB_ID('HospitalBase') IS NOT NULL
	BEGIN
		ALTER DATABASE HospitalBase
			SET SINGLE_USER
			WITH ROLLBACK IMMEDIATE;
		DROP DATABASE HospitalBase;
	END
Go
CREATE DATABASE HospitalBase		
	ON	
		(NAME='DataFile'
		,FILENAME='D:\����\����ҽҩ����ϵͳOutpatientMedicalSystem\HospitalBase\DataFile.mdf')
	LOG ON	
		(NAME='LogFile_1'
		,FILENAME='D:\����\����ҽҩ����ϵͳOutpatientMedicalSystem\HospitalBase\LogFile.ldf');

CREATE TABLE tb_User(
    ID
		CHAR(18)
		NOT NULL
		PRIMARY KEY,
	Password 
		VARBINARY(128) 
		NOT NULL,
	Name 
		VARCHAR(10)
		NOT NULL,
	Gender 
		CHAR(2)
		NOT NULL,
	Phone 
		VARCHAR(20)
		NOT NULL,
	Birthday
		DATETIME
		NULL,
	Photo
		VARBINARY(MAX)
		NULL,
	Balance
		INT
		DEFAULT '0'
		NOT NULL
)

INSERT dbo.tb_User
(
    ID,
    Password,
    Name,
    Gender,
    Phone
	
)
VALUES
(   '350103200103271518',   -- ID - char(18)
    HASHBYTES('MD5','11'), -- Password - varbinary(128)
    '������',   -- Name - varchar(10)
    '��',   -- Gender - char(2)
    '15080491384'    -- Phone - varchar(20)
    
	)

CREATE TABLE tb_Doctor(
	DoctorNo
		VARCHAR(10)
		NOT NULL
		PRIMARY KEY,
	Password
		VARBINARY(128)
		NOT NULL,
	Name
		VARCHAR(10)
		NOT NULL,
	Indications
		INT
		NOT NULL
)
INSERT dbo.tb_Doctor
(
    DoctorNo,
    Password,
    Name,
    Indications
)
VALUES
(   '1',   -- DoctorNo - varchar(10)
    HASHBYTES('MD5','1'), -- Password - varbinary(128)
    '�ų���',   -- Name - varchar(10)
    '1'    -- Indications - varchar(100)
),
('2',HASHBYTES('MD5','1'),'����','1'),
('3',HASHBYTES('MD5','1'),'����','1'),
('4',HASHBYTES('MD5','1'),'����','2'),
('5',HASHBYTES('MD5','1'),'����','2'),
('6',HASHBYTES('MD5','1'),'֣����','2')

CREATE TABLE tb_Indications
(
	No
		INT
		IDENTITY
		PRIMARY KEY,
	Indication
		VARCHAR(100)
		NOT NULL
)
INSERT dbo.tb_Indications
(
    Indication
)
VALUES
('��ҽ��'),
('���Ǻ��')

CREATE TABLE tb_Order
(
	OrderNo
	 INT
	 IDENTITY
	 PRIMARY KEY,
	DoctorNo
		VARCHAR(10)
		FOREIGN KEY  REFERENCES dbo.tb_Doctor(DoctorNo)
		NOT NULL,
	UserID
		CHAR(18)
		FOREIGN KEY REFERENCES dbo.tb_User(ID)
		NOT NULL,
	OrderTime
		DATETIME
		NOT NULL
)
SELECT * FROM dbo.tb_Order WHERE UserID='' AND DoctorNo=''
INSERT dbo.tb_Order (DoctorNo,UserID,OrderTime) VALUES (   '','',GETDATE() )