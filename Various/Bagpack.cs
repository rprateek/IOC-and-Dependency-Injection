using System;
using System.Collections.Generic;
using System.Text;

namespace MultiThreading
{
    public class Bagpack
    {
        public string Item { get; set; }
        public int NoOfItems { get; set; }
    }

    public class Cache { }

    public class DiskCache : Cache { }

    public class MemoryCache : Cache { }

    public class OptimizedDisk : DiskCache { }
}
