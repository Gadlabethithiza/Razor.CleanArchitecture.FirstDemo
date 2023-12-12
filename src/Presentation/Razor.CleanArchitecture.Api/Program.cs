//using Razor.CleanArchitecture.Application.Extensions;
//using Razor.CleanArchitecture.Infrastructure.Extensions;
//using Razor.CleanArchitecture.Persistence.Extensions;

//var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddApplicationLayer();
//builder.Services.AddInfrastructureLayer();
//builder.Services.AddPersistenceLayer(builder.Configuration);

//builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//var app = builder.Build();

//Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//app.UseSwagger();
//app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();
//app.UseAuthorization();

//app.MapControllers();
//app.Run();


using Razor.CleanArchitecture.Api.Bootstrapper;

var app = AppBuilder.GetApp(args);
app.Logger.LogInformation("application instance created");

RequestPipelineBuilder.Configure(app);
app.Logger.LogInformation("request pipeline has been configured");

app.MapControllers();
app.Run();

