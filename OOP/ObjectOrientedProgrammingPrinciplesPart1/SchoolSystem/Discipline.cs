namespace SchoolSystem
{
    public class Discipline : INameable
    {
        public string Name { get; private set; }

        public int NumberOfLectures { get; private set; }

        public int NumberOfExcercises { get; private set; }

        public Discipline(string name, int numberOfLectures, int numberOfExcercises)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExcercises = numberOfExcercises;
        }
    }
}
