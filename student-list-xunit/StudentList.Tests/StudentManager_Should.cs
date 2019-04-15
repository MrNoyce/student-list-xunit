using System;
using Xunit;
using StudentList.Services;
using Moq;

namespace StudentList.Tests
{
    public class StudentManager_Should
    {
        [Fact]
        public void ReturnListOfstudents()
        {
            //Arrange
            var sut = new StudentManager();

            //Act
            var actual = sut.GetAllStudents();

            //Assert
            Assert.IsType(typeof(string[]), actual);
            Assert.True(actual.Length > 0);
        }
    }
}