using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployerPlugins
{
    public class PostSetEmployerDescription : IPlugin
    {

        public void Execute(IServiceProvider serviceProvider)
        {
            // Obtain the execution context from the service provider.
            IPluginExecutionContext context = (IPluginExecutionContext)
               serviceProvider.GetService(typeof(IPluginExecutionContext));

            // The InputParameters collection contains all the data passed in the message request.

            if (context.InputParameters.Contains("Target") &&
               context.InputParameters["Target"] is Entity)
            {

                // Obtain the target entity from the input parameters.

                Entity currEmployer = context.InputParameters["Target"] as Entity;

                try
                {
                    //Entity updateEmployer = new Entity("new_employer");
                    //updateEmployer.Id = currEmployer.Id;

                    //updateEmployer["new_name"] = currEmployer["new_name"];
                    //updateEmployer["ownerid"] = currEmployer["ownerid"];
                    //updateEmployer["new_employertype"] = currEmployer["new_employertype"];
                    //updateEmployer["new_foundon"] = currEmployer["new_foundon"];
                    //updateEmployer["new_employerdescription"] = "it’s the value updated by my plugin";
                    currEmployer["new_employerdescription"] = "it’s the value updated by my plugin";

                    // Obtain the organization service reference.
                    IOrganizationServiceFactory serviceFactory =
                       (IOrganizationServiceFactory)serviceProvider.GetService
                       (typeof(IOrganizationServiceFactory));
                    IOrganizationService service =
                       serviceFactory.CreateOrganizationService(context.UserId);

                    // Perform the update.
                    service.Update(currEmployer);
                }
                //try
                //{
                //    Entity currEmployer = context.InputParameters["Target"] as Entity;

                //    //Entity updateEmployer = new Entity("new_employer");
                //    //updateEmployer.Id = currEmployer.Id;

                //    //updateEmployer["new_name"] = currEmployer["new_name"];
                //    //updateEmployer["ownerid"] = currEmployer["ownerid"];
                //    //updateEmployer["new_employertype"] = currEmployer["new_employertype"];
                //    //updateEmployer["new_foundon"] = currEmployer["new_foundon"];
                //    //updateEmployer["new_employerdescription"] = "it’s the value updated by my plugin";
                //    currEmployer["new_employerdescription"] = "it’s the value updated by my plugin";

                //    // Obtain the organization service reference.
                //    IOrganizationServiceFactory serviceFactory =
                //       (IOrganizationServiceFactory)serviceProvider.GetService
                //       (typeof(IOrganizationServiceFactory));
                //    IOrganizationService service =
                //       serviceFactory.CreateOrganizationService(context.UserId);

                //    // Perform the update.
                //    service.Update(currEmployer);
                //}
                catch (Exception ex)
                {
                    throw new InvalidPluginExecutionException(ex.Message);
                }
            }
        }
    }
}
