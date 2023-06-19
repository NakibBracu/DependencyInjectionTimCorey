namespace BlazorServerDemo.Data
{
    public class Demo : IDemo
    {
        public DateTime StartUpTime { get; init; }
        // We can change the value of the Property When only and only while instantiating the Object
        public Demo()
        {
            StartUpTime = DateTime.Now;
        }

    }
}
