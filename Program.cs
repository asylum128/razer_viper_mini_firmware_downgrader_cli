namespace razer_mini_firmware_downgrader
{
    using System;    

    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            uint vid = 0x1532;
            uint pid = 0x008A; // viper mini
            int reportType = 4;
            int featureReport = 91;
            int inputReportLen = 0;
            int outputReportLen = 0;

            IntPtr handle = FWUpdaterDll.OpenDevice(vid, pid, 0, 0f, reportType, featureReport,inputReportLen, outputReportLen);
            if(!(handle == IntPtr.Zero))
            {
                FWUpdaterDll.EnterDeviceMode(handle, 1);
                FWUpdaterDll.CloseDevice(handle);
                Console.WriteLine("Successful entered dev mode.");
            }
            else
            {
                Console.WriteLine("Failed to enter dev mode.");
            }
        }
    }
}


