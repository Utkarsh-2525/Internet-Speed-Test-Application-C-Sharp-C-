# 🌐 C# Internet Speed Test Console App

A simple C# console application that performs an internet speed test by invoking the official [Ookla Speedtest CLI](https://www.speedtest.net/apps/cli). It measures **download**, **upload**, **ping**, and displays your ISP.

---

## 📸 Demo Output

```bash
Running Speedtest...
ISP: XYZ Telecom
Download Speed: 105.32 Mbps
Upload Speed: 18.45 Mbps
Ping: 24.55 ms
```
🚀 Features
 - ✅ Runs the official Speedtest CLI

 - ✅ Parses JSON output

 - ✅ Displays clean internet speed test results

 - ✅ Cross-platform compatible (.NET 6+)

📦 Requirements
 - .NET 6.0 SDK or later

 - Official Ookla Speedtest CLI

🛠️ Installation & Usage
  1. Clone the Repo
     ```bash
     git clone https://github.com/your-username/speedtest-csharp.git
     cd speedtest-csharp
     
  2. Install Speedtest CLI
      - Download the official CLI from speedtest.net/apps/cli, extract it, and add it to your system PATH.
      - To test:
        ``` bash
        speedtest --format=json
        ```
        
  3. Run the App
     ```bash
     dotnet run
     ```
📁 File Structure

    .
    ├── Program.cs         # Main C# code
    ├── SpeedTestApp.csproj
    └── README.md
