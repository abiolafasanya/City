namespace RestApi.Services.Mail
{
    public interface IMailService
    {
        void Send(string subject, string message);
    }
}