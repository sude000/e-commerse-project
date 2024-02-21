using Odev2._3.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2._3.Entities;

public class Course : IEntity<string>
{
    public decimal Price { get; set; }
    public string Description { get; set; }
    public string Id { get; set; }
    public string Name { get; set; }
}
