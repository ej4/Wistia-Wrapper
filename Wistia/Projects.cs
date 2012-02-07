using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp;

namespace Wistia
{
    public partial class WistiaRestClient
    {
        /// <summary>
        /// List all Wistia Projects
        /// </summary>
        /// <returns></returns>
        public ProjectResult ListProjects()
        {
            var request = new RestRequest();
            request.Resource = "projects.xml";

            return Execute<ProjectResult>(request);
        }

        /// <summary>
        /// List all Wistia Projects with filters enabled
        /// </summary>
        /// <returns></returns>
        public ProjectResult ListProjects(RequestFilter filter)
        {
            var request = new RestRequest();
            request.Resource = "projects.xml?" + filter.GetFilterString();

            return Execute<ProjectResult>(request);
        }

        /// <summary>
        /// The Wistia data API allows you to retrieve details about a specific project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        public Project ShowProject(int projectId)
        {
            var request = new RestRequest();
            request.Resource = string.Format("projects/{0}.xml", projectId);

            return Execute<Project>(request);
        }

        /// <summary>
        /// Using the API, you can create a new project in your account.
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        public Project CreateProject(Project project)
        {
            var request = new RestRequest();
            request.Resource = "projects.xml";
            request.Method = Method.POST;
            request.AddObject(project);

            return Execute<Project>(request);
        }

        /// <summary>
        /// The Wistia data API allows you to update a project. Currently, the only attribute that you can update is the project name.
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        public Project UpdateProject(Project project)
        {
            var request = new RestRequest();
            request.Resource = string.Format("projects/{0}.xml", project.Id);
            request.Method = Method.PUT;
            request.AddObject(project);

            return Execute<Project>(request);
        }


        /// <summary>
        /// The Wistia data API allows you to delete a project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        public Project DeleteProject(int projectId)
        {
            var request = new RestRequest();
            request.Resource = string.Format("projects/{0}.xml", projectId);
            request.Method = Method.DELETE;

            return Execute<Project>(request);
        }

    }
}
