using Demo;

namespace ClassDemo.Tests
{
    [TestClass]
    //red
    public class UnitTest1
    {
        private List<Measurement> Bemeasurements(int piece)
        {
            var measurements=new List<Measurement>();
            for (int i = 0; i < piece; i++)
            {
                measurements.Add(new Measurement
                {
                    highest = 10,
                    lowest = 0
                });
            }
            return measurements;
        }
        [TestMethod]
        public void aListItemWhenWantedToWithOneGroupCountIsOne()
        {
            var measurements = new List<Measurement>()
            {
                new Measurement
                {
                    highest = 10,
                    lowest = 0
                }
                
                
            };
            var grouper = new Grouper(1);
            var groups = grouper.Group(measurements);

            Assert.AreEqual(1, groups.Count);
        }

        [TestMethod]
        public void groupNumbermustBe6WhenaListSixElementIsDesiredToBeGroupedTogether()
        {
            var measurements = new List<Measurement>()
            {
                new Measurement
                {
                    highest = 10,
                    lowest = 0
                },
                 new Measurement
                {
                    highest = 10,
                    lowest = 0
                },
                new Measurement
                {
                    highest = 10,
                    lowest = 0
                },
                 new Measurement
                {
                    highest = 10,
                    lowest = 0
                },
                 new Measurement
                {
                    highest = 10,
                    lowest = 0
                },
                new Measurement
                {
                    highest = 10,
                    lowest = 0
                }




            };
            var grouper = new Grouper(2);
            var groups = grouper.Group(measurements);

            Assert.AreEqual(3, groups.Count);
        }
        [TestMethod]
        public void groupNumbermustBe5WhenaList50ElementIsDesiredToBeGroupedBY10()
        {
            var measurements = new List<Measurement>()
            {
                new Measurement
                {
                    highest = 10,
                    lowest = 0
                },
                 new Measurement
                {
                    highest = 10,
                    lowest = 0
                },
                new Measurement
                {
                    highest = 10,
                    lowest = 0
                },
                 new Measurement
                {
                    highest = 10,
                    lowest = 0
                },
                 new Measurement
                {
                    highest = 10,
                    lowest = 0
                },
                new Measurement
                {
                    highest = 10,
                    lowest = 0
                }




            };
            var measurementss = Bemeasurements(50);
            var grouper = new Grouper(10);
            var groups = grouper.Group(measurementss);

            Assert.AreEqual(5, groups.Count);
        }
    }
}