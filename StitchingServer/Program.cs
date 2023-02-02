var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient("scalar", client =>
{
    client.BaseAddress = new Uri("https://localhost:7077/graphql");
});

var merged = builder.Services.AddGraphQLServer("merged");
merged.AddRemoteSchema("scalar", false);
merged.AddQueryType();
merged.AddTypeExtensionsFromFile("Stitching.graphql");

var app = builder.Build();

app.UseHttpsRedirection();
app.UseRouting();
app.MapGraphQL(schemaName: "merged");
app.Run();