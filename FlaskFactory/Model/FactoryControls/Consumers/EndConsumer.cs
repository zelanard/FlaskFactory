using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaskFactory.Model.FactoryControls
{
    internal class EndConsumer : Consumer
    {
        public EndConsumer(Buffer buffer) : base(buffer)
        {
        }

        public string Print()
        {
            return CurrentFlask.ToString();
        }
    }
}
