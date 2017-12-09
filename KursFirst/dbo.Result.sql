CREATE TABLE [dbo].[Result] (
    [Kod]                  INT           NOT NULL,
    [KodStudentRecordBook] INT           NOT NULL,
    [NumberCompany]        INT           NOT NULL,
    [NameCompany]          NVARCHAR (50) NOT NULL,
    [FIOotVuza]            NVARCHAR (50) NOT NULL,
    [DoljnostOtVuza]       NVARCHAR (50) NOT NULL,
    [FIOotPrep]            NVARCHAR (50) NOT NULL,
	[DoljnostOtPrep]       NVARCHAR (50) NOT NULL,
    [DateStart]            DATE          NOT NULL,
    [DateEnd]              DATE          NOT NULL,
    [Mark]                 INT           NOT NULL
);

