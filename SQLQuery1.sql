create database customer;

use customer;

create table Userdata
(
	[UserId] NUMERIC(10) CONSTRAINT userdata_pk_userid PRIMARY KEY IDENTITY,
	[FName] VARCHAR(20) NOT NULL,
	[LName] VARCHAR(20) NOT NULL,
	[Email] VARCHAR(20) NOT NULL,
	[Phone] NUMERIC(10) NOT NULL,
	[Gender] CHAR(6) NOT NULL CONSTRAINT userdata_chk_gender CHECK(Gender IN ('MALE','FEMALE')),
	[Address1] VARCHAR(100) NOT NULL,
	[Address2] VARCHAR(50),
	[City] CHAR(20) NOT NULL,
	[State] CHAR(20) NOT NULL,
	[Country] CHAR(20) NOT NULL,
	[Purpose] CHAR(8) NOT NULL CONSTRAINT user_chk_purpose CHECK(Purpose IN ('Business','Delivery','Visiting','Other'))
)

