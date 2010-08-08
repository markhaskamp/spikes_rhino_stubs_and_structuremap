using System.Collections.Generic;

namespace RhinoSpike
{
    public class OneHundredOne : IOneHundredOne
    {
        public IList<int> GetSomeMore() {
            IList<int> returnList = new List<int>();

            returnList.Add(101);
            returnList.Add(102);
            returnList.Add(103);

            return returnList;
        }
    }
}