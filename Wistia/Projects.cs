using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp;

namespace Wistia
{
    public partial class WistiaRestClient
    {
        public ProjectResult ListProjects()
        {
            var request = new RestRequest();
            request.Resource = "projects.xml";

            return Execute<ProjectResult>(request);
        }

        public Project ShowProject(int projectId)
        {
            var request = new RestRequest();
            request.Resource = string.Format("projects/{0}.xml", projectId);

            return Execute<Project>(request);
        }

        public Project CreateProject(Project project)
        {
            var request = new RestRequest();
            request.Resource = "projects.xml";
            request.Method = Method.POST;
            request.AddObject(project);

            return Execute<Project>(request);
        }

        public Project UpdateProject(Project project)
        {
            var request = new RestRequest();
            request.Resource = string.Format("projects/{0}.xml", project.Id);
            request.Method = Method.PUT;
            request.AddObject(project);

            return Execute<Project>(request);
        }

        public Project DeleteProject(int projectId)
        {
            var request = new RestRequest();
            request.Resource = string.Format("projects/{0}.xml", projectId);
            request.Method = Method.DELETE;

            return Execute<Project>(request);
        }

    }
}
