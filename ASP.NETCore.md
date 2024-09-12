# .NET

You can build different applications
1. Cloud using Azure
2. Web using ASP.NET and Blazor
3. Desktop using MAUI WPF Winforms
4. Mobile using Xamarin MAUI
5. Games using Unity
6. IoT ARM32 ARM64
7. AI using ML.NET

### SDK

1. Common Base Libraries "Base Classes"
2. Infrastructure
    1. JIT Compilers
    2. Garbage Collector
    3. Roslyn Compiler
    4. Languages: C#, VB.NET or F#"

### ASP.NET

1. Server Side Applications
    1. MVC
    2. Razor Pages "MVVM Different Architecture Pattern"
2. Web API for mobile and front-end apps. We will use RESTful API

### .NET Blazor

1. Server App: Multiple Page Application
2. Web Assembly: Single Page Application

### ASP.NET Core MVC

MVC is short for Mode-View-Controller.  
Separation of Concerns.  

1. Model: Classes that represent the tables inside the database. It represents the data.

2. Controller: A Class responsible for processing. Its name must end with controller and inherit Class Controller. Inside it 5 methods = 5 actions. Inside each method is a LINQ expression. It connects to both Models and Views. Deals with http requests.
    1. Get
    2. Get by Id
    3. Create
    4. Update
    5. Delete 

3. View: html page with C# code inside it. A Razor Page .cshtml extension. In an API there are no views. The data will be sent in raw form to the front end.

### Razor Pages

Uses the MVVM. Model - View - ViewModel. The Model here will acts as both a model and a controller.  
Also Razor Pages has implemented security  
Two way binding, MVC was one way  
The MVVM is the one used in all mobile applications

### HTTP
HyperText Transfer Protocol is an application protocol for distribution, collaboration of media and information systems. Is a stateless protocol. Can't be used for online chatting for example.  
FTP: File Transmission Protocol  
TCP: Transmission Control Protocol. Can be used for online chat.  

### HTTPs
Another type of HTTP  
The normal http protocol is formed of layers:
1. HTTP: Application Layer
2. TCP: Transport Layer
3. IP: Network Layer
4. Network interfaces: Data link layer

The HTTPs however has an extra layer between HTTP and TCP  
SSL or TLS : A security layer, an encryption layer  
Without encryption passwords sent to the server can be easily exposed

### URL
Uniform Resource Locator  
http://www.google.com
1. http => protocol
2. www => subdomain
3. google => domain
4. com => TLD = Top Level Domain

http://amazon.com:80/Movies/GetMovie?id=5&name=abc
1. http => Protocol
2. amazon.com => host name = web app name
3. 80 => Port
4. Movies/GetMovie => URL Path
5. ?id=5&name=abc => Query String

### URI
Uniform Resource Identifier = URL + URN  
Uniform Resource Number which links you to a specific part in the page

### Deployment
1. On a Physical Server  
You bought an actual server and you connect it to the internet, expensive many technical difficulties  

2. On a Virtual Server  
You rent a space on a hosting service provider: limited bandwidth and requests

### HTTP Messages
Has two types of messages: request and response  

**Request Message**
1. Request Line: Protocol Version + Path + Method "Get Post Put Delete"
2. Header: consists of many headers
    1. Host
    2. Accept: image types
    3. Accept-Language
    4. Accept-Encoding
    5. User-Agent
    6. Content-Length
    7. Authorization "Very Important"
3. Body: Query String

**Response Message**
1. Status Line
2. Header: Consists of many headers
    1. Date
    2. Server
    3. Last-Modified
    4. ETag
    5. Accept-Ranges
    6. Content-Length
    7. Connection
    8. Content-Type
3. Body: html page

### Remember
| Method | JavaScript | HTML | Browser  |  
|:---    | :---:      |:---: | :---:    |
| Get    | *          | *    | *        |
| Post   | *          | *    |          |
| Put    | *          |      |          |
| Delete | *          |      |          |

### Status Code
* 100-199 => Informational
* 200-299 => Successful
* 300-399 => Redirection
* 400-499 => Client Error
* 500-599 => Server Error

### Client Side Code Vs Server Side Code
Client side only understands HTML, CSS and JS  
Server side understands different languages and technologies  
1. Client sends HTTP Request to the server
2. The server will communicate with the database through the backend app and generate the required data
3. the server will generate new HTML, CSS and JS code and
4. Send them as HTTP response to the client side

### The Old ASP.NET
It had three products  
1. Web Forms very bad performance => obsolete
2. Web Pages
3. MVC

### The New ASP.NET Core
1. Razor Pages "MVVM" instead of web pages
2. MVC

### Web Services
Web API "Model + Controller Only" through ASP.NET + SignalR  
SignalR is a tool that provides real time functionality  
You create an end point that provides raw data without a view

### Different Templates
1. Razor Pages has two folders: Models and Views
2. Models acts as both Models and Controllers

### Server: .NET vs .NET Core
* For ASP.NET only a Windows Server IIS. The IIS had a namespace called System.Web which had the base Class Library of .NET. The IIS was reponsible for handling the requests
* For ASP.NET Core. The server may have different type of operating systems and servers {Nginx or Apache for Linus or Mac - IIS for Windows}. they're called Reverse Proxy Server = External Web Server. Those received the requests only. Any Application in ASP.NET Core "MVC, Razor or API" is actually made of two parts: the application that you made and a Console Application which is called Kestrel = internal web server. The Kestrel communicates with the Reverse Proxy Server. the Kestrel is made of 8 pipelines or 8 middleware. If any failed, the whole process failed.
* Another variant of deployment, the client side will communicate directly with the Kestrel. However, Microsoft recommends the first approach.

### MVC Life Cycle
1. The Client side will send HTTP request to the Controller
2. The Controller: will receive, interpret and validate input. Create and update views. Query & modify models.
3. The Controller will demand data from the Model
4. The Model: data storage, integrity, consistency, queries & mutations
5. The Model will send the data to the controller.
6. The Controller will send the data to the Views
7. The View: presentation assets

### Empty MVC Core Template
* Connected Services: for any external service or API that will be used in your project
* Dependencies - Analyzers: dependencies needed for the compiler
* Dependencies - Frameworks
* Also any packages or references from other projects will be included here
* File launchSettings.json won't be uploaded during deployment, it only acts locally
* If you run the IIS, you'll open the web page only. If you run the project "Kestrel", you'll have a web page and a console app
* File appsettimgs.json responsible for configurations like Connection String for example. We should have 4 versions of it. Development, Testing, Staging and Production.