using System;

namespace Students
{
    public interface IUniversityRepository
    {
        University GetById(Guid universityId);
    }
}