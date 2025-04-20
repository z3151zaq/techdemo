## how to run this program
### run with ide
- windows --> visit https://visualstudio.microsoft.com/downloads/ to download Visual Studio
- macos --> visit https://www.jetbrains.com/rider/download to download Rider
- open this project with IDE, wait dependencies installed automatically and run it
### run without ide
1. vist [.net web](https://dotnet.microsoft.com/en-us/download) to dwonload and install .net 8.
2. clone this project
3. cd techdemo
4. dotnet restore   # restore the dependencies
5. dotnet build     # conpile the project
6. dotnet run       # run the project
7. vist http://localhost:5072


## Comparison: C# vs Node.js

| Feature               | C#                                     | JavaScript                                 |
| --------------------- | -------------------------------------- | ------------------------------------------ |
| **Typing**            | Statically, strongly typed       | Dynamically, loosely typed           |
| **Compilation**       | Compiled (to IL via .NET compiler)     | Interpreted or JIT-compiled (e.g., V8)     |
| **Paradigm**          | Object-Oriented + Functional           | Prototype-based + Functional               |
| **Runtime**           | .NET CLR                               | JavaScript engine (V8, SpiderMonkey, etc.) |
| **Main Use**          | Backend (APIs, desktop, mobile, games) | Frontend (browser), Backend (Node.js)      |
| **Platform**          | Cross-platform via .NET Core/.NET 5+   | Runs in browsers and Node.js               |
| **Error Handling**    | Compile-time and runtime               | Mostly runtime                             |
| **Memory Management** | Automatic (Garbage Collected)          | Automatic (Garbage Collected)              |
| **Development Tools** | Visual Studio, VS Code, Rider              | VS Code, Browser DevTools, WebStorm                  |
| **Syntax Style**      | C-style with strict typing             | C-style with flexible typing               |
| **Language Level**    | High-level language                    | High-level scripting language              |
