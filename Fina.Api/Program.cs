using Fina.Api.Data;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

var builder = WebApplication.CreateBuilder(args);

const string connectionString =
     "Server=localhost\\SQLEXPRESS; database=fina; trusted_connection=true; trustservercertificate=true";

builder.Services.AddDbContext<AppDbContext>(
    x => x.UseSqlServer(connectionString)
    );



var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
