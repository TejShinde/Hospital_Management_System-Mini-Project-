using Hospital_Management_System .Data;
using Hospital_Management_System .Repository;
using Hospital_Management_System .Services;
using Microsoft .EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//configuration of session
builder .Services .AddSession(options =>
{
    options .IdleTimeout = TimeSpan .FromMinutes(30);
    options .Cookie .IsEssential = true;
});//*

// Add IHttpContextAccessor for session usage
builder .Services .AddSingleton<IHttpContextAccessor , HttpContextAccessor>();

//read connection string from appsetting.json
var configuration = builder .Configuration .GetConnectionString("DefaultConnection");

//pass connection string to applicationdbcontext class
builder .Services .AddDbContext<ApplicationDBContext>(op => op .UseSqlServer(configuration));

// Add services for dependency injection
builder .Services .AddScoped<ISpecialityService , SpecialityService>();
builder .Services .AddScoped<ISpecialityRepository , SpecialityRepository>();
builder .Services .AddScoped<IPatientService , PatientService>();
builder .Services .AddScoped<IPatientRepository , PatientRepository>();
builder .Services .AddScoped<IDoctorService , DoctorService>();
builder .Services .AddScoped<IDoctorRepository , DoctorRepository>();
builder .Services .AddScoped<IUserService , UserService>();
builder .Services .AddScoped<IUserRepository , UserRepository>();

builder .Services .AddScoped<IAppointmentRepository , AppointmentRepository>();
builder .Services .AddScoped<IAppointmentService , AppointmentService>();
builder .Services .AddScoped<ITimeSlotsService , TimeSlotsService>();
builder .Services .AddScoped<ITimeSlotRepository , TimeSlotRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
app .UseSession();

app .UseAuthorization();

app.MapControllerRoute(
    name: "default",
   // pattern: "{controller=Home}/{action=Index}/{id?}");
    pattern: "{controller=User}/{action=Login}/{id?}");
app .Run();
