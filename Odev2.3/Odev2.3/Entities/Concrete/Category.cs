using Odev2._3.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2._3.Entities;

public class Category : IEntity<int>
{
    public int Id { get; set; }
    public string Name { get; set; }
}

