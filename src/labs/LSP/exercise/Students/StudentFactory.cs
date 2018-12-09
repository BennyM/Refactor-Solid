using System;

namespace Students
{
    public class StudentFactory : IStudentFactory
    {
        public Student Create(string emailAddress, Guid universityId, Package package)
        {
            switch (package)
            {
                case Package.Standard: return new StandardStudent(emailAddress, universityId); break;
                case Package.Premium: return new PremiumStudent(emailAddress, universityId); break;
                case Package.Unlimited: return new UnlimitedStudent(emailAddress, universityId); break;
                default: throw new NotImplementedException("There is no associated student for this package");
            }
        }
    }
}