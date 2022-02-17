# Crear una API web con ASP.NET Core y MongoDB en Visual Studio Code

Instale Mongodb en:
https://docs.mongodb.com/manual/administration/install-community/

Ejecute el siguiente comando en Mongodb
use MifacturaStore

Cree una colección mediante el siguiente comando
db.createCollection('Mifacturas')

Crear el proyecto de API web de ASP.NET Core

Instale C# para Visual Studio Code en:
https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp

Intale .NET 6.0 SDK (v6.0.200) - Windows x64 en:
https://dotnet.microsoft.com/en-us/learn/dotnet/hello-world-tutorial/intro?sdk-installed=true

Ejecute los siguientes comandos:
dotnet new webapi -o MifacturaStoreApi

Ejecute para abrir en Visual
code MifacturaStoreApi

Ejecute el siguiente comando para instalar el controlador .NET para MongoDB
dotnet add package MongoDB.Driver

Ejecutar la aplicación
dotnet run
