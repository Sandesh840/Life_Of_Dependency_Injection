using LifecycleofDepInj.Interface;
using LifecycleofDepInj.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//for transient services
/*builder.Services.AddTransient<IUserGuIdInterface, UserGuid>();*/
//for scope service(make new instance for every new request)
/*builder.Services.AddScoped<IUserGuIdInterface, UserGuid>();*/
//for singleton service use a same instance with in lifetime of application
builder.Services.AddSingleton<IUserGuIdInterface, UserGuid>();


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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
