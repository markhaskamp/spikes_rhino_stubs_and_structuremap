
using System.Collections.Generic;

namespace RhinoSpike
{
    public class MainGate
    {
        private IOne _one;
        private ITwo _two;
        public MainGate(IOne one, ITwo two) {
            _one = one;
            _two = two;

            List<int> aList = _one.GetAList();
            List<int> twoList = _two.GetAList();
        }
    }
}
