using System.Collections.Generic;

namespace RhinoSpike
{
    public class Eleven : IEleven
    {
        private IOneHundredOne _oneHundredOne;
        public Eleven() {
            _oneHundredOne = new OneHundredOne();
        }
        public IList<int> GetSome() {
            IList<int> returnList = new List<int>();
            returnList.Add(11);
            returnList.Add(12);
            returnList.Add(13);

            return returnList;
        }
    }
}