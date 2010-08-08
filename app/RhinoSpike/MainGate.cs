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

            _one = ObjectFactory.GetInstance<IOne>();
            _two = ObjectFactory.GetInstance<ITwo>();

            MainList = _one.GetAList();
            List<int> twoList = _two.GetAList();
        }
    }
}
