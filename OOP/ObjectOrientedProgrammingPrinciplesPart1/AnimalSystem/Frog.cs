namespace AnimalSystem
{
    internal class Frog : Animal
    {
        private const string FrogSoundFile = "Croaking 2x-SoundBible.com-392413339.wav";

        public Frog(string name, int age, Sex sex)
            : base(name, age, sex)
        {
        }

        public void MakeSound()
        {
            MakeSound(FrogSoundFile);
        }
    }
}