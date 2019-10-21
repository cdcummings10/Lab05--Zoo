using System;
using Xunit;
using Zoo;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        Marmot marmot = new Marmot();
        Jaguar jaguar = new Jaguar();
        Elephant elephant = new Elephant();
        Iguana iguana = new Iguana();
        Crocodile crocodile = new Crocodile();
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        public void TestIfMarmotIsAMammalFromSleepFunction(int animal)
        {
            Mammal[] arr = new Mammal[] { marmot, elephant};
            Assert.Equal("I sleep with my eyes closed.", arr[animal].Sleep());
        }
        [Fact]
        public void TestIfIguanaIsAReptileFromSleepFunction()
        {
            
            Assert.Equal("I sleep with my eyes open cuz I don't have eyelids.", iguana.Sleep());
        }
        [Fact]
        public void TestIfJaguarHasHaveFurProperty()
        {
            
            Assert.True(jaguar.HasFur);
        }
        [Theory]
        [InlineData(0, "Cold Blooded")]
        [InlineData(1, "Cold Blooded")]
        [InlineData(2, "Cold Blooded")]
        [InlineData(3, "Warm Blooded")]
        [InlineData(4, "Warm Blooded")]
        public void TestIfAnimalsHaveCorrectBloodTempProperty(int animal, string bloodType)
        {
            Animal[] arr = new Animal[] { marmot, jaguar, elephant, iguana, crocodile };
            Assert.NotEqual(bloodType, arr[animal].BloodTemp);
        }
        public void TestIfCrocodileHasScales()
        {
            Assert.True(crocodile.HasScales);
        }
    }
}
