namespace SchoolSystem
{
    public class Discipline : INameable
    {
        public Discipline(string name, int numberOfLectures, int numberOfExcercises)
        {
            Name = name;
            NumberOfLectures = numberOfLectures;
            NumberOfExcercises = numberOfExcercises;
        }

        public int NumberOfLectures { get; private set; }

        public int NumberOfExcercises { get; private set; }
        public string Name { get; private set; }
    }
}