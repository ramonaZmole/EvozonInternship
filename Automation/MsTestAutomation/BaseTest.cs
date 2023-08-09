
namespace MsTestAutomation
{
    public class BaseTest
    {
        [TestInitialize]
        public virtual void Before()
        {
            // Browser.InitializeDriver(new DriverOptions { IsHeadless = true });
        }

        [TestCleanup]
        public virtual void After()
        {
            //if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            //{
            //    var imagePath = ScreenShot.GetScreenShotPath(TestContext.CurrentContext.Test.MethodName);
            //    TestContext.AddTestAttachment(imagePath);
            //}

            // Browser.Cleanup();
        }
    }
}
