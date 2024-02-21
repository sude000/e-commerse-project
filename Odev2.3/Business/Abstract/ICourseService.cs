using Odev2._3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2._3.Business.Abstract;

public interface ICourseService
{
    public void Add(Course course);
    public void Update(Course course);
    public void Delete(string id);
    public List<Course> GetAll();
    public Course GetById(string id);

}
