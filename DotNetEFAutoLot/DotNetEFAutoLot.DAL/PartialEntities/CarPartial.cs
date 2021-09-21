using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetEFAutoLot.DAL.EF
{
    public partial class Car
    {
        public override string ToString()
        {
            return $"{this.CarNickName ?? "*** No Name ***"} is {this.Color}";
        }
    }
}
