using System.Collections.Generic;

namespace RhinoSpike
{
    public class Two : ITwo
    {
        public List<int> GetAList() {
            List<int> returnList = new List<int>();
            returnList.Add(21);
            returnList.Add(22);
            returnList.Add(23);

            return returnList;
        }
    }
}