using FlaskFactory.Utils;

namespace FlaskFactory.Model.FactoryControls
{
    public interface IPusher
    {
        void Push(FlaskTypes flaskType);
    }
}
