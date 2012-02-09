using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wistia
{
    public class Share : WistiaBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ShareType Type { get; set; }
        public string Email { get; set; }
    }
}
