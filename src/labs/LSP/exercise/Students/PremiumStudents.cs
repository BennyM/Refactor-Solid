using System;

namespace Students
{
    public class PremiumStudent : Student
    {
        public PremiumStudent(string emailAddress, Guid universityId)
            : base(emailAddress, universityId)
        {
            this.MonthlyEbookAllowance = Student.STANDARD_ALLOWANCE * 2;
        }

        public override void AddBonusAllowance()
        {
            this.MonthlyEbookAllowance += 10;
        }
    }
}