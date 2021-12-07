using System;

namespace Classes_Exercises
{
    public class Stopwatch
    {
        private const bool V = true;
        private DateTime _start;
        private DateTime _stop;
        private TimeSpan _time;
        private Boolean _isStart;

        // Function to start the Stopwatch.
        public void Start()
        {
            // If the Stopwatch is running, an InvalidOperationException will be thrown.
            if (_isStart)
            {
                throw new InvalidOperationException();
            }

            // Otherwise start it and set the Boolean to true (active)
            _start = DateTime.Now;
            _isStart = true;
        }
        public string Stop()
        {
            _stop = DateTime.Now;
            _time = _stop - _start;
            _isStart = false;

            return "The stopwatch time was: "+ _time.ToString("mm\\:ss");
        }
    }
}
