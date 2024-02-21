using Odev2._3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2._3.DataAccess.Abstract;

public interface ICourseDal
{
    public void Add(Course course);
    public List<Course> GetAll();
    public void Update(Course course);
    public void Delete(string id);
    public Course GetById(string id);
}
