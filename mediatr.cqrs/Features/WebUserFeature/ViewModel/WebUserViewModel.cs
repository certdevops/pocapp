using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatr.cqrs.Features.WebUserFeature.ViewModel
{
    public class WebUserViewModel
    {
        public string CompanyCode { get; set; }
        public string Username { get; set; }
        public string UserPassword { get; set; }
        public string EmailID { get; set; }
    }
}
