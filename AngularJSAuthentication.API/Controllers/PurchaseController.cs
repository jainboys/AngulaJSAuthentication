using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;

namespace AngularJSAuthentication.API.Controllers
{
    [RoutePrefix("api/purchase")]
    public class PurchaseController : ApiController
    {
        
        [Route("")]
      //  [Authorize]
            [AllowAnonymous]
        public IHttpActionResult Get()
        {
            return Ok(purchase.CreatePurchase());
        }

    }


    #region Helpers

    public class purchase
    {
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public string ShipperCity { get; set; }
        public Boolean IsShipped { get; set; }


        public static List<purchase> CreatePurchase()
        {
            List<purchase> OrderList = new List<purchase> 
            {
                new purchase {OrderID = 10248, CustomerName = "Purchaser 1", ShipperCity = "Amman", IsShipped = true },
                new purchase {OrderID = 10249, CustomerName = "Purchaser 2", ShipperCity = "Dubai", IsShipped = false},
                new purchase {OrderID = 10250,CustomerName = "Purchaser 3", ShipperCity = "Jeddah", IsShipped = false },
                new purchase {OrderID = 10251,CustomerName = "Purchaser 4", ShipperCity = "Abu Dhabi", IsShipped = false},
                new purchase {OrderID = 10252,CustomerName = "Purchaser 5", ShipperCity = "Kuwait", IsShipped = true}
            };

            return OrderList;
        }
    }

    #endregion
}
