using System.Media;
using System.Threading;
using System.Xml.Serialization;

namespace AnimalSystem
{
    internal class Tomcat : Cat
    {
        private const string CatSoundFile = "Cat.wav";

        public Tomcat(string name, int age)
            : base(name, age, Sex.Male)
        {
        }

        public void MakeSound()
        {
            MakeSound(CatSoundFile);
        }
    }
}