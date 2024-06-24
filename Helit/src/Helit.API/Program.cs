using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
});

var app = builder.Build();

app.MapGet("/request", () => 5);

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Helit API V1");
        c.HeadContent = @"
                <style>
                    .custom-text {
                        font-family: 'Montserrat', sans-serif;
                        font-weight: bold;
                        color: #ff00ff;
                        font-size: 3vh;
                        display: block;
                        margin-top: 10px;
                    }
                    .custom-container {
                        background-color: #151515;
                        padding: 20px;
                        margin-top: 0;
                    }
                    .custom-container svg {
                        margin-left: 0px;
                    }
                    .topbar {
                                display: none !important;
                            }
                    .info .title {
                        display: none;
                    }
                    .swagger-ui .btn, .swagger-ui .btn__primary, .swagger-ui .btn.default {
                                    background-color: #ff00ff; 
                                    border-color: #ff00ff;
                                    color: white;
                                }
                    .url {
                        color: #ff00ff;
                    }
                </style>
            <div class='custom-container'>
                <svg width='50' height='50' viewBox='0 0 24 24' fill='none' xmlns='http://www.w3.org/2000/svg'>
                    <path d='M14 17L17 14L14 11M10 7L7 10L10 13M7.8 21H16.2C17.8802 21 18.7202 21 19.362 20.673C19.9265 20.3854 20.3854 19.9265 20.673 19.362C21 18.7202 21 17.8802 21 16.2V7.8C21 6.11984 21 5.27976 20.673 4.63803C20.3854 4.07354 19.9265 3.6146 19.362 3.32698C18.7202 3 17.8802 3 16.2 3H7.8C6.11984 3 5.27976 3 4.63803 3.32698C4.07354 3.6146 3.6146 4.07354 3.32698 4.63803C3 5.27976 3 6.11984 3 7.8V16.2C3 17.8802 3 18.7202 3.32698 19.362C3.6146 19.9265 4.07354 20.3854 4.63803 20.673C5.27976 21 6.11984 21 7.8 21Z' stroke='#ff00ff' stroke-width='2' stroke-linecap='round' stroke-linejoin='round'/>
                </svg>
                <span class='custom-text'>Helit</span>
            </div>";
    });
}

app.Run();