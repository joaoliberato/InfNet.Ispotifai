using InfNet.Ispotifai.WebApp.Services;

var builder = WebApplication.CreateBuilder(args);

var apiBaseUrl = builder.Configuration["IspotifaiApiSettings:BaseUrl"];
if (string.IsNullOrEmpty(apiBaseUrl))
{
    throw new InvalidOperationException("The Ispotifai API base URL is not configured.");
}

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient<IspotifaiApiClient>(client =>
{
    client.BaseAddress = new Uri(apiBaseUrl);
});

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
