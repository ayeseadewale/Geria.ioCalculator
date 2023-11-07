To lunch this application 
1. Open GeriaCalculatorAssessment folder
2. Open geria.ioCalculatorAssessmentTest.Sln
3. Go to AppSetting.json to change the Connection String, especially the Data Source vlaue. It is presently Adewale\\sqlexpress change to the one you want to use(You dont need to manually create database it as the Application will create it for you)
4. Install Nuget packages like Microsoft.EntityFrameworkCore, Microsoft.EntityFrameworkCore.SqlServer, Microsoft.EntityFrameworkCore.Tools if not present.
5. Go to Tools> NuGet Package Manager, from the drop down, select Package Manager Console.
6. Inside the Package Manager Console, type these two commands
	i. add-migration MyFirstMigration(You can put any name)
	ii. After migration is successul, type update-database)
	These will add migration and update the database with the name (GeriaCalculatorAssessment) You can change 	this to your desire name in the step 3.
7. Lunch the GeriaAssessmentCalculatorUI for the Frontend.
