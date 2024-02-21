using Odev2._3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2._3.DataAccess.Abstract;

public interface IInstructorDal
{
    public void Add(Instructor instructor);
    public List<Instructor> GetAll();
    public void Update(Instructor instructor);
    public void Delete(int id);
    public Instructor GetById(int id);
}
