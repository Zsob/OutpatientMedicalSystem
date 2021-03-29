CREATE DATABASE HospitalBase		
	ON	
		(NAME='DataFile'
		,FILENAME='D:\杂物\门诊医药管理系统OutpatientMedicalSystem\HospitalBase\DataFile.mdf')
	LOG ON	
		(NAME='LogFile_1'
		,FILENAME='D:\杂物\门诊医药管理系统OutpatientMedicalSystem\HospitalBase\LogFile.ldf');

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
    '曾极涵',   -- Name - varchar(10)
    '男',   -- Gender - char(2)
    '15080491384'    -- Phone - varchar(20)
    )
