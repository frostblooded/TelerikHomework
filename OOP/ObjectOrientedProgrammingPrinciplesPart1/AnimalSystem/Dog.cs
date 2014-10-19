namespace AnimalSystem
{
    internal class Dog : Animal
    {
        private const string DogSoundFile = "Dog.wav";

        public Dog(string name, int age, Sex sex)
            : base(name, age, sex)
        {
        }

        public void MakeSound()
        {
            MakeSound(DogSoundFile);
        }
    }
}