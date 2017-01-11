using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControls
{
    class Item
    {
        public string Text { get; set; }
        public double Angle { get; set; }
        public double ReverseAngle { get { return -this.Angle; } }
    }
}
