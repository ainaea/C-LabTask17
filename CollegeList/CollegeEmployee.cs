namespace CollegeList
{
    public class CollegeEmployee : Person
    {
        private string ssn;
        private decimal salary;
        private string department;
        public CollegeEmployee(string fname, string lname, string address, string zipCode, string phoneNUmb, string ssn, decimal salary, string department) : base(fname, lname, address, zipCode, phoneNUmb)
        {
            SSN = ssn;
            Salary = salary;
            Department = department;
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        
        public decimal Salary
        {
            get { return salary; }
            set { 
                if (value > 0)
                {
                    salary = value;
                }else
                {
                    salary = 0;
                }
             }
        }
        
        public string SSN
        {
            get { return ssn; }
            set { ssn = value; }
        }

        public override string ToString()
        {
            return base.ToString() + $"\nSocial Security Number: {SSN}\nSalary: {Salary:C}\nDepartment : {Department}";
        }
        
    }
}