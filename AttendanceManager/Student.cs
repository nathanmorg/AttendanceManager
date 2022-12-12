namespace AttendanceManager
{
    class Student
    {
        //Data members
        private int _id;
        private string _firstName;
        private string _lastName;
        private string _teacher;
        private int _gradeLevel;
        private int _numberAbsences;

        public int id { get => _id; set => _id = value; }
        public string firstName { get => _firstName; set => _firstName = value; }
        public string lastName { get => _lastName; set => _lastName = value; }
        public string teacher { get => _teacher; set => _teacher = value; }
        public int gradeLevel { get => _gradeLevel; set => _gradeLevel = value; }
        public int numberAbsences { get => _numberAbsences; set => _numberAbsences = value; }

        //Constructors
        public Student() { }
        public Student(int i, string f, string l, string t, int g, int n)
        {
            id = i; 
            firstName = f;  
            lastName = l;
            teacher = t;
            gradeLevel = g;
            numberAbsences = n;
        }
    }
}
