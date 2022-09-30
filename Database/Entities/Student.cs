namespace TesttDeployApiWithEFcoreAndDocker.Database.Entities
{
    public class Student
    {
        public Guid? StudentGUID { get; set; }

        public string FirstName { get; set; } = String.Empty;

        public string LastName { get; set; } = String.Empty;

        public virtual ICollection<Book> Book { get; }

        public Student()
        {
            Book = new List<Book>();
        }
    }
}
