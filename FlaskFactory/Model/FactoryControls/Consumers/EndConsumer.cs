using FlaskFactory.Utils;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FlaskFactory.Model.FactoryControls
{
    /// <summary>
    /// Represents the final consumer in the production line that processes flasks for final output.
    /// </summary>
    internal class EndConsumer : Consumer
    {
        private List<ListViewItem> Consumed;

        /// <summary>
        /// Initializes a new instance of the EndConsumer class using the specified buffer.
        /// </summary>
        /// <param name="buffer">The buffer from which flasks are to be consumed.</param>
        public EndConsumer(Buffer buffer) : base(buffer)
        {
            Consumed = new List<ListViewItem>();
        }

        /// <summary>
        /// Prints the details of the current flask being processed.
        /// </summary>
        /// <returns>A string representation of the current flask.</returns>
        public string Print()
        {
            return CurrentFlask.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        public void Consume(object obj)
        {
            while (true)
            {
                if (Buffer.Count > 0)
                {
                    Pull();
                    if (CurrentFlask != null)
                    {
                        FlaskTypes flaskType = CurrentFlask.GetFlaskType();
                        Consumed.Add(new ListViewItem(Print()));
                        switch (flaskType)
                        {
                            case FlaskTypes.SodaFlask:
                                {
                                    Form1.SetSoldSoda(Consumed.ToArray());
                                }
                                break;
                            case FlaskTypes.BeerFlask:
                                {
                                    Form1.SetSoldBeer(Consumed.ToArray());
                                }
                                break;
                        }
                        CurrentFlask = null;
                    }
                }
            }
        }
    }
}
