using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aks.Services.Web.Models {

    public class Data {

        public Data(string self, Data child = null) {
            this.Self = self;
            this.Child = child;
        }

        public string Self { get; set; }

        public Data Child { get; set; }
    }
}
