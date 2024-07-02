1. GrpcServiceExample project:    example is where the grpc code with the protos file and .net core code is, can be able to get the basic data.

to run the project: dotnet run 




2. GrpcServiceLibrary: creating a NuGet package for the gRPC service, packaging the code into a library, so creating a .nuspec file to describe the package, and then useing the CLI to pack and push the package to a NuGet feed. published it on 

    a. editing GrpcServiceLibrary.csproj to include requied nuget package
    b. creating copy for files and folder to library  
    c. creating GrpcServiceLibrary.nuspec file in root and adding necessay detailes there
    d. packing the nuget package using dotnet pack -p:PackageVersion=1.0.0 -o ../nuget
    e. pushing nuget package using 
    dotnet nuget push ../nuget/GrpcServiceLibrary.1.0.0.nupkg -k <apikey> -s https://api.nuget.org/v3/index.json




https://www.nuget.org/packages?q=GrpcServiceLibrary&includeComputedFrameworks=true&prerel=true&sortby=created-desc






3. TestNugetPackage:  for testing the nuget package

dotnet add package GrpcServiceLibrary --version 1.0.0

and using this thiing inside the TestNugetPackage