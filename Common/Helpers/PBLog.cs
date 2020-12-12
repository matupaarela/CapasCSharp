using System;
using System.Diagnostics;
using System.IO;

namespace Common.Helpers
{
    public static class PBLog
    {
        public static void Save(object obj, Exception ex)
        {
            string fecha = DateTime.Now.ToString("yyyyMMdd");
            string hora = DateTime.Now.ToString("HH:mm:ss");
            string path = Directory.GetCurrentDirectory();

            StreamWriter sw = new StreamWriter(path + "/" + fecha + ".txt", true);

            StackTrace stacktrace = new StackTrace();

            sw.WriteLine(obj.GetType().FullName + " " + hora);
            sw.WriteLine(stacktrace.GetFrame(1).GetMethod().Name + " - " + ex.Message);
            sw.WriteLine("");

            sw.Flush();
            sw.Close();
        }
    }
}
