using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DZ.Models
{
    public class UniversityModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<DetachmentsModel> DetachmentsModel { get; set; }
        public UniversityModel()
        {
            DetachmentsModel = new List<DetachmentsModel>();
        }
    }
}

