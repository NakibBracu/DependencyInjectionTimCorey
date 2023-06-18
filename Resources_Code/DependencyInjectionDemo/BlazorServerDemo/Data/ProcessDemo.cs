namespace BlazorServerDemo.Data
{
    public class ProcessDemo
    {
        private readonly Demo _demo;
        // Here we use dependency injection through Constructor, that means constructor injection happened!
        // This ProcessDemo class is using the Demo Class method here by Constructor.
        // When this class constructor called this will first instantiate the object of Demo Class from program.cs
        // by binding singleton,transient etc. and then instantiate processDemo object and do the rest of the work!
        public ProcessDemo(Demo demo)
        {
            _demo = demo;
        }

        public int GetDaysInMonth() {

            return _demo.StartUpTime.Month switch
            {
                1 => 31,
                2 => 28,
                3 => 31,
                4 => 30,
                5 => 31,
                6 => 30,
                7 => 31,
                8 => 31,
                9 => 30,
                10 => 31,   
                11 => 30,
                12 => 31,

                _ => throw new IndexOutOfRangeException()
            };
        }
        public int GetDaysInMonthWay2()
        {
            //This method is much more accurate than the previous
            return DateTime.DaysInMonth(_demo.StartUpTime.Year, _demo.StartUpTime.Month);
        }

    }
}
