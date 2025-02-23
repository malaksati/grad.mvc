using GP.DAL.Context;
using GP.DAL.Seed;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(op =>
{
    op.UseSqlServer(builder.Configuration.GetConnectionString("DefultConnection"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

builder.Services.AddControllersWithViews();
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var dbContext = services.GetRequiredService<AppDbContext>();
    var env = services.GetRequiredService<IHostEnvironment>();
    DbInitializer.SeedAdvisor(dbContext, env); 
    DbInitializer.SeedFacultyWithoutDept(dbContext, env);
    DbInitializer.SeedCollege(dbContext, env);
    DbInitializer.SeedDapertment(dbContext, env);
    DbInitializer.SeedFacultyWithDept(dbContext, env);
    DbInitializer.SeedCourses(dbContext, env);
    DbInitializer.SeedCoursesPre(dbContext, env);
    DbInitializer.SeedPlace(dbContext, env);
    DbInitializer.SeedFollowUp(dbContext, env);
    DbInitializer.SeedStudentAffairs(dbContext, env);
    DbInitializer.SeedFinancialAffairs(dbContext, env);

}
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
