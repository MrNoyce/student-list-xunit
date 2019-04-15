using System;

namespace StudentList.Services
{
    public class StudentManager
    {
        private StudentStorage _storage;
        private const char StudentEntryDelimiter = ',';
        private Random _rand;
        private string _studentList;
        public StudentManager(StudentStorage storage)
        {
            _storage = storage;
            _rand = new Random();
            _studentList = _storage.LoadStudentList();
        }

        public string [] Students
        {
            get
            {
                return _studentList.Split(StudentEntryDelimiter);
            }
        }

        // Old implementation of Count and GetStudent
        #region
        // public string [] GetAllStudents()
        // {
        //     var studentList = _storage.LoadStudentList();
        //     return studentList.Split(',');  
        // }

        // public int CountStudents()
        // {
        //     var studentList = _storage.LoadStudentList();
        //     return studentList.Split(',').Length;
        //     //throw new NotImplementedException("Write some tests");
        // }
        #endregion

        public string PickRandomStudent()
        {
            var randIndex = _rand.Next(0,this.Students.Length);
            return this.Students[randIndex];

            // Old implementation of GetRandomStudent
            #region 
            // var studentList = _storage.LoadStudentList();
            // var students = studentList.Split(',');

            // var rand = new Random();
            // var randIndex = rand.Next(0, students.Length);
            // return students[randIndex];
            // //throw new NotImplementedException("Write some tests");
#endregion
        }
    }
}
