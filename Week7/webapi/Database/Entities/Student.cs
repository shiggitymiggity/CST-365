using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Table("student")]
public class Student
{
    //[Column("studentId")]
    //[Key]
    //public int Id {get; set;}

    [Column("student_id")]
    [Key]
    public int studentId {get; set;}

    //[Column("student_id")]
    //public int Student_Id {get; set;}

    [Column("email_address")]
    public string Email_Address {get; set;}
}