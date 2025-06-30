using InfNet.Ispotifai.Domain.Repository;
using InfNet.Ispotifai.Infrastructure;
using InfNet.Ispotifai.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<IspotifaiDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("IspotifaiDbContext")));

builder.Services.AddScoped(typeof(IspotifaiDbContext), typeof(IspotifaiDbContext));
builder.Services.AddScoped<IUsuarioRepository>(IUsuarioRepository => new UsuarioRepository(IUsuarioRepository.GetRequiredService<IspotifaiDbContext>()));
builder.Services.AddScoped<IMusicaRepository>(IMusicaRepository => new MusicaRepository(IMusicaRepository.GetRequiredService<IspotifaiDbContext>()));
builder.Services.AddScoped<IPlanoRepository>(IPlanoRepository => new PlanoRepository(IPlanoRepository.GetRequiredService<IspotifaiDbContext>()));

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();
