using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wistia
{
    public abstract class WistiaBase
    {
        /// <summary>
        /// Exception encountered during API request
        /// </summary>
        public RestException RestException { get; set; }
        /// <summary>
        /// The URI for this resource, relative to https://api.wistia.com
        /// </summary>
        public Uri Uri { get; set; }
    }
}
