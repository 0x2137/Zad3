using System.Diagnostics;

namespace Zad3
{
    public partial class Form1 : Form
    {
        private PerformanceCounter cpuCounter;
        private PerformanceCounter availableMemoryCounter;
        private System.Windows.Forms.Timer updateTimer;
        private readonly float totalMemory;

        public Form1()
        {
            InitializeComponent();

            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            availableMemoryCounter = new PerformanceCounter("Memory", "Available MBytes");

            totalMemory = GetTotalPhysicalMemory();

            updateTimer = new System.Windows.Forms.Timer();
            updateTimer.Interval = 1000;
            updateTimer.Tick += UpdateTimer_Tick;
            updateTimer.Start();

            // za pierwszym razem trzeba skompilować i odpalić .exe jako administrator
            if (!EventLog.SourceExists("PerformanceMonitor"))
            {
                EventLog.CreateEventSource("PerformanceMonitor", "Application");
            }
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            float cpuUsage = cpuCounter.NextValue();
            float availableMemory = availableMemoryCounter.NextValue();
            float usedMemory = totalMemory - availableMemory;

            labelCpu.Text = $"Zużycie CPU: {cpuUsage:F2}%";
            labelMemory.Text = $"Zużycie pamięci: {usedMemory} MB";

            if (cpuUsage > 90)
            {
                EventLog.WriteEntry("PerformanceMonitor", $"Zużycie CPU przekroczyło 90%: {cpuUsage:F2}%", EventLogEntryType.Warning);
            }


            if ((usedMemory / totalMemory) * 100 > 80)
            {
                EventLog.WriteEntry("PerformanceMonitor", $"Użycie pamięci przekroczyło 80%: {usedMemory:F2} MB", EventLogEntryType.Warning);
            }
        }

        private float GetTotalPhysicalMemory()
        {
            var computerInfo = new Microsoft.VisualBasic.Devices.ComputerInfo();
            return computerInfo.TotalPhysicalMemory / (1024 * 1024);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
