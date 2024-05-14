using FlaskFactory.Model.FactoryControls;
using System.Threading;
using System.Windows.Forms;

namespace FlaskFactory.Controllers
{
    public class Factory
    {
        private Producer _producer;
        private Buffer _productionBuffer;
        private Model.FactoryControls.Splitter _splitter;

        private EndConsumer _sodaEndConsumer;
        private Buffer _sodaFlaskBuffer;

        private EndConsumer _beerEndConsumer;
        private Buffer _beerFlaskBuffer;

        public Factory()
        {
            _productionBuffer = new Buffer();
            _sodaFlaskBuffer = new Buffer();
            _beerFlaskBuffer = new Buffer();
            _producer = new Producer(ProductionBuffer);
            _splitter = new Model.FactoryControls.Splitter(BeerFlaskBuffer, SodaFlaskBuffer, ProductionBuffer);
            _sodaEndConsumer = new EndConsumer(SodaFlaskBuffer);
            _beerEndConsumer = new EndConsumer(BeerFlaskBuffer);
        }

        public Buffer ProductionBuffer
        {
            get
            {
                return _productionBuffer;
            }

            private set
            {
                _productionBuffer = value;
            }
        }
        public Buffer SodaFlaskBuffer
        {
            get
            {
                return _sodaFlaskBuffer;
            }

            private set
            {
                _sodaFlaskBuffer = value;
            }
        }
        public Buffer BeerFlaskBuffer
        {
            get
            {
                return _beerFlaskBuffer;
            }
            private set
            {
                _beerFlaskBuffer = value;
            }
        }
        internal Producer Producer
        {
            get
            {
                return _producer;
            }
            private set
            {
                _producer = value;
            }
        }
        internal Model.FactoryControls.Splitter Splitter
        {
            get
            {
                return _splitter;
            }
            private set
            {
                _splitter = value;
            }
        }
        internal EndConsumer SodaEndConsumer
        {
            get
            {
                return _sodaEndConsumer;
            }
            private set
            {
                _sodaEndConsumer = value;
            }
        }
        internal EndConsumer BeerEndConsumer
        {
            get
            {
                return _beerEndConsumer;
            }
            private set
            {
                _beerEndConsumer = value;
            }
        }

        public void InitiateFactory()
        {
            Thread ProducerThread = new Thread(Producer.InitPush);
            Thread SplitterThread = new Thread(Splitter.InitSplitter);
            Thread SodaConsumerThread = new Thread(SodaEndConsumer.Consume);
            Thread BeerConsumerThread = new Thread(SodaEndConsumer.Consume);

            ProducerThread.IsBackground = true;
            SplitterThread.IsBackground = true;
            SodaConsumerThread.IsBackground = true;
            BeerConsumerThread.IsBackground = true;

            ProducerThread.Start();
            SplitterThread.Start();
            SodaConsumerThread.Start();
            BeerConsumerThread.Start();
        }
    }
}
