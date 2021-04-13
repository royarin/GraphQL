
-- for more info see 
https://chillicream.com/docs/strawberryshake/get-started

-- install tools (used to generate c# code)

dotnet tool install StrawberryShake.Tools --global



-- install packages

dotnet add Demo package StrawberryShake.Transport.Http
dotnet add Demo package StrawberryShake.CodeGeneration.CSharp.Analyzers
dotnet add Demo package Microsoft.Extensions.DependencyInjection
dotnet add Demo package Microsoft.Extensions.Http



-- retrieve the graphql schema (SDL)
dotnet graphql init https://localhost:5001/graphql/ -n ApiClient -p ./Api

-- after this customize the namespace in the .graphqlrc.json file
BlazorGQL.Api