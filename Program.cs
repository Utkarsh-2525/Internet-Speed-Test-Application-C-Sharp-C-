using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Console.WriteLine("Running Speedtest...");

        try
        {
            var process = new Process();
            process.StartInfo.FileName = "speedtest";
            process.StartInfo.Arguments = "--format=json";
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;

            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            // Simple JSON parsing using System.Text.Json
            var result = System.Text.Json.JsonDocument.Parse(output).RootElement;

            double downloadMbps = result.GetProperty("download").GetProperty("bandwidth").GetDouble() * 8 / 1_000_000;
            double uploadMbps = result.GetProperty("upload").GetProperty("bandwidth").GetDouble() * 8 / 1_000_000;
            double ping = result.GetProperty("ping").GetProperty("latency").GetDouble();
            string isp = result.GetProperty("isp").GetString();

            Console.WriteLine($"ISP: {isp}");
            Console.WriteLine($"Download Speed: {downloadMbps:F2} Mbps");
            Console.WriteLine($"Upload Speed: {uploadMbps:F2} Mbps");
            Console.WriteLine($"Ping: {ping:F2} ms");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error running speedtest: " + ex.Message);
        }
    }
}