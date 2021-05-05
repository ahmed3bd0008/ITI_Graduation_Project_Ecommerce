using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MahaleSystem.ViewModel.Product
{
    public class PublishClientVM
    {
        public MahaleSystem.Models.ProductPublish productPublished { get; set; }
        public MahaleSystem.Models.Product product { get; set; }
        public MahaleSystem.Models.Identity.CustomIdentityuser admin { get; set; }

    }
}
