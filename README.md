[![Build & Tests](https://github.com/TimCRN/AdminBeheer/actions/workflows/build-test.yml/badge.svg)](https://github.com/TimCRN/AdminBeheer/actions/workflows/build-test.yml)
[![Docker Publishes](https://github.com/TimCRN/AdminBeheer/actions/workflows/docker-publish.yml/badge.svg)](https://github.com/TimCRN/AdminBeheer/actions/workflows/docker-publish.yml)

# Admin Management

The purpose of this project is to integrate management feautures on users for the application.

# Requirements

To be able to work in this project, you'll need docker. Docker will handle all the dependancies that are tied in to this project. This will also provide you the free choice of using whatever text editor / IDE you like.

[<img src="https://ms-azuretools.gallerycdn.vsassets.io/extensions/ms-azuretools/vscode-docker/1.12.1/1618259060082/Microsoft.VisualStudio.Services.Icons.Default" width="200">](https://www.docker.com/products/docker-desktop)

# Database

This project uses a local MySQL database that runs in a docker container. This database is created from migrations that are defined in the app. The app also seeds the database with some standard values.

You can connect with the local database via localhost on port 3306, ***but make sure that the mysql container is running in docker!***
The credentials for this db is as follows:

- username: root
- password: secret

These credentials are, ofcourse, different and serializeed in the production environment and are only used for local testing.

You can also access the database via the browser. This can be accessed via http://localhost:8080/.
