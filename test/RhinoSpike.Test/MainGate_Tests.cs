using System.Collections.Generic;
using Machine.Specifications;
using Rhino.Mocks;


namespace RhinoSpike.Test
{
    [Subject("MainGate")]
    public class ctor_
    {

        private Establish context
            = () =>
                  {
                      _mockery = new MockRepository();
                      _one = _mockery.DynamicMock<IOne>();
                      _two = _mockery.DynamicMock<ITwo>();

                      Expect.Call(_one.GetAList()).Return(new List<int>());
                  };

        private Because of = () => {
                                       _mockery.ReplayAll();
                                       gate = new MainGate(_one, _two);
                                    };

        It should_call_IOne_GetAList =()=> _one.VerifyAllExpectations();

        private static MainGate gate;
        private static MockRepository _mockery;
        private static IOne _one;
        private static ITwo _two;
    }
}
