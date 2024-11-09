using System;
using System.Runtime.InteropServices;

namespace LockPC
{
    class Program
    {
        [DllImport("user32.dll")]
        private static extern bool LockWorkStation();

        static void Main(string[] args)
        {
            Console.WriteLine("Locking the workstation...");
            LockWorkStation();
        }
    }
}
