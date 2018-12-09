using System;

namespace Students
{
    public interface IStudentFactory
    {
        Student Create(string emailAddress, Guid universityId, Package package);
    }

}