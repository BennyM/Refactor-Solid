namespace Students
{
    public interface IStudentRepository
    {
        void Add(Student student);
        bool Exists(string emailAddress);
    }
}