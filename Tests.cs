using Xunit;
using API.Services;

public class Tests
{
    private readonly EncryptionService _encryptionService;

    public Tests()
    {
        _encryptionService = new EncryptionService();
    }

    [Fact]
    public void EncryptReturnsEncryptedString()
    {
        //Given
        string input = "Test";

        //When
        string encrypted = _encryptionService.Encrypt(input);

        //Then

        Assert.NotEqual(input, encrypted);
        Assert.NotEmpty(encrypted);
    }

    [Fact]
    public void ReturnsKnownEncryptedString()
    {

        //Given
        string input = "abc123";
        string output = "fgh678";

        //When
        string encrypted = _encryptionService.Encrypt(input);

        //Then
        Assert.Equal(output, encrypted);
    }

    [Fact]
    public void DecryptReturnsDecryptedString()
    {
         //Given
        string input = "Yjxy";

        //When
        string decrypted = _encryptionService.Decrypt(input);

        //Then

        Assert.NotEqual(input, decrypted);
        Assert.NotEmpty(decrypted);
    }

    [Fact]
    public void ReturnsKnownDecryptedString()
    {
        string input = "Yjxy";
        string output = "Test";

        string decrypted = _encryptionService.Decrypt(input);

        Assert.Equal(output, decrypted);
    }
}
