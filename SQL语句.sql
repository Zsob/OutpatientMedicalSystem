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
		,FILENAME='D:\杂物\门诊医药管理系统OutpatientMedicalSystem\HospitalBase\DataFile.mdf')
	LOG ON	
		(NAME='LogFile_1'
		,FILENAME='D:\杂物\门诊医药管理系统OutpatientMedicalSystem\HospitalBase\LogFile.ldf');

CREATE TABLE tb_User(
    ID
		VARCHAR(18)
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
		DATE
		NULL,
	Photo
		VARBINARY(MAX)
		NULL,
	Balance
		DECIMAL(18,0)
		DEFAULT '0'
		NOT NULL
)

INSERT dbo.tb_User
(
    ID,
    Password,
    Name,
    Gender,
    Phone,
	Birthday
)
VALUES
(   '350103200103271518',   -- ID - char(18)
    HASHBYTES('MD5','11'), -- Password - varbinary(128)
    '曾极涵',   -- Name - varchar(10)
    '男',   -- Gender - char(2)
    '15080491384',    -- Phone - varchar(20)
    '2001-3-27'
	),
('3190707033',HASHBYTES('MD5','11'),'郭首志','男','110','2000-1-1'),
('3190707003',HASHBYTES('MD5','11'),'张浩奇','男','119','2000-4-28'),
('3190707054',HASHBYTES('MD5','11'),'尤海滨','男','112','2001-4-1'),
('3190707058',HASHBYTES('MD5','11'),'黄久军','男','120','1999-8-25')

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
	IndicationNo
		INT
		NOT NULL
)
INSERT dbo.tb_Doctor
(
    DoctorNo,
    Password,
    Name,
    IndicationNo
)
VALUES
(   '1',   -- DoctorNo - varchar(10)
    HASHBYTES('MD5','1'), -- Password - varbinary(128)
    '张朝晖',   -- Name - varchar(10)
    '1'    -- Indications - varchar(100)
),
('2',HASHBYTES('MD5','1'),'林敏','1'),
('3',HASHBYTES('MD5','1'),'郭龙','1'),
('4',HASHBYTES('MD5','1'),'林晖','2'),
('5',HASHBYTES('MD5','1'),'张良','2'),
('6',HASHBYTES('MD5','1'),'郑友珍','2')

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
('中医科'),
('耳鼻喉科')

CREATE TABLE tb_Order
(
	OrderNo
	 INT
	 IDENTITY
	 PRIMARY KEY,
	DoctorNo
		VARCHAR(10)
		NOT NULL,
	UserID
		CHAR(18)
		NOT NULL,
	OrderTime
		DATETIME
		NOT NULL,
	Noon
		VARCHAR(20)
		NOT NULL,
	OrderStatus
		VARCHAR(20)
		NULL
		
)

CREATE TABLE tb_Medicines
(
	MedicalNo
		INT
		PRIMARY KEY,
	MedicalName
		VARCHAR(50)
		NOT NULL,
	Price
		DECIMAL(4,2)
		NOT NULL,
	Pinyin
		VARCHAR(50)
		NOT NULL,
	Stock
		INT
		NOT NULL
)

BULK INSERT tb_Medicines
		FROM 'D:\杂物\门诊医药管理系统OutpatientMedicalSystem\材料\药物表.csv'
		WITH
		(FIELDTERMINATOR=','
		,ROWTERMINATOR='\n'
		,FIRSTROW=2);

SELECT *FROM dbo.tb_Order
SELECT O.OrderNo,O.UserID,U.Name,U.Gender,YEAR(GETDATE())-YEAR(U.Birthday) AS Age,U.Phone,O.OrderTime,O.Noon,O.DoctorNo FROM dbo.tb_Order AS O JOIN dbo.tb_User AS U ON O.UserID=U.ID WHERE O.DoctorNo='1' ORDER BY O.Noon ASC
SELECT O.OrderNo,I.Indication,D.Name,O.OrderTime,O.Noon FROM dbo.tb_Order AS O JOIN dbo.tb_Doctor AS D ON D.DoctorNo = O.DoctorNo JOIN dbo.tb_Indications AS I ON I.No=D.IndicationNo
 