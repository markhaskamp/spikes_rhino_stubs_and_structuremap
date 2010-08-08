using System;
using RhinoSpike;
using StructureMap;


namespace ClientConsole
{
    class Program
    {
        static void Main(string[] args) {
            new Program();
        }

        public Program() {

            ObjectFactory.Initialize(sm =>
                                         {
                                             sm.For<IOne>().Use<One>();
                                             sm.For<ITwo>().Use<Two>();
                                         });
            MainGate mainGate = new MainGate();

            foreach (int mainListItem in mainGate.MainList) {
                Console.WriteLine(mainListItem);
            }
        }
    }
}
