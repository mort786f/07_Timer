namespace _07_Timer
{
    internal class Timer
    {
        private int seconds = 0;
        public int Seconds
        {
            get { return seconds; }
            set { seconds = value; }
        }
        int hours = (int)(Seconds / 3600);
        int min = (int)(Seconds / 60) % 60;
        int sec = (int)(Seconds % 60);

        public override string ToString()
        {
            return hours.ToString() + ":" + min.ToString() + ":" + sec.ToString(); ;
        }
    }
}