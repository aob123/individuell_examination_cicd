namespace API.Services
{
    public class EncryptionService
    {

        private const int ShiftKey = 5;
        public string Encrypt(string input)
        {

            return new string(input.Select(c => (char)(c + ShiftKey)).ToArray());

        }

        public string Decrypt(string input)
        {
            return new string(input.Select(c => (char)(c - ShiftKey)).ToArray());
        }
    }
}