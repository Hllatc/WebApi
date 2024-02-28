using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities;

public class BaseEntity<TId>  //id yi generic hale getirdik.
{
    public TId Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UptadetDate { get; set; }
    public DateTime? DeletedDate { get; set; }
}
