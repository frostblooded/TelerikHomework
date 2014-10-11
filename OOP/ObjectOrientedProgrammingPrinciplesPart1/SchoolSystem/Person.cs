namespace SchoolSystem
{
    using System.Collections.Generic;

    public interface IPerson
    {
        string Name { get; }

        List<Discipline> Disciplines { get; }
    }
}
