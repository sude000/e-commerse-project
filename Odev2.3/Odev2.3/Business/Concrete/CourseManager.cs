using Odev2._3.Business.Abstract;
using Odev2._3.DataAccess.Abstract;
using Odev2._3.DataAccess.Concrete.Dapper;
using Odev2._3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2._3.Business.Concrete;

public class CourseManager : ICourseService
{
    ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    
    public void Add(Course course)
    {
        if(course.Name.Length > 10 && course.Price >= 0)
        {
            _courseDal.Add(course);
        }
    }

    public void Delete(string id)
    {
        _courseDal.Delete(id);
    }

    public List<Course> GetAll()
    {
        return _courseDal.GetAll();
    }

    public Course GetById(string id)
    {
        return _courseDal.GetById(id);
    }

    public void Update(Course course)
    {
        _courseDal.Update(course);
    }
}
