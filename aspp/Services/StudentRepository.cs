using aspp.DATA;
using aspp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspp.Services
{
    public class StudentRepository : IRepository
    {
      

            private readonly StudentDbContext _context;

            public StudentRepository(StudentDbContext context)
            {
                _context = context;
            }

            public void Add(Student item)
            {
                _context.Students.Add(item);
                _context.SaveChanges();
            }

            public void Delete(int id)
            {
                var user = _context.Students.Where(x => x.Id == id).ToArray();
                if (user != null)
                {
                    _context.Students.Remove(user[0]);
                    _context.SaveChanges();
                }
            }

            public Student Get(int id)
            {
                var user = _context.Students.Where(x => x.Id == id).ToArray();
                return user[0];
            }

            public IEnumerable<Student> GetAll()
            {
                return _context.Students.ToList();
            }

            public void Update(int id, Student item)
            {
                var user = Get(id);
                user.Name = item.Name;
            user.Surname = item.Surname;
            user.Age = item.Age;
            user.Salary = item.Salary;
            user.Address = item.Address;
            _context.SaveChanges();
            }
    }
}
