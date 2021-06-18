using System.Runtime.InteropServices;

namespace WinApiTestFramework
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Point
    {
        public int X;
        public int Y;
    }
}