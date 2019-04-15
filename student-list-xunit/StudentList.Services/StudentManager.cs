using System;

namespace StudentList.Services
{
    public class StudentManager
    {
        private StudentStorage _storage;
        
        public StudentManager()
        {
            _storage = new StudentStorage();
        }

        public StudentManager(StudentStorage storage)
        {
            _storage = storage;
        }
        public string [] GetAllStudents()
        {
            var studentList = _storage.LoadStudentList();
            return studentList.Split(',');  
        }

        public int CountStudents()
        {
            var studentList = _storage.LoadStudentList();
            return studentList.Split(',').Length;
            //throw new NotImplementedException("Write some tests");
        }

        public string PickRandomStudent()
        {
            var studentList = _storage.LoadStudentList();
            var students = studentList.Split(',');

            var rand = new Random();
            var randIndex = rand.Next(0, students.Length);
            return students[randIndex];
            //throw new NotImplementedException("Write some tests");
        }
    }
}
