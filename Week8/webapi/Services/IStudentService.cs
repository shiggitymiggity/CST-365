using System.Collections.Generic;

public interface IStudentService
{
    List<StudentViewModel> GetAllStudents();

    Student GetStudentById(int studentId);

    void AddStudent(Student student);

    void UpdateStudent(Student student);

    void DeleteStudent(int studentId);
}