using BlazorServerDemo.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddTransient<IDemo, UtcDemo>();//just by doing the binding with UtcDemo, All IDemo type will get Utcdemo
builder.Services.AddTransient<ProcessDemo>();
// Here we use AddTransient that means everytime we use Demo Class it will create
// a new instance for it.
// Here we are actually registering the services.
builder.Services.AddSingleton<Demo2>();

builder.Services.AddScoped<Demo3>();//everytime I hit a request it changes ; if we use it in a single page we get the
                                        //same result everytime but when we refresh or go to another page we will see changes
                                        // this is called changed per scoped
builder.Services.AddScoped<Demo4>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
