using Odev2._3.DataAccess.Abstract;
using Odev2._3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2._3.DataAccess.Concrete.Dapper;

public class DCategoryDal : ICategoryDal
{

    List<Category> _categoryList;

    public DCategoryDal()
    {
        Category category1 = new Category
        {
            Id = 1,
            Name = "Backend"
        };

        Category category2 = new Category
        {
            Id = 2,
            Name = "Fullstack"
        };


        _categoryList = new List<Category> { category1, category2 };

    }
    public void Add(Category category)
    {
        _categoryList.Add(category);
        Console.WriteLine(category.Name + " Dapper ile dataya eklendi!");
    }

    public void Delete(int id)
    {
        Console.WriteLine(id + " Dapper ile silindi!");
        id--;
        _categoryList.RemoveAt(id);
    }

    public List<Category> GetAll()
    {
        Console.WriteLine("Dapper ile data çekildi!");
        return _categoryList;
    }

    public Category GetById(int id)
    {
        Console.WriteLine("Dapper id ile çağırıldı!");
        return _categoryList.Where(c=>c.Id == id).First();
    }

    public void Update(Category category)
    {
        Category oldCategory = _categoryList.Where(c=>c.Id == category.Id).First();        
        oldCategory.Name = category.Name;
        
    }
}
