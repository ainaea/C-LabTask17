namespace CollegeList
{
    public class Faculty : CollegeEmployee
    {
        private bool tenured;
        public Faculty(string fname, string lname, string address, string zipCode, string phoneNUmb, string ssn, decimal salary, string department, bool tenured) :base(fname, lname, address, zipCode, phoneNUmb, ssn, salary, department)
        {
            Tenured = tenured;
        }
        public bool Tenured
        {
            get { return tenured; }
            set { tenured = value; }
        }

        public override string ToString()
        {
            return base.ToString() + $"\nTenure: {Tenured}";
        }
        
    }
}