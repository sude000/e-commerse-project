using Odev2._3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2._3.Business.Abstract;

public interface IInstructorService
{
    public void Add(Instructor instructor);
    public void Update(Instructor instructor);
    public void Delete(int id);
    public List<Instructor> GetAll();
    public Instructor GetById(int id);

}
