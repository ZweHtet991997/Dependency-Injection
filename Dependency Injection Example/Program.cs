using Dependency_Injection_Example.Dependency_Injection;
using Dependency_Injection_Example.DI_Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

#region register services

builder.Services.AddTransient<DI_StudentInterface, DI_FinalStudentServices>();

builder.Services.AddTransient<ITransientService, DI_Service>();
builder.Services.AddScoped<IScopedService, DI_Service>();
builder.Services.AddSingleton<ISingletonService, DI_Service>();

#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=DI_Example}/{action=Index}/{id?}");

app.Run();
