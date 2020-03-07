using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using FakeItEasy;
using FluentAssertions;

public class StudentServiceTests
{
    private StudentService _studentService; // System Under Test (SUT)
    private IStudentRepository _studentRepository; // Mock

    [SetUp]
    public void Setup()
    {
        //var loggerFactory = A.Fake<LoggerFactory>();
        _studentRepository = A.Fake<IStudentRepository>();

        _studentService = new StudentService(_studentRepository);
    }

    [Test]
    public void ShouldNotReturnSpecialStudents()
    {
        // Arrange (Given)
        A.CallTo(() => _studentRepository.GetAllStudents()).Returns();

        // Act (When)
        var studentViewModels = _studentService.GetAllStudents();

        // Assert (NUnit Assertions) (Then)
        //Assert.That(studentViewModels.Any(pdto => pdto.special), Is.EqualTo(false));

        // Assert (FluentAssertions) (Then)
        studentViewModels.Any(pdto => pdto..special).Should().BeFalse();
    }

   /* [Test]
    public void ShouldReturnSpecialStudents()
    {
        // Arrange
        var expectedStudentName = special + "test";

        A.CallTo(() => _studentRepository.GetAllStudents()).Returns(
            new List<Student> {
                new Student {
                    studentId = 109,
                    email_Address = "john.smith@oit.edu",
                    special = true
                },
                new Student {
                    studentId = 108,
                    email_Address = "mary.jones@oit.edu",
                    special = true
                }
            
            }
        );

        // Act
        var studentViewModels = _studentService.GetAllStudents();

        // Assert (FluentAssertions)
        studentViewModels.Count(pdto => pdto.special).Should().Be(1);
        studentViewModels.Single(pdto => pdto.special).Name.Should().Be(expectedStudentName);
    }  */
}