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
