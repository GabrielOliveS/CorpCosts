using CorpCosts.DAL;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IMongoClient>(s =>
{
    var dbconnection = builder.Configuration.GetSection("DataBaseConnection");
    var connection = dbconnection.GetSection("ConnectionString").Value;
    var url = new MongoUrlBuilder(connection);
    var clienteSettings = new MongoClientSettings()
    {
        Server = url.Server
    };
    var client = new MongoClient(clienteSettings);
    return client;
});
builder.Services.AddSingleton<IMongoDatabase>(s =>
{
    var dbconnection = builder.Configuration.GetSection("DataBaseConnection");
    var connection = dbconnection.GetSection("ConnectionString").Value;
    var url = new MongoUrlBuilder(connection);
    return s.GetService<IMongoClient>().GetDatabase(url.DatabaseName);
});

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
