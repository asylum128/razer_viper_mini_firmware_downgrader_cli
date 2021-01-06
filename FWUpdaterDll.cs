using System;
using System.Runtime.InteropServices;

namespace razer_mini_firmware_downgrader
{
    public class FWUpdaterDll
    {
        [DllImport("FWUpdaterDLL.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Auto)]
        internal static extern IntPtr OpenDevice(uint VID, uint PID, ushort bcdpid, float blver, int reporttype, int featurelen, int inputlen, int outputlen);

        [DllImport("FWUpdaterDLL.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int EnterDeviceMode(IntPtr handle, byte mode);

        [DllImport("FWUpdaterDLL.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Auto)]
        public static extern void CloseDevice(IntPtr handle);

    }


}
