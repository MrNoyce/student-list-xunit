using System;
using System.IO;
using System.Linq;

namespace StudentList.Services
{
    public class StudentStorage
    {
        public const string StudentList = "students.txt";

        ///<summary>
        ///Replaces tje contents of the student storage with the given string of content.
        ///The Method will also update the timestamp in the student storage.
        ///</summary>
        ///<param name="content">The new content for the student storage</param>
        public virtual void UpdateStudentList(string content)
        {
            var timestamp = String.Format("List last updated on {0}", DateTime.Now);

            // The 'using' construct does the heavy lifting of flushing a stream
            // and releasing system resources the stream was using.
            using (var fileStream = new FileStream(StudentList,FileMode.Open))
            using (var writer = new StreamWriter(fileStream))
            {
                writer.WriteLine(content);
                writer.WriteLine(timestamp);
            }
        }


        ///<summary>
        ///Reads student data from student storage
        ///</summary>
        ///<returns> A string of student names </returns>
        public virtual string LoadStudentList()
        {
            throw new NotImplementedException("Tests needed");
        }
    }
}