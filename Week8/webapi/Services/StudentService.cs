using System.Collections.Generic;
using Microsoft.Extensions.Logging;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _studentRespository;
    //private readonly ILogger _logger;

    public StudentService(IStudentRepository studentRepository/*, ILoggerFactory loggerFactory*/)
    {
        _studentRespository = studentRepository;
        //_logger = loggerFactory.CreateLogger("Controllers.ProductService");
    }

    public List<StudentViewModel> GetAllStudents()
    {
        var studentViewModels = new List<StudentViewModel>();

        foreach(var student in _studentRespository.GetAllStudents())
        {
            studentViewModels.Add(new StudentViewModel {
                StudentId = student.studentId,
                Email_Address = student.Email_Address,
                Special = BusinessRules.isSpecial(student)
            });

            /*if (BusinessRules.isLowInventory(product))
            {
                _logger.LogInformation("Found low inventory product: " + product.ProductId);
            }*/
        }

        return studentViewModels;
    }

    public Student GetStudentById(int studentId)
    {
        return _studentRespository.GetStudentById(studentId);
    }

    public void AddStudent(Student student)
    {
        _studentRespository.AddStudent(student);
    }

    public void UpdateStudent(Student student)
    {
        _studentRespository.UpdateStudent(student);
    }

    public void DeleteStudent(int studentId)
    {
        _studentRespository.DeleteStudent(studentId);
    }
}