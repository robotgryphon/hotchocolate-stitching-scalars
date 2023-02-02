var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGraphQLServer()
    .AddQueryType<BasicQuery>();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGraphQL();

app.Run();