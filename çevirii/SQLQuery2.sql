USE TranslationApp;

CREATE TABLE Translations (
    ID INT PRIMARY KEY IDENTITY(1,1),
    SourceText NVARCHAR(500),
    TranslatedText NVARCHAR(500),
    Language NVARCHAR(50)
);
