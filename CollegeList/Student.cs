namespace CollegeList
{
    public class Student : Person
    {
        private string field;
        private decimal gpa;

        public Student(string fname, string lname, string address, string zipCode, string phoneNUmb, string field, decimal gpa) : base (fname, lname, address, zipCode, phoneNUmb)
        {
            Field = field;
            GPA = gpa;
        }
        public decimal GPA
        {
            get { return gpa; }
            set {
                if (value > 0 && value < 4)
                {
                    gpa = value; 
                }else if(value > 4)
                {
                    gpa = 4;
                }
                else
                {
                    gpa = 0;
                }
            }
        }
        
        public string Field
        {
            get { return field; }
            set { field = value; }
        }

        public override string ToString()
        {
            return base.ToString() + $"\nField of study: {Field}\nGPA: {GPA}";
        }
        
    }
}