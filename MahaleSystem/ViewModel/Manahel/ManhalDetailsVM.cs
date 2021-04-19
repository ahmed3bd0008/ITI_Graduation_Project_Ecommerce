using MahaleSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MahaleSystem.ViewModel.Manahel
{
    public class ManhalDetailsVM
    {
        public MahaleSystem.Models.Manahel manhal { get; set; }
        public List<Khalias> MyProperty { get; set; }
        public List<ImagesManahel> imagesManahels { get; set; }
    }
}
