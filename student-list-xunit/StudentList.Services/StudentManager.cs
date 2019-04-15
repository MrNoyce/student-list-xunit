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
        public string [] GetAllStudents()
        {
            var studentList = _storage.LoadStudentList();
            return studentList.Split(',');
            throw new NotImplementedException("write tests");
        }
    }
}
