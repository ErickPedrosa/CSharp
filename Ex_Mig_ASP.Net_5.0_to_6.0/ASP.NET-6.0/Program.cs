var builder = WebApplication.CreateBuilder(args);

// ConfigureServices - Start;

builder.Services.AddControllersWithViews();

var app = builder.Build();

/* ConfigureServices - End; //
------------------------------
//    Configure - Start;    */

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);


// Configure - End;

app.Run();


/*

typeof(Startup);
    ==
AppDomain.CurrentDomain.GetAssemblies();

*/