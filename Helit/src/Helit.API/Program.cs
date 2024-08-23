using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApiDocument(config =>
{
    config.Title = "Helit.Gateway";
    config.Version = "v0.0.1";
});

var app = builder.Build();

app.MapGet("/request/{i}", ([FromRoute] int i) => i);


app.UseStaticFiles();



if (builder.Environment.IsDevelopment())
{
    app.Use(async (context, next) =>
    {
        if (context.Request.Path == "/")
        {
            context.Response.Redirect("/index.html");
            return;
        }
        await next();
    });
}

app.UseOpenApi();


app.UseReDoc(c =>
{
    c.SpecUrl("/swagger/v1/swagger.json");
    c.RoutePrefix = "docs";
});


app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Helit.Gateway v0.0.1");
    c.RoutePrefix = "swagger";
});

await app.RunAsync();