using System.Collections.Generic;
using Machine.Specifications;
using Rhino.Mocks;


namespace RhinoSpike.Test
{
    [Subject("MainGate")]
    public class ctor_ : MainGate_Contexts
    {

        private Establish context
            = () =>
                  {
                      Expect.Call(_one.GetAList()).Return(new List<int>());
                      Expect.Call(_two.GetAList()).Return(new List<int>());
                  };

        private Because of = () => {
                                       _mockery.ReplayAll();
                                       gate = new MainGate(_one, _two);
                                    };

        private It should_call_IOne_GetAList =()=> _one.VerifyAllExpectations();
        private It should_call_ITwo_GetAList = () => _two.VerifyAllExpectations();

    }
}
