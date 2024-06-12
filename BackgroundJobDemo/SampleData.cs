using System.Collections.Concurrent;

namespace BackgroundJobDemo
{
    public class SampleData
    {
        public ConcurrentBag<string> Data { get; set; } = new ();

    }
}
