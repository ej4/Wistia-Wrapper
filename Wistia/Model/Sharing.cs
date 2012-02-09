using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wistia
{
    public class Sharing : WistiaBase
    {
        public int Id { get; set; }
        public bool IsAdmin { get; set; }
        public bool CanShare { get; set; }
        public bool CanDownload { get; set; }
        public bool CanUpload { get; set; }
        public Share Share { get; set; }
        public Project Project { get; set; }
    }
}
