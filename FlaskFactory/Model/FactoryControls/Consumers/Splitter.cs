using FlaskFactory.Model.Flasks;
using FlaskFactory.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaskFactory.Model.FactoryControls
{
    internal class Splitter : Consumer, IPusher
    {
        Buffer BeerBuffer, SodaBuffer;
        public Splitter(Buffer buffer) : base(buffer)
        {
        }

        public Splitter(Buffer beerBuffer, Buffer sodaBuffer, Buffer productionBuffer) : base(productionBuffer)
        {
            BeerBuffer = beerBuffer;
            SodaBuffer = sodaBuffer;
        }

        public void Push(FlaskTypes flaskType)
        {

            switch (CurrentFlask)
            {
                case BeerFlask beerFlask:
                    BeerBuffer.buffer.Enqueue(CurrentFlask);
                    break;
                case SodaFlask sodaFlask:
                    SodaBuffer.buffer.Enqueue(CurrentFlask);
                    break;
                default:
                    throw new InvalidOperationException("Unknown flask type.");
            }
        }
    }
}
