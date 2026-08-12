using student_system.Dto;
using student_system.Models;

namespace student_system.Repositories
{
    public interface IStudentRepositoy
    {
        List<Students> GetAllStudents();
        string AddStudent(StudentDto student);
        string UpdateStudent( StudentDtoUpdate student);
        string DeleteStudent(int studentId);
    }
}
