namespace WebApi.Bdd.Test.StepDefinitions
{
    [Binding]
    public class GetHelloStepDefinitions
    {
        private string Response;

        [When(@"making an HTTP GET req")]
        public async Task WhenMakingAnHTTPGETReqAsync()
        {
            var client = new HttpClient();
            Response = await client.GetStringAsync(@"https://localhost:7062/api/Home");
        }

        [Then(@"the response should be hello")]
        public void ThenTheResponseShouldBeHello()
        {
            Assert.True(Response == "hello");
        }
    }
}
