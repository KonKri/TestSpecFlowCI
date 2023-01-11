using System.Diagnostics;
using TechTalk.SpecFlow.Infrastructure;

namespace WebApi.Bdd.Test.Hooks
{
    [Binding]
    public class WebApiHooks
    {
        private Process Process;
        private readonly ISpecFlowOutputHelper _specFlowOutputHelper;

        public WebApiHooks(ISpecFlowOutputHelper specFlowOutputHelper)
        {
            _specFlowOutputHelper = specFlowOutputHelper;
        }

        [BeforeScenario]
        public void StartWebApi()
        {
            // set up information about the web api process.
            var processInfo = new ProcessStartInfo("dotnet", "run --project WebApi.Api");
            
            // get the aboslute directory of the web api project relative to the specflow test directory.
            processInfo.WorkingDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;

            // start web api process.
            Process = Process.Start(processInfo);

            Thread.Sleep(10000);

            _specFlowOutputHelper.WriteLine(">>>Api is up");
        }

        [AfterScenario]
        public void KillWebApi()
        {
            // terminate process after test runs are complete.
            Process.Kill();
        }
    }
}
