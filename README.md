# .NET Core 3.1 Web API & Entity Framework Jumpstart

Studying NET Core following these articles created by Patrick God.

[Patrick God dev.to](https://dev.to/_patrickgod/net-core-3-1-web-api-entity-framework-jumpstart-part-1-4jla)

Thanks Patrick!

## Database MS SQL Server

- For testing EF, I prefer use MS SQL Server on container. Below is the script to initiate the docker container:
    - `docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=<<YOUR_PASSWORD_HERE>>' -e 'MSSQL_PID=Express' --name mssql -p 1433:1433 -d mcr.microsoft.com/mssql/server:2019-latest`