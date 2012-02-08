using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wistia
{

    public class Thumbnail
    {
        public string Url { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        /// <summary>
        /// Get Url with .jpg extension
        /// </summary>
        /// <returns></returns>
        public string GetBaseUrl()
        {
            int i = Url.LastIndexOf("?");
            if (i > 0)
                return Url.Remove(i);
            else
                return Url;
        }

        /// <summary>
        /// Get resized thumbnail url
        /// </summary>
        /// <param name="width"></param>
        /// <param name="growIfSmaller"></param>
        /// <returns></returns>
        public string GetResizedUrl(int width, bool growIfSmaller)
        {
            return GetBaseUrl() + string.Format("?image_resize={0}{1}", width, (!growIfSmaller) ? ">" : "");
        }

        /// <summary>
        /// Get cropped and resized thumbnail image url
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public string GetFixedResizeUrl(int width, int height)
        {
            return GetBaseUrl() + string.Format("?image_crop_resized={0}x{1}", width, height);
        }
    }
}
