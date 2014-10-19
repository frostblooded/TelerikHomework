namespace AnimalSystem
{
    internal class Kitten : Cat
    {
        private const string CatSoundFile = "Cat.wav";

        public Kitten(string name, int age)
            : base(name, age, Sex.Female)
        {
        }

        public void MakeSound()
        {
            MakeSound(CatSoundFile);
        }
    }
}