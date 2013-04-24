

using NUnit.Framework;
namespace Weather.Api.Tests
{
    [TestFixture]
    public class HealthTest
    {
        [TestCase]
       public void TestHealth()
        {
            var target = new Health();
            Assert.AreEqual("REST SERVICE IS UP  AND  RUNNING",target.HealthStatus());
        }

      
    }
}
