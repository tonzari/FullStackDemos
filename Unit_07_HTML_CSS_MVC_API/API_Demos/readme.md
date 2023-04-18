JSON 

Javascript Object Notation

- Human readable, but it's also easy for computers to read.
- JSON is used with just about every programming language. 
- Used to send and receive data between two computers (for example, from a web server to a user's device (web browser))
- Organized in KEY/VALUE pairs.
    "Key": "Value"
    Key Value pairs are always separated by commas
- What does the object part in JSON mean?
- An object is denoted by curly brackets { }
    {
        "SomeKey": "SomeValue"
    }
- In JSON, arrays can be denoted with square brackets [ ]
    [
        {
            "Key": "Value"
        },
        {
            "Key": "Value"
        },
        {
            "Key": "Value"
        }
    ]
- Arrays can be used as a value
        {
            "Key": "Value",
            "AnotherKey":["Hello","Hi","Hola"]
        },
- Values can be numbers: integers, floating point numbers
        {
            "MyNumber": 1.23
        }
- Values can be booleans: true, false
- Values can be null

API

Microsoft docs: https://learn.microsoft.com/en-us/aspnet/web-api/overview/advanced/calling-a-web-api-from-a-net-client

#Demo 04 API Forms and User Secrets

We will use this API: https://api-ninjas.com/api/city
It requires an API key. Please visit the website and get an API key (for free).

NOTE: Right click on libman.json and select 'Restore CLient-side Libraries..." to restore Bootstrap and Jquery.

Visit these docs for guidance: https://learn.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-6.0&tabs=windows
Tutorial: https://www.koderdojo.com/blog/user-secrets-in-asp-net-core-mvc-web-application

Steps taken:
1. From command line, navigate to the project directory and run: 'dotnet user-secrets init' This will generate a unique ID and directory locally store your secret keys.
2. Right click on the project in the Solution Explorer, choose 'Manage User Secrets'. This will open a secrets.json file located at the unique local directory.
3. From command line, run: dotnet user-secrets set "ApiNinja:ApiKey" "EnterYourApiKeyHere"
4. Open the secrets.json file again by right clicking the project and selecting 'Manage User Secrets', and if it doesn't have the ApiNinja JSON object, add it yourself:
    {
        "ApiNinja": {
                "ApiKey": "PasteYourApiKeyHere"
         }
    }



