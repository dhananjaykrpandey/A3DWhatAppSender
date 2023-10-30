using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3DWhatAppSender.Classes.Model
{
    public class ContactDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactEmail { get; set; } = string.Empty;
        public string ContactPhone { get; set; } = string.Empty;
        public bool IsActive { get; set; }
    }
}
