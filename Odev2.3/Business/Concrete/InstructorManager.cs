using Odev2._3.Business.Abstract;
using Odev2._3.DataAccess.Abstract;
using Odev2._3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2._3.Business.Concrete;

public class InstructorManager : IInstructorService
{
    IInstructorDal _instructorDal;

    public InstructorManager(IInstructorDal instructorDal)
    {
        _instructorDal = instructorDal;
    }
    public void Add(Instructor instructor)
    {
        if (instructor.Name.Length >= 6)
        {
            _instructorDal.Add(instructor);
        }
    }

    public void Delete(int id)
    {
        _instructorDal.Delete(id);
    }

    public List<Instructor> GetAll()
    {
        return _instructorDal.GetAll();
    }

    public Instructor GetById(int id)
    {
        return _instructorDal.GetById(id);
    }

    public void Update(Instructor instructor)
    {
        _instructorDal.Update(instructor);
    }
}
