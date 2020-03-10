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
    private const string special = "b";

    [SetUp]
    public void Setup()
    {
        _studentRepository = A.Fake<IStudentRepository>();

        _studentService = new StudentService(_studentRepository);
    }

    [Test]
    public void SpecialStudents()
    {
        // Arrange (Given)
        A.CallTo(() => _studentRepository.GetAllStudents());

        // Act (When)
        var studentViewModels = _studentService.GetAllStudents();

        // Assert (NUnit Assertions) (Then)
        Assert.That(studentViewModels.Any(pdto => pdto.Special), Is.EqualTo(true));

        // Assert (FluentAssertions) (Then)
        studentViewModels.Any(pdto => pdto.Special).Should().BeTrue();
    }

    [Test]
    public void NotSpecialStudents()
    {
        // Arrange (Given)
        A.CallTo(() => _studentRepository.GetAllStudents());

        // Act (When)
        var studentViewModels = _studentService.GetAllStudents();

        // Assert (NUnit Assertions) (Then)
        Assert.That(studentViewModels.Any(pdto => pdto.Special), Is.EqualTo(false));

        // Assert (FluentAssertions) (Then)
        studentViewModels.Any(pdto => pdto.Special).Should().BeFalse();
    }


}