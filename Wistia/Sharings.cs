using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp;

namespace Wistia
{
    public partial class WistiaRestClient
    {

        public SharingResult ListSharings(int projectId)
        {
            var request = new RestRequest();
            request.Resource = string.Format("projects/{0}/sharings.xml", projectId);

            return Execute<SharingResult>(request);
        }

        public Sharing ShowSharing(int projectId, int sharingId)
        {
            var request = new RestRequest();
            request.Resource = string.Format("projects/{0}/sharings/{1}.xml", projectId, sharingId);

            return Execute<Sharing>(request);
        }

        //public Sharing CreateSharing(int projectId, Sharing sharing)
        //{
        //    var request = new RestRequest();
        //    request.Resource = string.Format("projects/{0}/sharings.xml", projectId);
        //    request.Method = Method.POST;
        //    request.AddObject(sharing);

        //    return Execute<Sharing>(request);
        //}


        public Sharing UpdateSharing(Sharing sharing)
        {
            var request = new RestRequest();
            request.Resource = string.Format("projects/{0}/sharings/{1}.xml", sharing.Project.Id, sharing.Id);
            request.Method = Method.PUT;
            request.AddObject(sharing);

            return Execute<Sharing>(request);
        }


        public Sharing DeleteSharing(int projectId, int sharingId)
        {
            var request = new RestRequest();
            request.Resource = string.Format("projects/{0}/sharings/{1}.xml", projectId, sharingId);
            request.Method = Method.DELETE;

            return Execute<Sharing>(request);
        }
    }
}
