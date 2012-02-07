using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wistia
{
    /// <summary>
    /// Projects are the main organizational objects within Wistia. Media must be stored within Projects.
    /// </summary>
    public class Project : WistiaBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MediaCount { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public string HashedId { get; set; }
        public bool AnonymousCanUpload { get; set; }
        public bool AnonymousCanDownload { get; set; }
        public bool Public { get; set; }
        public string PublicId { get; set; }
    }
}
