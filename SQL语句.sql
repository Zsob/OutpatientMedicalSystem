USE master;
IF DB_ID('HospitalBase') IS NOT NULL
	BEGIN
		ALTER DATABASE HospitalBase
			SET SINGLE_USER
			WITH ROLLBACK IMMEDIATE;
		DROP DATABASE HospitalBase;
	END
GO

CREATE DATABASE HospitalBase		
	ON	
		(NAME='DataFile'
		,FILENAME='D:\����\����ҽҩ����ϵͳOutpatientMedicalSystem\HospitalBase\DataFile.mdf')
	LOG ON	
		(NAME='LogFile_1'
		,FILENAME='D:\����\����ҽҩ����ϵͳOutpatientMedicalSystem\HospitalBase\LogFile.ldf');

USE HospitalBase;
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
(   '3190707011',   -- ID - char(18)
    HASHBYTES('MD5','11'), -- Password - varbinary(128)
    '������',   -- Name - varchar(10)
    '��',   -- Gender - char(2)
    '15080491384',    -- Phone - varchar(20)
    '2001-3-27'
	),
('3190707033',HASHBYTES('MD5','11'),'����־','��','110','2000-1-1'),
('3190707003',HASHBYTES('MD5','11'),'�ź���','��','119','2000-4-28'),
('3190707054',HASHBYTES('MD5','11'),'�Ⱥ���','��','112','2001-4-1'),
('3190707058',HASHBYTES('MD5','11'),'�ƾþ�','��','120','1999-8-25')

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
	OrderStatus    --0Ϊδ���1Ϊ�����
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
		FROM 'D:\����\����ҽҩ����ϵͳOutpatientMedicalSystem\����\ҩ���.csv'
		WITH
		(FIELDTERMINATOR=','
		,ROWTERMINATOR='\n'
		,FIRSTROW=2);


CREATE TABLE tb_Diseases
(
	DiseaseNo
		 INT
		 IDENTITY
		 PRIMARY KEY,
	DiseaseName
		VARCHAR(50)
		NOT NULL,
	IndicationNo
		INT
		NOT NULL
)
INSERT dbo.tb_Diseases
(
    DiseaseName,
    IndicationNo
)
VALUES
( '����֧������',1 ),
( '����',1 ),
( '����',1 ),
( '����θ��',1 ),
( '���Գ��׸�к',1 ),
( '����',1 ),
( '����',1 ),
( '��Ѫѹ',1 ),
( '����ʧ��',1 ),
( '��������',1 ),
( '�������������',2 ),
( '�����Թ�Ĥ����',2 ),
( '�ж���',2 ),
( '�����Ա���',2 ),
( '�����Ա����',2 ),
( '���ʰ�',2 ),
( '��������',2 ),
( '��������',2 ),
( '��ʯ֢',2 ),
( '˯�ߴ���',2 )

CREATE TABLE tb_Diagnosis
(
	DiagnosisNo
		INT
		IDENTITY
		PRIMARY KEY,
	UserID
		VARCHAR(18)
		NOT NULL,
	OrderNo
		INT
		NOT NULL,
	DiagnosisTime
		DATETIME
		NOT NULL,
	DiseaseDiagnosis
		VARCHAR(MAX)
		NOT NULL
)

CREATE TABLE tb_DoctorOrder
(
	DoctorOrderNo
		INT
		IDENTITY
		PRIMARY KEY,
	OrderNo
		INT
		NOT NULL,
	DoctorNo
		VARCHAR(10)
		NOT NULL,
	UserID
		VARCHAR(18)
		NOT NULL,
	MedicalName
		VARCHAR(50)
		NOT NULL,
	MedicineNumber
		INT
		NOT NULL,
	DrugFrequency
		VARCHAR(MAX)
		NOT NULL,
	DrugUsage
		VARCHAR(max)
		NOT NULL
	)

INSERT dbo.tb_DoctorOrder ( OrderNo,DoctorNo,UserID,MedicalName,MedicineNumber,DrugFrequency,DrugUsage) VALUES( 0,'','','', 0,'','')
UPDATE dbo.tb_Order SET OrderStatus='1' WHERE OrderNo='';
SELECT * FROM dbo.tb_Order
SELECT * FROM dbo.tb_DoctorOrder
SELECT *FROM dbo.tb_Order
SELECT O.OrderNo,O.UserID,U.Name,U.Gender,YEAR(GETDATE())-YEAR(U.Birthday) AS Age,U.Phone,O.OrderTime,O.Noon,O.DoctorNo,U.Photo FROM dbo.tb_Order AS O JOIN dbo.tb_User AS U ON O.UserID=U.ID WHERE O.DoctorNo='1' AND O.OrderStatus='0' ORDER BY O.Noon ASC
SELECT O.OrderNo,I.Indication,D.Name,O.OrderTime,O.Noon FROM dbo.tb_Order AS O JOIN dbo.tb_Doctor AS D ON D.DoctorNo = O.DoctorNo JOIN dbo.tb_Indications AS I ON I.No=D.IndicationNo
SELECT * FROM dbo.tb_Indications;
SELECT * FROM dbo.tb_Diseases;
 UPDATE dbo.tb_Order SET DoctorNo='',OrderTime='',Noon='' WHERE OrderNo=''
 INSERT dbo.tb_Diagnosis (UserID,OrderNo,DiagnosisTime,DiseaseDiagnosis) VALUES ('', 0, GETDATE(),'')
 SELECT * FROM dbo.tb_Medicines
