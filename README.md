[![Build & Tests](https://github.com/TimCRN/AdminBeheer/actions/workflows/build-test.yml/badge.svg)](https://github.com/TimCRN/AdminBeheer/actions/workflows/build-test.yml)
[![Docker Publishes](https://github.com/TimCRN/AdminBeheer/actions/workflows/docker-publish.yml/badge.svg)](https://github.com/TimCRN/AdminBeheer/actions/workflows/docker-publish.yml)

# Admin Management

The purpose of this project is to integrate management feautures on users for the application.

# Requirements

To be able to work in this project, you'll need docker. Docker will handle all the dependancies that are tied in to this project. This will also provide you the free choice of using whatever text editor / IDE you like.

[<img src="https://ms-azuretools.gallerycdn.vsassets.io/extensions/ms-azuretools/vscode-docker/1.12.1/1618259060082/Microsoft.VisualStudio.Services.Icons.Default" width="200">](https://www.docker.com/products/docker-desktop)

# Running the Project

Running this project is really simple now. Doesn't matter where you are, what computer you have, as long as it has Docker installed on it you can easily work in this project. 

To run this project, you need to open a CLI (Or whatever code editor you want to use, IDE Visual Studio works aswell) and navigate to the project folder. When there, enter the following code:

```console
docker-compose up
```

That's the only thing you'll need to do and it'll run the project.

# Database

This project uses a local MySQL database that runs in a docker container. This database is created from migrations that are defined in the app. The app also seeds the database with some standard values.

You can connect with the local database via localhost on port 3306, ***but make sure that the mysql container is running in docker!***
The credentials for this db is as follows:

- username: root
- password: secret

These credentials are, ofcourse, different and serializeed in the production environment and are only used for local testing.

You can also access the database via the browser. This can be accessed via http://localhost:8080/.

# Entity Framework

Working with the entity framework requires following a set procedure. The database is built up from migrations that are defined through the entity framework. To include a new table/object in the database, you'll have to do the following:

***1. Create an object class in the ./Models/ folder***
* Be sure to be include the DataAnnotations library so that you can use decorators. These decorators help you define what type of row you want to build into that table

***2. Include the object in ./Data/AdminManagementContext.cs***
* This can be achieved by inserting the following code:
```csharp
public DbSet<MODELNAME> MODELNAME { get; set; }
```

***3. (OPTIONAL) Insert default entries in ./Data/DbInitializer.cs***
* These entries will always be included when the database is created freshly.\
This can be achieved by doing the following:
```csharp
context.MODELNAME.Add( new MODELNAME( arguments[] ) )
```

***4. Create the migration in the CLI***
* Using the dotnet command you can automatically create the migration based on the changes you've just applied.\
* This can be achieved by entering the followin line in the CLI (**NOTE**: Make sure you're in the following folder <.\\AdminBeheer\\AdminManagement>)
```console
dotnet ef migrations add MIGRATIONMESSAGE
```

If done correctly, a success message should appear and rebuild the database on the next run.
