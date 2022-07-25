using School.API.Data;
using School.API.Models;
using System.Collections.Generic;
using System.Linq;

namespace School.API.Services
{
    public class StudentService
    {
        private readonly ApplicationDbContext _db;
        public StudentService(ApplicationDbContext db)
        {
            _db = db;
        }
        public List<Student> GetAll (){
            return _db.Students.ToList();
        }
        public Student Get(int id)
        {
            return _db.Students.Find(id);
        }
        
    }
}
