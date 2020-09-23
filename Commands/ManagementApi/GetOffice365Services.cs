﻿using System.Collections.Generic;
using System.Management.Automation;
using PnP.Framework.Graph;
using PnP.PowerShell.CmdletHelpAttributes;
using PnP.PowerShell.Commands.Base;
using PnP.PowerShell.Commands.Model;
using PnP.PowerShell.Commands.Utilities.REST;

namespace PnP.PowerShell.Commands.ManagementApi
{
    [Cmdlet(VerbsCommon.Get, "PnPOffice365Services")]
    
    
    [CmdletOfficeManagementApiPermission(OfficeManagementApiPermission.ServiceHealth_Read)]
    public class GetOffice365Services : PnPOfficeManagementApiCmdlet
    {
        protected override void ExecuteCmdlet()
        {
            var collection = GraphHelper.GetAsync<GraphCollection<ManagementApiService>>(HttpClient, $"{ApiRootUrl}ServiceComms/Services", AccessToken, false).GetAwaiter().GetResult();

            if(collection != null)
            {
                WriteObject(collection.Items, true);
            }
        }
    }
}