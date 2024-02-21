using Odev2._3.DataAccess.Abstract;
using Odev2._3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2._3.DataAccess.Concrete.Dapper;

public class EfCourseDal : ICourseDal
{
    List<Course> _courseList;

    public EfCourseDal()
    {
        Course course1 = new Course
        {
            Id = "12345",
            Name = "Senior Yazılım Geliştirici Yetiştirme Kampı (.NET)",
            Price = 0,
            Description = "İki aylık ileri bir kamp sizi bekliyor!"

        };

        Course course2 = new Course
        {
            Id = "12346",
            Name = "C# + ANGULAR Yazılım Geliştirici Yetiştirme Kampı",
            Price = 0,
            Description = "Gerçek hayat tecrübeleriyle zenginleştirilmiş örnekler!"
        };

        Course course3 = new Course
        {
            Id = "12347",
            Name = "JavaScript Yazılım Geliştirici Yetiştirme Kampı",
            Price = 0,
            Description = "1,5 ayda öğrenmek ister misin?"
        };

        _courseList = new List<Course> { course1, course2, course3 };

    }
    public void Add(Course course)
    {
        _courseList.Add(course);
        Console.WriteLine(course.Name + " EntityFramework ile dataya eklendi!");
    }

    public void Delete(string id)
    {
        Console.WriteLine(id + " Dapper ile silindi!");
        _courseList.RemoveAt(Convert.ToInt32(id));   
    }

    public List<Course> GetAll()
    {
        Console.WriteLine("EntityFramework ile data çekildi!");
        return _courseList;
    }

    public Course GetById(string id)
    {
        return _courseList.Where(c => c.Id == id).First();
    }

    public void Update(Course course)
    {
        Course oldCourse = _courseList.Where(c => c.Id == course.Id).First(); 
        oldCourse.Name = course.Name;
        oldCourse.Price = course.Price;
        oldCourse.Description = course.Description;
    }
}
