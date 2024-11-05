namespace layoutdesign.Models
{
    public class Log : BaseEntity
    {
        public string LogLevel { get; set; } // e.g., Info, Warning, Error
        public string Message { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        public string? UserId { get; set; } // Optional, to track the user
        public string? Exception { get; set; } // Optional, for storing exception details
    }
}
