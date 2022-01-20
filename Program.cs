var builder = WebApplication.CreateBuilder(args);


builder.Services.AddMvc();

builder.Services.AddControllersWithViews();

var app = builder.Build();



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"

    );

app.MapRazorPages();

app.Run();




