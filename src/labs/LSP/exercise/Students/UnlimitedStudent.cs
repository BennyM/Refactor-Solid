using System;

namespace Students
{
    public class UnlimitedStudent : Student
    {
        public UnlimitedStudent(string emailAddress, Guid universityId)
            : base(emailAddress, universityId)
        {
            this.MonthlyEbookAllowance = 0;
        }

        public override void AddBonusAllowance()
        {
            throw new NotImplementedException();
        }
    }
}