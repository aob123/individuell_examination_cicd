using API.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<EncryptionService>();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/encrypt/{text}", (string text, EncryptionService encryptionService) => 
{
    return encryptionService.Encrypt(text);
});

app.MapGet("/decrypted", () => "Decrypted");

app.Run();

