using System.Data.SQLite;
using System.Collections.Generic;

namespace AttendanceManager
{
    class DatabaseHandler
    {
        //Data members
        SQLiteConnection connection;
        SQLiteCommand command;
        SQLiteDataReader reader;

        //Constructors
        public DatabaseHandler()
        {
            //Create connection string
            string connectionString = "Data Source=C:\\sqlite\\students.db";
            //Create a new connection using the connectionString as parameter and assign to connection object
            connection = new SQLiteConnection(connectionString);

            //Open the connection
            connection.Open();
        }

        //Methods
        public List<Student> getStudentsFromDatabase()
        {
            //create the command string and list to store students
            List<Student> importedStudents = new List<Student> ();
            string commandString = "SELECT * FROM STUDENTS";

            //Create and execute the command using the reader object
            command = new SQLiteCommand(commandString, connection);
            reader = command.ExecuteReader();

            //While a new record exists, read it in, and store it's data
            while (reader.Read())
            {
                //Temporarily store each column in a variable
                int id = reader.GetInt32(0);
                string firstName = reader["firstName"].ToString();
                string lastName = reader["lastName"].ToString();
                string teacher = reader["teacher"].ToString();
                int gradeLevel = reader.GetInt32(4);
                int numberAbsences = reader.GetInt32(5);

                //Use variables to create a new student
                Student s = new Student(id, firstName, lastName, teacher, gradeLevel, numberAbsences);

                //Add the new student to the list of students
                importedStudents.Add(s);
            }

            //Close the reader and return the list of students
            reader.Close();
            return new List<Student>();
        }

    }
}
