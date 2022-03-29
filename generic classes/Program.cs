using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Second_Task;

namespace Second_Task
{ 
    class Program
    {
        static void Main(string[] args)
        {
            string WayToFile = "C:\\Users\\79196\\Desktop\\Homework\\Second_Task\\New_File";
            var genericClassIntenger = new LocalFileLogger<int>(WayToFile);
            genericClassIntenger.Value = 100;
            genericClassIntenger.LogInfo("intenger create ");
            genericClassIntenger.LogWarning("warning! ");
            genericClassIntenger.LogError("Error! ", new FormatException());


            var genericClassString = new LocalFileLogger<string>(WayToFile);
            genericClassString.Value = "some_string";
            genericClassString.LogInfo("string create");
            genericClassString.LogWarning("Warning !");
            genericClassString.LogError("Error!", new FormatException());
        }
    }
}
