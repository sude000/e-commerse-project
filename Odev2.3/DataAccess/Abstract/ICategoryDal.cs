using Odev2._3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2._3.DataAccess.Abstract;

public interface ICategoryDal
{
    public void Add(Category category);
    public List<Category> GetAll();
    public void Update(Category category);
    public void Delete(int id);
    public Category GetById(int id);
}
