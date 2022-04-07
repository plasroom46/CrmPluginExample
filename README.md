# CrmPluginExample

## onboard

### [Microsoft Dynamics CRM](https://www.tutorialspoint.com/microsoft_crm/microsoft_crm_overview.htm)

### Web Application TS

[Streamline JavaScript web resource development using Fiddler AutoResponder](https://docs.microsoft.com/en-us/dynamics365/customerengagement/on-premises/developer/streamline-javascript-development-fiddler-autoresponder?view=op-9-1&viewFallbackFrom=op-9-1;)
[Set up a Postman environment](https://docs.microsoft.com/en-us/powerapps/developer/data-platform/webapi/setup-postman-environment)

### [Networking](https://www.cloudflare.com/zh-tw/learning/ssl/what-happens-in-a-tls-handshake/)

### Implement 

![](https://i.imgur.com/sYXfoJC.jpg)

1. Provision a new OOB CRM online environment
2. [Create two new customized entities A and B.](https://www.tutorialspoint.com/microsoft_crm/microsoft_crm_entities_and_records.htm)
a. Including all types of fields on A entity: single/multiple line textbox, datetime, lookup, etc.
3. Put the Entities under a new area in both UCI app and Classic client - sitemap
4.  Add a new Ribbon Button on the entity main form named "PROCEED"
5. Implement the functionality
a. When clicking the "PROCEED" button, save the record and alert a Yes/No dialog saying 'Are you sure to save the record" for coming the save operation.
[6. Implement a plugin](https://www.tutorialspoint.com/microsoft_crm/microsoft_crm_plugins.htm)
a. Following with above saving step, when saving, set the value of A field to "it's the value updated by my plugin"
[7. Implement a workflow](https://www.tutorialspoint.com/microsoft_crm/microsoft_crm_workflow_processes.htm)
a. After record get saved, trigger the workflow to create another Entity B record.


### Search

[Tutorials](https://docs.microsoft.com/en-us/dynamics365/customerengagement/on-premises/developer/tutorials-resources-sdk?view=op-9-1)

[source code](https://github.com/microsoft/PowerApps-Samples)

[CRUD](https://github.com/microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/CRUD-Dynamic-Entity)

[Customer Service Module Training in Dynamics 365 | Complete Tutorial Step by Step](https://www.youtube.com/watch?v=ppk0IIm6kN4)

==[What is Microsoft Dynamics CRM | Dynamics CRM for Developer | Dynamics CRM Training](https://www.youtube.com/watch?v=3FqhZDYLul0)==

[Create a sample UCI App in Dynamics 365 Customer Engagement](https://softchief.com/2019/12/09/create-a-sample-uci-app-in-dynamics-365-customer-engagement/)

3. [Ease Navigation, Edit the Site Map in Dynamics 365](https://www.crmsoftwareblog.com/2018/12/ease-navigation-edit-the-site-map-in-dynamics-365/)

[Ribbon workbench (Part-1) for Dynamics 365- How to install ribbon workbench](https://softchief.com/2021/10/25/ribbon-workbench-part-1-for-dynamics-365-how-to-install-ribbon-workbench/)

https://www.youtube.com/watch?v=678tljGY3eQ

https://community.dynamics.com/crm/b/dynamicsdevpro/posts/know-how-add-a-ribbon-button-using-ribbon-workbench

==[ribbon workbench problem](https://community.dynamics.com/crm/f/microsoft-dynamics-crm-forum/298984/problems-when-creating-a-button-in-ribbon-workbench/861783)==

https://www.c-sharpcorner.com/article/overriding-out-of-box-command-button-behavior-step-by-step-uci/

[How To Download The Dynamics 365 CE Plugin Registration Tool](https://www.c-sharpcorner.com/article/how-to-download-the-dynamics-365-ce-plugin-registration-tool/)

#### Test Env
https://admin.powerplatform.microsoft.com/environments?geo=Apac