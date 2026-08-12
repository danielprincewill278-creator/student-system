using student_system.Dto;
using student_system.Models;

namespace student_system.Repositories
{
    public class StudentRepositoy : IStudentRepositoy
    {
        private readonly ApplicationDbContext _context; 
        public StudentRepositoy(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Students> GetAllStudents()
        {
            return _context.Students.ToList();

        }

        public string AddStudent(StudentDto student)
        {
            _context.Students.Add(new Students
            {
                StudentName = student.StudentName,
                Class = student.Class,
                Age = student.Age,
                Email = student.Email,
                DOB = student.DOB

            });

            _context.SaveChanges();
            return "Student Added Successfully";
        }

        public string UpdateStudent(StudentDtoUpdate student)
        {
            var data = _context.Students.FirstOrDefault(x => x.Id == student.Id);
            
            data.Age = student.Age;
            data.Email = student.Email;
            data.StudentName = student.StudentName;
            data.Class = student.Class;
            data.DOB = student.DOB;

            _context.Students.Update(data);
            _context.SaveChanges();
            return "Student Updated Successfully";
        }
        public string DeleteStudent(int studentId)
        {
            var data = _context.Students.FirstOrDefault(x => x.Id == studentId);
            _context.Students.Remove(data);
            _context.SaveChanges();
            return "Student Deleted Successfully";
        }
    }
}
