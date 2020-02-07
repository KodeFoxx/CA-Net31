using Kf.CANetCore31.Presentation.Desktop.Hosting.Extensions;
using Xunit;

namespace Kf.CANetCore31.Tests.UnitTests.Presentation.Desktop.Hosting.Extensions
{
    public sealed class ConsoleHostBuilderExtensionsTests
    {
        [Fact]
        public void Throws_ConsoleHostBuilderException_when_no_Run_method_with_return_type_Task_is_defined()
        {
            var exception = Assert.Throws<ConsoleHostBuilderException>(() =>
            {
                ConsoleHostBuilder.CreateAndRunApplication<ConsoleHostBuilderExtensionsTests>();
            });

            exception.Message.Contains(" because the 'Run' method's return type is not of type 'Task'");
        }
    }
}
