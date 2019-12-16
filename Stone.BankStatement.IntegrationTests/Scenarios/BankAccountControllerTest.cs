using FluentAssertions;
using System.Net; 
using System.Threading.Tasks;
using Stone.BankStatement.IntegrationTests.Fixtures;
using Xunit;

namespace Stone.BankStatement.IntegrationTests.Scenarios
{
    public class BankAccountControllerTest
    {
        private readonly TestContext _testContext;
        public BankAccountControllerTest() =>
            _testContext = new TestContext();

        [Fact]
        public async Task Should_Return_Ok_Response_When_Values_Get()
        {
            var response = await _testContext.Client.GetAsync("api/v1/bankaccount");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task Should_Return_Ok_Response_When_Values_Get_Date_Filter()
        {
            var response = await _testContext.Client.GetAsync("api/v1/bankaccount?dateIni=2019-12-14&dateEnd=2019-12-14");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task Should_Return_BadRequest_Response_When_Values_Get_Date_Filter()
        {
            var response = await _testContext.Client.GetAsync("/api/v1/bankaccount?dateIni=XXX");
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task Should_Return_Correct_ContentType_When_Values_Get()
        {
            var response = await _testContext.Client.GetAsync("api/v1/bankaccount");
            response.EnsureSuccessStatusCode();
            response.Content.Headers.ContentType.ToString().Should().Be("application/json; charset=utf-8");
        }
    }
}