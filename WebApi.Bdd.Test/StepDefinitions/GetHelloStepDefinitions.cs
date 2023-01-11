namespace WebApi.Bdd.Test.StepDefinitions
{
    [Binding]
    public class GetHelloStepDefinitions
    {
        private string Response;

        [When(@"making an HTTP GET req")]
        public async Task WhenMakingAnHTTPGETReqAsync()
        {
            // working...
            //var builder = WebApplication.CreateBuilder();
            //var startup = new Startup(builder.Configuration);
            //startup.ConfigureServices(builder.Services);
            //var app = builder.Build();
            //startup.Configure(app, builder.Environment);

            var client = new HttpClient();
            Response = await client.GetStringAsync(@"http://localhost:5001/api/Home");
        }

        [Then(@"the response should be hello")]
        public void ThenTheResponseShouldBeHello()
        {
            Assert.True(Response == "hello");
        }
    }
}
