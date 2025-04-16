using Microsoft.AspNetCore.Mvc;
using techdemo.Data;

namespace techdemo.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{

    private readonly ILogger<StudentController> _logger;
    private readonly MyDbContext _db;

    public StudentController(ILogger<StudentController> logger, MyDbContext db)
    {
        _logger = logger;
        _db = db;
    }

    [HttpGet]
    public List<Student> Get()
    {
        var students = _db.Students.ToList();
        return students;
    }
    
    [HttpPost]
    public List<Student> AddStudent([FromBody] Student student)
    {
        _db.Students.Add(student);
        _db.SaveChanges();
        var students = _db.Students.ToList();
        return students;
    }
    
    [HttpPut]
    public Student UpdateStudent([FromBody] Student student)
    {
        Student stu = _db.Students.Find(student.Id);
        if (stu != null)
        {
            stu.Name = student.Name;
            stu.Age = student.Age;
            stu.Enrolled = student.Enrolled;
            stu.Email = student.Email;
            _db.SaveChanges();
        }
        return stu;
    }
    
    [HttpDelete]
    public List<Student> DeleteStudent([FromBody] Student student)
    {
        Student stu = _db.Students.Find(student.Id);
        if (stu != null)
        {
            _db.Students.Remove(stu);
            _db.SaveChanges();
        }
        var students = _db.Students.ToList();
        return students;
    }
}