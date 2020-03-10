public static class BusinessRules
{
    public static bool isSpecial(Student student) => 
        student.studentId > highCount;

    public static int highCount = 100;
}