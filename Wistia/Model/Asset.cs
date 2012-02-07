using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wistia
{
    public class Asset
    {
        public string Url { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int FileSize { get; set; }
        public string ContentType { get; set; }
        public AssetType type { get; set; }

    }
}
