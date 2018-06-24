namespace Uptime.Domain
{
    public interface IUptimeService
    {
        string FilePath { get; set; }
        UptimeResult Get();
    }
}