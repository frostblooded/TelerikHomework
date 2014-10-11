
namespace SchoolSystem
{
    using System.Collections.Generic;

    public class School
    {
        List<Class> Classes { get; set; }

        public School()
        {
            Classes = new List<Class>();
        }
    }
}
