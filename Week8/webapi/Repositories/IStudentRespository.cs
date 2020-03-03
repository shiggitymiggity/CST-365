using System.Collections.Generic;

public interface IStudentRepository
{
    List<Student> GetAllStudents();
    Student GetStudentById(int studentId);

    void AddStudent(Student student);

    void UpdateStudent(Student student);

    void DeleteStudent(int studentId);
}