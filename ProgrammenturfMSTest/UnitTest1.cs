namespace ProgrammenturfMSTest
{
    [TestClass]
    public class UnitTest1
    {
        private static MyList<Pokemon> generatePokedexList()
        {
            MyList<Pokemon> pokedex = new MyList<Pokemon>();
            pokedex.Add(new Pokemon(1, "Bisasam", "Pflanze", false));
            pokedex.Add(new Pokemon(4, "Glumanda", "Feuer", false));
            pokedex.Add(new Pokemon(5, "Glutexo", "Feuer", false));
            pokedex.Add(new Pokemon(7, "Schiggy", "Wasser", false));
            pokedex.Add(new Pokemon(11, "Safcon", "Kaefer", false));
            pokedex.Add(new Pokemon(12, "Smettbo", "Kaefer", false));
            pokedex.Add(new Pokemon(25, "Pikachu", "Elektro", false));
            pokedex.Add(new Pokemon(139, "Dragoran", "Drache", false));
            pokedex.Add(new Pokemon(263, "Zigzachs", "Normal", false));
            pokedex.Add(new Pokemon(865, "Lauchzelot", "Kampf", false));
            return pokedex;
        }

        private static MyQueue<Digimon> generateDigidexQueue()
        {
            MyQueue<Digimon> digidex = new MyQueue<Digimon>();
            digidex.Enqueue(new Digimon(1, "Digi1", 591));
            digidex.Enqueue(new Digimon(2, "Digi2", 592));
            digidex.Enqueue(new Digimon(3, "Digi3", 593));
            digidex.Enqueue(new Digimon(4, "Digi4", 594));
            digidex.Enqueue(new Digimon(5, "Digi5", 595));
            digidex.Enqueue(new Digimon(6, "Digi6", 596));
            digidex.Enqueue(new Digimon(7, "Digi7", 597));
            return digidex;
        }

        [TestMethod]
        public void TestMethodList1()
        {
            MyList<Pokemon> pokedex = generatePokedexList();
            MyList<Pokemon> primePokedex = pokedex.getPrimes();
            Assert.IsTrue(primePokedex.Count == 5);
        }

        [TestMethod]
        public void TestMethodList2()
        {
            MyList<Pokemon> pokedex = generatePokedexList();
            int count = MyPrimeHelper.getPrimeCollection(pokedex).Count();
            Assert.IsTrue(count == 5);
        }

        [TestMethod]
        public void TestMethodQueue()
        {
            MyQueue<Digimon> digidex = generateDigidexQueue();
            MyQueue<Digimon> primeDigidex = digidex.getPrimes();
            Assert.IsTrue(primeDigidex.Count == 4);
        }

        [TestMethod]
        public void TestMethodQueue2()
        {
            MyQueue<Digimon> digidex = generateDigidexQueue();
            int count = MyPrimeHelper.getPrimeCollection(digidex).Count();
            Assert.IsTrue(count == 4);
        }

        [TestMethod]
        [ExpectedException(typeof(MyInvalidIdException))]
        public void TestMethodForceException()
        {
            MyList<Pokemon> pokedex = new MyList<Pokemon>();
            pokedex.Add(new Pokemon(-1, "Bisasam", "Pflanze", false));
        }
    }
}