using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Root
    {
        public Coord coord { get; set; }
        public List<Weather> weathers { get; set; }

        public Main main { get; set; }
        public Wind wind { get; set; }
        public Sys sys { get; set; }
    }
}
