namespace AngularJSAuthentication.API.Migrations
{
    using AngularJSAuthentication.API.Entities;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AngularJSAuthentication.API.AuthContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AngularJSAuthentication.API.AuthContext context)
        {
            //if (context.Clients.Count() > 0)
            //{
            //    return;
            //}

            //context.Clients.AddRange(BuildClientsList());
            //context.SaveChanges();
           // AddUserAndRole(context);
        }

        bool AddUserAndRole(AngularJSAuthentication.API.AuthContext context)
        {
            IdentityResult ir;
            var rm = new RoleManager<IdentityRole>
                (new RoleStore<IdentityRole>(context));
            ir = rm.Create(new IdentityRole("canEdit"));

            var um = new UserManager<IdentityUser>(
                new UserStore<IdentityUser>(context));

            var user = new IdentityUser()
            {
                UserName = "user1@contoso.com",
            };

            ir = um.Create(user, "P_assw0rd1");
            if (ir.Succeeded == false)
                return ir.Succeeded;
            ir = um.AddToRole(user.Id, "canEdit");
            return ir.Succeeded;
        }


        //private static List<Client> BuildClientsList()
        //{

        //    List<Client> ClientsList = new List<Client> 
        //    {
        //        new Client
        //        { Id = "OptymApp", 
        //            Secret= Helper.GetHash("abc@123"), 
        //            Name="OptymApp front-end Application", 
        //            ApplicationType =  Models.ApplicationTypes.JavaScript, 
        //            Active = true, 
        //            RefreshTokenLifeTime = 7200, 
        //            AllowedOrigin = "http://localhost:32150"
        //        },
        //        new Client
        //        { Id = "consoleApp", 
        //            Secret=Helper.GetHash("123@abc"), 
        //            Name="Console Application", 
        //            ApplicationType =Models.ApplicationTypes.NativeConfidential, 
        //            Active = true, 
        //            RefreshTokenLifeTime = 14400, 
        //            AllowedOrigin = "*"
        //        }
        //    };

        //    return ClientsList;
        //}
    }
}
