using ConsumeGitHubServices.Infrastructure.Repository;

namespace ConsumeGitHubServices.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var repo = new BranchRepository(I);
            Assert.Pass();
        }
    }
}