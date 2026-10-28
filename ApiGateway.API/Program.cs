var builder = WebApplication.CreateBuilder(args);


//configure CORS allow all frontend access
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllFrontend", policy =>
    {
        policy.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

// Read configuration from appsettings.json and register YARP
builder.Services.AddReverseProxy()
    .LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"));


var app = builder.Build();

//active cors
app.UseCors("AllowAllFrontend");

// Start router
app.MapReverseProxy();

app.Run();