using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DZ.ViewModels
{
    public class OtryadnikRegisterModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Position { get; set; }
        public string Detachment { get; set; }
    }
}
