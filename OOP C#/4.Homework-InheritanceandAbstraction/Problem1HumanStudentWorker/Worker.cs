using System;


namespace Problem1HumanStudentWorker
{
    class Worker : Human
    {
        private const int workingDaysPerWeek = 5;
        private decimal weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary can not be negative");
                }
                this.weekSalary = value; 
            }
        }

        public double WorkHoursPerDay 
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Work hours can not be negative");
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            return this.WeekSalary / ((decimal)this.WorkHoursPerDay * workingDaysPerWeek);
        }

        public override string ToString()
        {
            return string.Format("{0} Pay per hour: {1:F2}",base.ToString(), MoneyPerHour());
        }


    }
}
