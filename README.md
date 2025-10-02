# StudentManagement

Det her projekt er bare en lille demo på et Student Management System i .NET 8. Opgaven handler mest om at vise hvordan man bruger Entity Framework Core migrations til at lave ændringer i databasen over tid.  


## Migrations

- InitialSchema laver de første tabeller som Student, Course og Enrollment.  
- AddMiddleNameToStudent tilføjer en ny kolonne MiddleName til Student.  
- AddDateOfBirth tilføjer en DateOfBirth kolonne til Student.  
- AddInstructor laver en Instructor model og kobler den på Course.  
- RenameGradeToFinalGrade ændrer Grade til FinalGrade. Her var det lidt destruktivt fordi det ændrer en eksisterende kolonne.  
- AddDepartment laver en Department tabel og binder den til Instructor.  
- ModifyCourseCredits ændrer Credits fra int til decimal. Det kan være destruktivt hvis gamle data ikke passer.  

## Destruktiv og ikke-destruktiv

Når man tilføjer nye ting er det normalt ikke-destruktivt, fordi de gamle data stadig virker. Når man ændrer navn eller datatype er det mere destruktivt, fordi der kan gå noget tabt.  

## Incremental vs state-based

EF Core migrations kører incremental. Det betyder man bygger ovenpå databasen trin for trin. En state-based tilgang ville være at kigge på hele modellen og databasen og lave en plan ud fra forskellen. Det kan give et fuldt billede, men er også sværere at styre.  

## Branches og commits

Jeg har lavet en branch for hver migration:  
- feat/initial-schema-ef  
- feat/add-middle-name  
- feat/add-date-of-birth  
- feat/add-instructor  
- feat/rename-grade  
- feat/add-department  
- feat/modify-course-credits  


