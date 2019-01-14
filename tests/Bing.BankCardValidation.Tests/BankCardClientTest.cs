using Xunit;
using Xunit.Abstractions;

namespace Bing.BankCardValidation.Tests
{
    public class BankCardClientTest:TestBase
    {
        private readonly BankCardClient _client;
        public BankCardClientTest(ITestOutputHelper output) : base(output)
        {
            _client = new BankCardClient();
        }

        [Fact]
        public async void Test_Validate()
        {
            string cardNo = "6214863078427119";
            var result = await _client.ValidateAsync(cardNo);
            Output.WriteLine(result.ToJson());
            Assert.Equal("CMB", result.Code);
        }
    }
}
