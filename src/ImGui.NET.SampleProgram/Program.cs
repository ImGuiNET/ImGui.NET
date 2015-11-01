using OpenTK;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ImGui
{
    public class Program
    {
        public static unsafe void Main(string[] args)
        {
            new SampleWindow().RunWindowLoop();
        }
    }
}