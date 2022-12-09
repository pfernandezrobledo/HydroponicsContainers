

# Create project structure

Create three folders: api, application and infrastructure under the 'src' directory
Execute the following commands on each folder respectively, for example:


c:\projects\farmeronboarding\src\api>dotnet new webapi
c:\projects\farmeronboarding\src\applciation>dotnet new classlib
c:\projects\farmeronboarding\src\infrastructure>dotnet new classlib



# Install dotnet aspnet-codegenerator

dotnet aspnet-codegenerator - Runs the ASP.NET Core scaffolding engine. dotnet aspnet-codegenerator is only required to scaffold from the command line, it's not needed to use scaffolding with Visual Studio.


dotnet tool install -g dotnet-aspnet-codegenerator


# Install EF Core packages for SQL and Cosmos

PM> Install-Package Microsoft.EntityFrameworkCore
PM> Install-Package Microsoft.EntityFrameworkCore.Tools
PM> Install-Package Microsoft.EntityFrameworkCore.SqlServer
PM> Install-Package Microsoft.EntityFrameworkCore.Cosmos