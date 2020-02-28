using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Table("student")]
public class Student
{
    [Column("id")]
    [Key]
    public long Id {get; set;}

    [Column("Student Id")]
    public int StudentId {get; set;}

    [Column("Email Address")]
    public decimal EmailAddress {get; set;}
}