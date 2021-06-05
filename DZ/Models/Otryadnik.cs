using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DZ.Models
{
    public class Otryadnik
    {
        public int Id { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Name { get; set; }
        public string Surname { set; get; }
        public int? PositionId { get; set; }
        public virtual PositionsModel Position { get; set; }
        public int? DetachmentId { get; set; }
        public virtual DetachmentsModel Detachment { get; set; }
    }
}
