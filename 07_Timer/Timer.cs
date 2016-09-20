namespace _07_Timer
{
    internal class Timer
    {
        private int seconds = 0;
        public double Seconds
        
        {
            get { return seconds / 3600}
            set { seconds = value * 3600; }
        }

        public override string ToString()
        {

            return Seconds + "";
        }
    }
}