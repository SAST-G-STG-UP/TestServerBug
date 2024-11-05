/*
 *
 * (c) Copyright Ascensio System Limited 2010-2023
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * http://www.apache.org/licenses/LICENSE-2.0
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
*/


using System;
using System.Web;

using ASC.Web.Core.Utility;
using ASC.Web.Projects.Classes;
using ASC.Web.Projects.Resources;
using ASC.Web.Studio.Utility;

namespace ASC.Web.Projects.Controls.Templates
{
    public partial class EditTemplate : BaseUserControl
    {
        protected int ProjectTmplId;

        protected void Page_Load(object sender, EventArgs e)
        {
            var title = ProjectTemplatesResource.CreateProjTmpl;
            ProjectTmplId = UrlParameters.EntityID;

            if (ProjectTmplId >= 0)
            {
                title = ProjectTemplatesResource.EditProjTmpl;
            }

            Page.RegisterBodyScripts("~/Products/Projects/js/addmilestonecontainer.js");

            if (ModeThemeSettings.GetModeThemesSettings().ModeThemeName == ModeTheme.dark)
            {
                Page.RegisterStyle("~/Products/Projects/App_Themes/dark/dark-addmilestonecontainer.less");
            }
            else
            {
                Page.RegisterStyle("~/Products/Projects/App_Themes/default/css/addmilestonecontainer.less");
            }
            Page.Title = HeaderStringHelper.GetPageTitle(title);
        }

        protected string GetPageTitle()
        {
            return ProjectTmplId == 0 ? ProjectTemplatesResource.CreateProjTmpl : ProjectTemplatesResource.EditProjTmpl;
        }
    }
}