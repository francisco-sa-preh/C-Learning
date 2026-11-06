namespace TemperatureMonitor
{
    public delegate void TemperatureChangeHandler(string message); //delegate with a ref to a method

    public class TemperatureMonitor //He monitors the temperature and raises an event if something happens.
    {
        public event TemperatureChangeHandler OnTemperatureChanged; //method associated with event

        private int _temperature; //field

        public int Temperature //property to limit the access
        {
            get { return _temperature; }
            set
            {
                _temperature = value;
                if(_temperature > 30)
                {
                    //Raise event!!
                    RaiseTemperatureChangedEvent("Temperature is above the threshold");
                }
            }
        }

        //now we have to invoke the event if there is a change happened (invoking the methods)
        protected virtual void RaiseTemperatureChangedEvent(string message)
        {
            OnTemperatureChanged?.Invoke(message); // Temperature was raised! Subscribers do your thing! 
        }
    }
    //subscrivers of the event
    public class TemperatureAlert
    {
        public void OnTemperatureChanged(string message)
        {
            Console.WriteLine("Alert" + message);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureMonitor monitor = new TemperatureMonitor();
            TemperatureAlert alert = new TemperatureAlert();

            monitor.OnTemperatureChanged += alert.OnTemperatureChanged;

            monitor.Temperature = 20;

            monitor.Temperature = int.Parse(Console.ReadLine());
        }
    }
}
