using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DZ.Models
{
    public class ProfileModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<DetachmentsModel> DetachmentsModel { get; set; }
        public ProfileModel()
        {
            DetachmentsModel = new List<DetachmentsModel>();
        }
    }
}
