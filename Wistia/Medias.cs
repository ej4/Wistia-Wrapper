using RestSharp;

namespace Wistia
{
    public partial class WistiaRestClient
    {
        public MediaResult ListMedias()
        {
            var request = new RestRequest();
            request.Resource = "medias.xml";

            return Execute<MediaResult>(request);
        }

        public MediaResult ListMediasByProject(int projectId)
        {
            var request = new RestRequest();
            request.Resource = string.Format("medias.xml?project_id={0}", projectId);

            return Execute<MediaResult>(request);
        }

        /// <summary>
        /// The Wistia data API allows you to get information about a specific piece of media that you have uploaded to your account.
        /// </summary>
        /// <param name="mediaId"></param>
        /// <returns></returns>
        public Media ShowMedia(int mediaId)
        {
            var request = new RestRequest();
            request.Resource = string.Format("medias/{0}.xml", mediaId);

            return Execute<Media>(request);
        }

        /// <summary>
        /// The Wistia data API allows you to update a piece of media.
        /// </summary>
        /// <param name="media"></param>
        /// <returns></returns>
        public Media UpdateMedia(Media media)
        {
            var request = new RestRequest();
            request.Resource = string.Format("medias/{0}.xml", media.Id);
            request.Method = Method.PUT;
            request.AddObject(media);

            return Execute<Media>(request);
        }

        /// <summary>
        /// The Wistia data API allows you to delete a piece of media.
        /// </summary>
        /// <param name="mediaId"></param>
        /// <returns></returns>
        public Media DeleteMedia(int mediaId)
        {
            var request = new RestRequest();
            request.Resource = string.Format("medias/{0}.xml", mediaId);
            request.Method = Method.DELETE;

            return Execute<Media>(request);
        }


        /// <summary>
        /// The Wistia data API allows you to get the aggregated tracking statistics for a video that has been embedded on your site.
        ///
        /// Note: This request works for videos only. If you try to get stats for a piece of media that is not a video, 
        /// the server will respond with HTTP status code “400 Bad Request” and the body will contain an error message.
        /// </summary>
        /// <param name="mediaId"></param>
        /// <returns></returns>
        public Media ShowMediaStats(int mediaId)
        {
            var request = new RestRequest();
            request.Resource = string.Format("medias/{0}/stats.xml", mediaId);

            return Execute<Media>(request);
        }
    }
}
