namespace CollegeList
{
    public abstract class Person
    {
        private string firstName;
        private string lastName;
        private string address;
        private string zipCode;
        private string phoneNumber;

        public Person(string fname, string lname, string address, string zipCode, string phoneNUmb)
        {
            FirstName = fname;
            LastName = lname;
            Address = address;
            ZipCode = zipCode;
            PhoneNumber = phoneNUmb;
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        
        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }
        
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}\nAddress: {Address}\nZip COde: {ZipCode}\nPhone number: {PhoneNumber}";
        }
        
    }
}