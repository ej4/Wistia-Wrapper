using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wistia
{
    public class Media : WistiaBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Project Project { get; set; }
        public MediaType Type { get; set; }
        public decimal Progress { get; set; }
        public string Section { get; set; }
        public Thumbnail Thumbnail { get; set; }
        public decimal Duration { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public List<Asset> Assets { get; set; }
        public string EmbedCode { get; set; }
        public string Description { get; set; }
        public string Hashed_id { get; set; }
        public Stats Stats { get; set; }
    }
}
