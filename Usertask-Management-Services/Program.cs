using Usertask_Management_BusinessLayer.Implementation;
using Usertask_Management_BusinessLayer.Interface;
using Usertask_Management_Repository.Implementation;
using Usertask_Management_Repository.Interface;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IUserTaskBusiness, UserTaskBusiness>();
builder.Services.AddScoped<IUserTaskRepository, UserTaskRepository>();

//builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseRouting();
app.Run();
