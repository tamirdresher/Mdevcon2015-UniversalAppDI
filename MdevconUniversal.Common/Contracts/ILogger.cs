namespace MdevconUniversal.Common.Contracts
{
    public interface ILogger
    {
        void Debug(string message);
        void Error(string message);
    }
}