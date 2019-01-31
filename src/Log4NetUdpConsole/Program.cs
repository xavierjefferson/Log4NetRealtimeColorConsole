using System;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using log4net;

internal static class UdpLogListener
{
    private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

    public static void Main()
    {
        var Port = 8081; // <-- remember to use the same port in your web/source app.

        try
        {
             var sender = new IPEndPoint(IPAddress.Any, 0);
            var client = new UdpClient(Port);

            while (true)
            {
                var buffer = client.Receive(ref sender);
                var logLine = Encoding.Default.GetString(buffer);
                // The color	coded text is written to the console when Log.{level method} is called.
                // i.e. Log.Info("my info")
                // Optional: Replace your placeholders with whatever you like. [I]=Info, [D]=Debug, etc.
                // More detail about placeholders in the UdpAppender config below.
                if (logLine.IndexOf("{INFO}") >= 0)
                    Log.Info(logLine.Replace("{INFO}", "[I] "));
                else if (logLine.IndexOf("{DEBUG}") >= 0)
                    Log.Debug(logLine.Replace("{DEBUG}", "[D] "));
                else if (logLine.IndexOf("{ERROR}") >= 0)
                    Log.Error(logLine.Replace("{ERROR}", "[E] "));
                else if (logLine.IndexOf("{WARN}") >= 0)
                    Log.Warn(logLine.Replace("{WARN}", "[W] "));
                else
                    // Some other level.
                    Log.Warn(logLine);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            Console.WriteLine("\r\nPress any key to close...");
            Console.ReadLine();
        }
    }
}