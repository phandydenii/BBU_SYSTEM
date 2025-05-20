using BBU_SYSTEM_API.Service;
using BBU_SYSTEM.Configuration;
using BBU_SYSTEM.Repository;
using BBU_SYSTEM.Service;
using BBU_SYSTEM.Respository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Builder;
using System.Net;
using Newtonsoft.Json;
using BBU_SYSTEM.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
//======Add Scope=====
builder.Services.AddScoped<ICampusDbContext, CampusDbContextService>();
builder.Services.AddTransient<IDegree, DegreeService>();
builder.Services.AddTransient<IBranch, BranchService>();
builder.Services.AddTransient<ISchool, SchoolService>();
builder.Services.AddTransient<IFaculty, FacultyService>();
builder.Services.AddTransient<IPromotion, PromotionService>();
builder.Services.AddTransient<IField, FieldService>();
builder.Services.AddTransient<IStage, StageService>();
builder.Services.AddTransient<ITerm, TermService>();
builder.Services.AddTransient<IGroup, GroupService>();
builder.Services.AddTransient<IGroupRoom, GroupRoomService>();
builder.Services.AddTransient<IStudent, StudentService>();
builder.Services.AddTransient<IUser, UserService>();
builder.Services.AddTransient<IHighSchool, HighSchoolService>();
builder.Services.AddTransient<IUniversity, UniversityService>();
builder.Services.AddTransient<IUniversity, UniversityService>();
builder.Services.AddTransient<IDisability, DisabilityService>();
builder.Services.AddTransient<INationality, NationalityService>();
builder.Services.AddTransient<IRace, RaceService>();
builder.Services.AddTransient<IFieldCertificate, FieldCertificateService>();
builder.Services.AddTransient<IRegistry, RegistryService>();
builder.Services.AddTransient<IInvoice, InvoiceService>();
builder.Services.AddTransient<IBooking, BookingService>();

//=====Add Automapper
builder.Services.AddAutoMapper(typeof(AutoMapperConfiguration));
//=======================================================

//====JWT Setting===
builder.Services.AddRouting(options => options.LowercaseUrls = true);
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(o =>
{
    o.RequireHttpsMetadata = false;
    o.SaveToken = true;
    o.TokenValidationParameters = new TokenValidationParameters
    {
        ClockSkew = TimeSpan.Zero,
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Jwt:Audience"],
        ValidAudience = builder.Configuration["Jwt:Issuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(builder.Configuration["Jwt:Key"]!)),
    };
});
builder.Services.AddCors(o => {
    o.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader();
    });
});
//=====

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("V1", new OpenApiInfo
    {
        Version = "V1",
        Title = "BBU SYSTEM API",
        Description = "STUDENT MANAGEMENT SYSTEM"
    });
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Name = "Authorization",
        Description = "Bearer Authentication with JWT Token",
        Type = SecuritySchemeType.Http
    });
    options.AddSecurityRequirement(new OpenApiSecurityRequirement {
        {
            new OpenApiSecurityScheme {
                Reference = new OpenApiReference {
                    Id = "Bearer",
                        Type = ReferenceType.SecurityScheme
                }
            },
            new List < string > ()
        }
    });
});
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(20);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});


var app = builder.Build();
app.UseSession();

app.UseMiddleware<SessionAuthMiddleware>();
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.UseMigrationsEndPoint();
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/V1/swagger.json", "STUDENT MANAGEMENT SYSTEM");
    });
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

//Redirect to Login when UnAuthorize
//app.Use(async (context, next) =>
//{
//    await next();

//    if (context.Response.StatusCode == StatusCodes.Status401Unauthorized)
//    {
//        context.Response.Redirect("/Account/Login");
//    }
//});


app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

