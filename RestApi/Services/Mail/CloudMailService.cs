namespace RestApi.Services.Mail
{
    public class CloudMailService : IMailService
    {
        private readonly string _mailto = string.Empty;
        private readonly string _mailfrom = string.Empty;

        public CloudMailService(IConfiguration configuration)
        {
            _mailfrom = configuration["mailSettings:mailFromAddress"] ?? "";
            _mailto = configuration["mailSettings:mailToAddress"] ?? "";
        }

        public void Send(string subject, string message)
        {
            Console.WriteLine($"Mail From {_mailfrom} To {_mailto}, " + $"with {nameof(CloudMailService)}");
            Console.WriteLine($"Mail Subject: {subject}");
            Console.WriteLine($"Mail Message: {message}");

        }
    }
}
