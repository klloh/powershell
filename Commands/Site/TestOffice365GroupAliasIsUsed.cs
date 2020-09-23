﻿using PnP.Framework.Sites;
using PnP.PowerShell.CmdletHelpAttributes;
using System.Management.Automation;

namespace PnP.PowerShell.Commands.Site
{
    [Cmdlet(VerbsDiagnostic.Test, "PnPOffice365GroupAliasIsUsed")]
    public class AddOffice365GroupAliasIsUsed : PnPSharePointCmdlet
    {
        [Parameter(Mandatory = true)]
        public string Alias;

        protected override void ExecuteCmdlet()
        {
            var results = SiteCollection.AliasExistsAsync(ClientContext, Alias);
            var returnedBool = results.GetAwaiter().GetResult();
            WriteObject(returnedBool);
        }
    }
}