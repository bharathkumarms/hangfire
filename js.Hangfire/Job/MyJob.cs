using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace js.Hangfire.Job
{
    public class MyJob : IMyJob
    {
        public void Start()
        {
            Console.WriteLine("Job Started");
        }
    }
}
