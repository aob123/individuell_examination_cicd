using API.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<EncryptionService>();
builder.Services.AddCors(policyBuilder =>
    policyBuilder.AddDefaultPolicy(policy =>
        policy.WithOrigins("*").AllowAnyHeader().AllowAnyHeader())
);
var app = builder.Build();

app.UseCors();

app.MapGet("/", () => "Hello World!");

app.MapGet("/encrypt/{text}", (string text, EncryptionService encryptionService) =>
{
    return encryptionService.Encrypt(text);
});

app.MapGet("/decrypt/{text}", (string text, EncryptionService encryptionService) =>
{
    return encryptionService.Decrypt(text);
});

app.Run();

