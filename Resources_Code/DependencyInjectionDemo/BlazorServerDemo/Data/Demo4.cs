namespace BlazorServerDemo.Data
{
    public class Demo4
    {
        public DateTime StartUpTime { get; init; }
        // We can change the value of the Property When only and only while instantiating the Object
        public Demo4()
        {
            StartUpTime = DateTime.Now;
        }
    }
}
