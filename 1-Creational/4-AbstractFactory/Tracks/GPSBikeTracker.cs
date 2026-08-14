namespace _4_AbstractFactory.Tracks
{
    public class GPSBikeTracker : ITracker
    {
        public void Track() => Console.WriteLine("Tracking Bike with GPS Tracker 🚴‍♂️");
    }

}