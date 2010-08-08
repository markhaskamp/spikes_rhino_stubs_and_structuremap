using System.Collections.Generic;
using StructureMap;

namespace RhinoSpike
{
    public class MainGate
    {
        private IOne _one;
        private ITwo _two;

        public IList<int> MainList { get; set; }
        public MainGate() {
            ObjectFactory.Initialize(sm =>
                                         {
                                             sm.For<IOne>().Use<One>();
                                             sm.For<ITwo>().Use<Two>();
                                         });

            _one = StructureMap.ObjectFactory.GetInstance<IOne>();
            _two = StructureMap.ObjectFactory.GetInstance<ITwo>();

            MainList = _one.GetAList();
            List<int> twoList = _two.GetAList();
        }
    }
}
