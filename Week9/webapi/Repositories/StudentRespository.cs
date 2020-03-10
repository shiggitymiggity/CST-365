using System.Collections.Generic;
using System.Linq;
//using Microsoft.Extensions.Logging;
using Database;
using System;

public class StudentRepository : IStudentRepository
{
    private readonly SchoolContext _dbContext;
    //private readonly ILogger _logger;

    public StudentRepository(SchoolContext dbContext/*, ILoggerFactory loggerFactory*/)
    {
        _dbContext = dbContext;
        //_logger = loggerFactory.CreateLogger("Controllers.StudentRepository");
    }

    public List<Student> GetAllStudents()
    {

        return _dbContext.Student.ToList();

        /*
        try
        {
            return _dbContext.Student.ToList();
        } 
        catch(Exception ex)
        {
            _logger.LogError("Failed to get students.", ex);
            
            return new List<Student>();
        }
        */
    }

    public Student GetStudentById(int studentId)
    {
        return _dbContext.Student.SingleOrDefault(p => p.studentId == studentId);
    }

    public void AddStudent(Student student)
    {
        _dbContext.Student.Add(student);
        _dbContext.SaveChanges();
    }

    public void UpdateStudent(Student studentUpdate)
    {
        var student = GetStudentById(studentUpdate.studentId);

        if (student != null)
        {
            student.studentId = studentUpdate.studentId;
            student.Email_Address = studentUpdate.Email_Address;

            _dbContext.Update(student);

            _dbContext.SaveChanges();
        }
    }

    public void DeleteStudent(int studentId)
    {
        var Student = new Student { studentId = studentId };

        _dbContext.Student.Attach(Student);
        _dbContext.Student.Remove(Student);
        _dbContext.SaveChanges();
    }
}