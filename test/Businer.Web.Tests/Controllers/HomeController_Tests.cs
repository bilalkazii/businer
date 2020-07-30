using System.Threading.Tasks;
using Businer.Models.TokenAuth;
using Businer.Web.Controllers;
using Shouldly;
using Xunit;

namespace Businer.Web.Tests.Controllers
{
    public class HomeController_Tests: BusinerWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}