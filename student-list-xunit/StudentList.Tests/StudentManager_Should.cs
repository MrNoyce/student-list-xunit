using System;
using Xunit;
using StudentList.Services;
using Moq;

namespace StudentList.Tests
{
    public class StudentManager_Should
    {
        Mock<StudentStorage> mockStorage;

        public StudentManager_Should()
        {
            mockStorage = new Mock<StudentStorage>();
            mockStorage.Setup(sm => sm.LoadStudentList()).Returns("student1,student2,student3");
        }

        [Fact]
        public void ReturnListOfstudents()
        {
            //Arrange
            var sut = new StudentManager(mockStorage.Object);

            //Act
            var actual = sut.Students;

            //Assert
            Assert.IsType(typeof(string[]), actual);
            Assert.True(actual.Length == 3);
            Assert.Contains("student2" ,actual);
        }

        [Fact]

        public void ReturnCorrectStudentCount()
        {
            
            //Arrange
            var sut = new StudentManager(mockStorage.Object);

            //Act
            var actual = sut.Students.Length;

            //Assert
            Assert.Equal(actual, 3);

        }

        [Fact]
        public void ReturnRandomStudent()
        {
            
            //Arrange
            var sut = new StudentManager(mockStorage.Object);
            var actualString = mockStorage.Object.LoadStudentList();

            //Act
            var expectedSubString = sut.PickRandomStudent();

            //Assert
            Assert.Contains(expectedSubString, actualString);

        }


        [Fact]
        public void ReturTrue_When_SearchingForExisting_Student()
        {
            //Arrange
            var sut = new StudentManager(mockStorage.Object);
            var existingStudent = "student1"; // This student is setup in mock student storage object

            //Act
            var actual = sut.StudentExist(existingStudent);

            //Assert
            Assert.True(actual);
        } 

        [Fact]
        public void ReturnFalse_When_SearchForNonExisting_Student()
        {
        //Given || Act
        var sut = new StudentManager(mockStorage.Object);
        var fakeStudent = "NotRealPerson";
        
        //When || Act
        var actual = sut.StudentExist(fakeStudent);
        
        //Then || Assert
        Assert.False(actual);

        }
    }
}