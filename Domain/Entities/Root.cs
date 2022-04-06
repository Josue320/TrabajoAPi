using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Root
    {
        public coord coord { get; set; }
        public List<wheather> weather { get; set; }

        public main main { get; set; }
        public wind wind { get; set; }
        public sys sys { get; set; }
    }
}
