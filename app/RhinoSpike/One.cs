using System.Collections.Generic;

namespace RhinoSpike
{
    public class One : IOne
    {
        private IEleven _eleven;
        public One() {
            _eleven = new Eleven();
        }
        public List<int> GetAList() {
            List<int> returnList = new List<int>();

            returnList.Add(1);
            returnList.Add(2);
            returnList.Add(3);

            returnList.AddRange(_eleven.GetSome());

            return returnList;
        }
    }
}