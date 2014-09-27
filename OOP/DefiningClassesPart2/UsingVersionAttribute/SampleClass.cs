using System;

namespace UsingVersionAttribute
{
    [Version("3.14")]
    class SampleClass
    {
        public int someInt { get; set; }

        [Version("3.15")]
        public string someString { get; set; }

        public SampleClass() { }
    }
}
