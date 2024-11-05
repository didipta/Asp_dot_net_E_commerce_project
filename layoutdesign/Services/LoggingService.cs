
using layoutdesign.Data;
using layoutdesign.Models;


namespace layoutdesign.Services
{
    public class LoggingService
    {
        private readonly ApplicationDBContext _context;

        public LoggingService(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task LogInfo(string message, string userId = null)
        {
            await Log("Info", message, null, userId);
        }

        public async Task LogWarning(string message, string userId = null)
        {
            await Log("Warning", message, null, userId);
        }

        public async Task LogError(string message, Exception ex, string userId = null)
        {
            await Log("Error", message, ex?.ToString(), userId);
        }

        private async Task Log(string logLevel, string message, string exception = null, string userId = null)
        {
            var log = new Log
            {
               
                LogLevel = logLevel,
                Message = message,
                Exception = exception,
                UserId = userId,
                Timestamp = DateTime.UtcNow
            };

            _context.Logs.Add(log);
            await _context.SaveChangesAsync();
        }
    }
}
