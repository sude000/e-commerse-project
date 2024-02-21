using Odev2._3.DataAccess.Abstract;
using Odev2._3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2._3.DataAccess.Concrete.Dapper;

public class EfInstructorDal : IInstructorDal
{

    List<Instructor> _instructorList;

    public EfInstructorDal()
    {
        Instructor instructor1 = new Instructor
        {
            Id = 1,
            Name = "Engin Demiroğ"
        };

        Instructor instructor2 = new Instructor
        {
            Id = 2,
            Name = "Halit Enes Kalaycı"
        };

        _instructorList = new List<Instructor> { instructor1, instructor2 };

    }
    public void Add(Instructor instructor)
    {
        _instructorList.Add(instructor);
        Console.WriteLine(instructor.Name + " EntityFramework ile dataya eklendi!");
    }

    public void Delete(int id)
    {
        Console.WriteLine(id + "EntityFramework ile silindi!");
        _instructorList.RemoveAt(id);
    }

    public List<Instructor> GetAll()
    {
        Console.WriteLine("EntityFramework ile data çekildi!");
        return _instructorList;
    }

    public Instructor GetById(int id)
    {
        return _instructorList.Where(i => i.Id == id).First();
    }

    public void Update(Instructor instructor)
    {
        Instructor oldInstructor = _instructorList.Where(i => i.Id == instructor.Id).First();
        oldInstructor.Name = instructor.Name;
    }
}
