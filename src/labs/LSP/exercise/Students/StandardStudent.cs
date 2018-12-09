using System;

namespace Students
{
    public class StandardStudent : Student
    {
        public StandardStudent(string emailAddress, Guid universityId)
            : base(emailAddress, universityId)
        {
            this.MonthlyEbookAllowance = Student.STANDARD_ALLOWANCE;
        }

        public override void AddBonusAllowance()
        {
            this.MonthlyEbookAllowance += 5;
        }
    }
}