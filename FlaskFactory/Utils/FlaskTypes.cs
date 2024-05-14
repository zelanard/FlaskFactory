using FlaskFactory.Model.Flasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaskFactory.Utils
{
    public enum FlaskTypes
    {
        BeerFlask,
        SodaFlask
    }

    public static class FlaskExtensions
    {
        public static FlaskTypes GetFlaskType(this Flask flask)
        {
            switch (flask)
            {
                case BeerFlask beerFlask:
                    return FlaskTypes.BeerFlask;
                case SodaFlask sodaFlask:
                    return FlaskTypes.SodaFlask;
                default:
                    throw
                        new NotImplementedException();
            }
        }
    }
}
