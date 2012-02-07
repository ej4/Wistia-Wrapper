using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wistia
{
    public class RequestFilter
    {
        private int page = 1;
        /// <summary>
        /// The name of the field to sort by. 
        /// Valid values for Projects are name, mediaCount, created, or updated. 
        /// Valid values for Medias are name, created, or updated.
        /// Any other value will cause the results to be sorted by id, which is the default.
        /// </summary>
        public string SortBy { get; set; }

        /// <summary>
        /// Whether to sort Descending or Ascending
        /// </summary>
        public SortDirection SortDirection { get; set; }

        /// <summary>
        /// Specifies which page of the results you want to see. Note that this parameter starts at 1, as opposed to 0.
        /// </summary>
        public int Page { get; set; }
     
        /// <summary>
        /// This parameter lets you set how many results you want to get back in each request. 
        /// In order to mitigate long-running requests to the API, the maximum value of this parameter is 100.
        /// </summary>
        public int PerPage { get; set; }

        public string GetFilterString()
        { 
            string f = string.Empty;

            if (!string.IsNullOrEmpty(this.SortBy))
                f += "sort_by=" + this.SortBy;

            if (this.SortDirection == SortDirection.descending)
            {
                if (!string.IsNullOrEmpty(f))
                    f += "&";
                f += "sort_direction=0";
            }

            if (this.Page > 1)
            {
                if (!string.IsNullOrEmpty(f))
                    f += "&";
                f += "page=" + this.Page.ToString();
            }

            if (this.PerPage > 0)
            {
                if (!string.IsNullOrEmpty(f))
                    f += "&";
                f += "per_page=" + this.PerPage.ToString();
            }

            return f;
        }
    }
}
