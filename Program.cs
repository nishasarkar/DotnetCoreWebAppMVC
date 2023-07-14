var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();// middleware firt check there i https redirection
app.UseStaticFiles();//check the static folder in wwwroot folder.

app.UseRouting();//built in middle ware middle ware are tw types -built in middle ware and custom middle ware

app.UseAuthorization();//what is middle ware?? middleware are simple function thats are used to intercept the request or funnctions

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");//it check for home controller and index action  id is optional thats why its having question

app.Run();//to serve a request we should have routing middle ware and run 
