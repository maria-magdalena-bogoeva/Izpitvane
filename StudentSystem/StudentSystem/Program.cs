using System;

namespace StudentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new StudentSystemContext();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }
    }
}
