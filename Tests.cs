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
}
