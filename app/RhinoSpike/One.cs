using System.Collections.Generic;

namespace RhinoSpike
{
    public class One : IOne
    {
        public List<int> GetAList() {
            List<int> returnList = new List<int>();
            returnList.Add(1);
            returnList.Add(2);
            returnList.Add(3);

            return returnList;
        }
    }
}