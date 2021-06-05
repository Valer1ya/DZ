using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DZ.Models
{
    public class DetachmentsModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public virtual ProfileModel Profile  { get; set; }
        public virtual UniversityModel University { get; set; }

    }
}
