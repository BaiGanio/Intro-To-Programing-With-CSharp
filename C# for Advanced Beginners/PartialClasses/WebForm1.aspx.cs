using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
namespace PartialClasses
{
    /*
     * STILL TO DO WITH PARTIALS
     */
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Customer c1 = new Customer {FirstName = "Boni", LastName = "Bonboni"};
            Response.Write("Full name is " +  c1.GetFullName() + "<br />");

            PartialCustomer pc1 = new PartialCustomer {FirstName = "Зайко", LastName = "Байко"};
            Response.Write("Full name is " + pc1.GetFullName() + "<br />");

        }
    }
}