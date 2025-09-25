using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using PulseTrack.Data;
using PulseTrack.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<PulseTrack.Data.PulseDbContext>(options =>
    options.UseInMemoryDatabase("PulseTrackDB"));
builder.Services.AddScoped<PulseTrack.Services.MetricsService>();

var app = builder.Build();

app.UseRouting();
app.UseAuthorization();
app.MapControllers();

app.Run();
