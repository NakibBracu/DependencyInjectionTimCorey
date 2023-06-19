using BlazorServerDemo.Data;

namespace BlazorServerDemo.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void GetdaysinMonthTest()
        {
            TestingDemo t = new(DateTime.Parse("2/1/2000"));
            ProcessDemo p = new(t); //cause ProcessDemo also Implement IDemo
            int expected = 29;
            int actual = p.GetDaysInMonth();
            Assert.Equal(expected, actual);

        }
    }

    public class TestingDemo : IDemo {

       
        public DateTime StartUpTime { get ; init ; }

        public TestingDemo(DateTime _startUptime)
        {
            StartUpTime = _startUptime;        
        }
    }
}