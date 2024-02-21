using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2._3.DataAccess.Abstract;

public interface IEntity<T>
{
    public T Id { get; set; }
    public string Name { get; set; }
}
