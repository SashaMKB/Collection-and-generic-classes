using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Second_Task
{
    class LocalFileLogger<T>:ILogger
    {
        public T Value { get; set; }
        private string WayToFile = "C:\\Users\\79196\\Desktop\\Homework\\Second_Task\\New_File";

        public LocalFileLogger(string WayToFile) { }

        public void  LogInfo(string message)
        {
            File.AppendAllTextAsync(WayToFile, $"[Info]: [{Value}] : {message}");
        }
        public void LogWarning(string message)
        {
            File.AppendAllTextAsync(WayToFile, $"[Warning] : [{Value}] : {message}");
        }
        public void LogError(string message, Exception ex)
        {
            File.AppendAllTextAsync(WayToFile, $"[Error] : [{Value}] : {message}. {ex.Message}");
        }
    }
}
