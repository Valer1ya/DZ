using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DZ.Models
{
    public class BrigadesEventModel
    {
        public int Id { get; set; }
        public virtual EventModel EventId { get; set; }
        public virtual DetachmentsModel BrigadeId { get; set; }
    }
}
