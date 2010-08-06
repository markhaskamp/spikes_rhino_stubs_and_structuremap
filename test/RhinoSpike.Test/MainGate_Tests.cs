using System.Collections.Generic;
using Machine.Specifications;
using NUnit.Framework;
using Rhino.Mocks;


namespace RhinoSpike.Test
{
    [TestFixture]
    public class MainGate_Tests
    {
        MockRepository mockery = new MockRepository();

        [Test]
        public void test_Foo() {
            IOne one = mockery.DynamicMock<IOne>();
            ITwo two = mockery.DynamicMock<ITwo>();

            MainGate mainGate;

            using (mockery.Record()) {
                Expect.Call(one.GetAList()).Return(new List<int>());
                Expect.Call(two.GetAList()).Return(new List<int>());
            }
            using (mockery.Playback()) {
                mainGate = new MainGate(one, two);
            }
            mockery.VerifyAll();
        }
    }
}
