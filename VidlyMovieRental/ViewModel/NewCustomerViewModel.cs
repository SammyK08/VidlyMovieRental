using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyMovieRental.Models;

namespace VidlyMovieRental.ViewModel
{
    public class NewCustomerViewModel
    {

       public IEnumerable<MembershipType> MembershipTypes { get; set; }
       public Customer Customer { get; set; }
    }
}