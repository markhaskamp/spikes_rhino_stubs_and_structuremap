using Machine.Specifications;
using Rhino.Mocks;

namespace RhinoSpike.Test
{
    public class MainGate_Contexts
    {
        protected static MainGate gate;
        protected static MockRepository _mockery;
        protected static IOne _one;
        protected static ITwo _two;
        protected static IEleven _eleven;
        protected static IOneHundredOne _oneHundredOne;

        private Establish contexts 
            = () =>
                     {
                         _mockery = new MockRepository();
                         _one = _mockery.DynamicMock<IOne>();
                         _two = _mockery.DynamicMock<ITwo>();
                     };
    }
}