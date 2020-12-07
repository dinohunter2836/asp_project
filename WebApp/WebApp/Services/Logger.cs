using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Services
{
    public class Logger : ILogger
    {
        private readonly string traceFilePath;
        private readonly string errorFilePath;
        private static object _lock = new object();

        public Logger(IWebHostEnvironment env)
        {
            traceFilePath = env.WebRootPath + "/Logs/TraceLog.txt";
            errorFilePath = env.WebRootPath + "/Logs/ErrorLog.txt";
        }
        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            if (formatter != null)
            {
                lock (_lock)
                {
                    string formattedMessage = formatter(state, exception) + Environment.NewLine;
                    using (FileStream fstream = File.Open(traceFilePath, FileMode.Append))
                    {
                        fstream.Write(System.Text.Encoding.Default.GetBytes(formattedMessage));
                    }
                    if (logLevel == LogLevel.Error)
                    {
                        using (FileStream fstream = File.Open(errorFilePath, FileMode.Append))
                        {
                            fstream.Write(System.Text.Encoding.Default.GetBytes(formattedMessage));
                        }
                        System.Diagnostics.Debug.WriteLine(formattedMessage);
                    }
                }
            }
        }
    }
}
