#region services
using FluentValidation.AspNetCore;
using UsersApp.API.Extensions;
using UsersApp.API.Middlewares;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddFluentValidation(config =>
{
    config.RegisterValidatorsFromAssembly(typeof(Program).Assembly);
});
builder.Services.AddRouting(options => options.LowercaseUrls = true);
builder.Services.AddSwaggerDoc();
builder.Services.AddEntityFramework(builder.Configuration);
builder.Services.AddServices(builder.Configuration);
builder.Services.AddJwtBearer(builder.Configuration);
builder.Services.AddAutoMapperProfiles();

#endregion
#region builder
var app = builder.Build();

app.UseSwaggerDoc();
app.UseAuthorization();
app.UseAuthentication();
app.MapControllers();
app.UseMiddleware<ExceptionMiddleware>();
app.Run();

public partial class Program { }
#endregion


