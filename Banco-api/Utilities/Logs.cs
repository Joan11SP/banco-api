using System;
using System.IO;
using Serilog;

namespace Banco_api.Utilities
{
    
    public class Logs
    {
        LoggerConfiguration log = new LoggerConfiguration();
        string current_location = Directory.GetCurrentDirectory();
        public void logger(string error) {
            var logs = file();
            logs.Information(error);
            Log.CloseAndFlush();
        }              
        public ILogger file() {
            var logs = log.WriteTo.File(current_location + @"\Logs\", rollingInterval: RollingInterval.Day)
                .CreateLogger();
            return logs;
        }
    }
}
