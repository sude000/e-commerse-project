using Odev2._3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2._3.Business.Abstract;

public interface ICategoryService
{
    public void Add(Category category);
    public void Update(Category category);
    public void Delete(int id);
    public List<Category> GetAll();
    public Category GetById(int id);
}
