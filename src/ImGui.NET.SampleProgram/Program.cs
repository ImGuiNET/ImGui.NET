namespace ImGuiNET
{
    public class Program
    {
        public static unsafe void Main(string[] args)
        {
            var window = new SampleWindow();            
            window.RunWindowLoop();
        }
    }
}