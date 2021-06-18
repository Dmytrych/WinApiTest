using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace WinApiTestFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var process = GetCurrentProcess();
            string input = Console.ReadLine();

            if (input == "stop")
            {
                TerminateProcess(process, 101);
            }
            else
            {
                Point point = new Point();
                while (true)
                {
                    GetCursorPos(ref point);
                    Console.WriteLine(point.X);
                    Thread.Sleep(4);
                    Console.Clear();
                }
            }

            Console.ReadLine();
        }

        [DllImport("kernel32.dll")]
        private static extern GCHandle GetCurrentProcess();

        [DllImport("kernel32.dll")]
        private static extern void TerminateProcess(GCHandle handler, uint number);

        [DllImport("user32.dll")]
        private static extern bool GetCursorPos(ref Point point);
    }
}