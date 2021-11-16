using Moq;
using Xunit;

namespace UnitTestsDemoPart3.UnitTests
{
    public class GreeterTests
    {
        [Fact]
        public void SayHello_WhenCalled_CallsTheSendWelcomeEmailMethod()
        {
            var mockEmailer = new Mock<IEmailer>();
            var mockDatabaseRepository = new Mock<IDatabaseRepository>();

            var greeter = new Greeter(mockEmailer.Object, mockDatabaseRepository.Object);

            // Act
            greeter.SayHello("Tom");

            // Assert
            mockEmailer.Verify(v => v.SendWelcomeEmail("Tom"), Times.Once);
        }
    }
}
