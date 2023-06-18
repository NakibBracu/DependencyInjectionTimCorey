namespace BlazorServerDemo.Data
{
    public class Demo2
    {
        public DateTime StartUpTime { get; init; }
        // We can change the value of the Property When only and only while instantiating the Object
        public Demo2()
        {
            StartUpTime = DateTime.Now;
        }
    }
}
