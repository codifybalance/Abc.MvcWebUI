using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Identity
{
    public class IdentityDataContext:IdentityDbContext<ApplicationUser>
    {
        public IdentityDataContext() : base("dataConnection")
        {

        }
        //base("identityConnection") dersekte ayrı vt. kullanırız "üye veritabanı" ve
        //web configde yeni bir connetionstring(identityConnection adında) tanımlarız.

    }
}