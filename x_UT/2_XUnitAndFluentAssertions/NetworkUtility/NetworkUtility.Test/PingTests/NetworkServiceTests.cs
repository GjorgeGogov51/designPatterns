using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NetworkUtility.Ping;

namespace NetworkUtility.Test.PingTests
{
	public class NetworkServiceTests
	{
		[Fact]
		public void NetworkService_SendPing_ReturnsString()
		{
			//Arrange
			var pingService = new NetworkService();

			//Act
			var result = pingService.SendPing();

			//Assert
			result.Should().NotBeNullOrWhiteSpace();
			result.Should().Be("Success: Ping Sent!");
			result.Should().Contain("Success", Exactly.Once());
		}

		[Theory]
		[InlineData(1, 1, 2)]
		[InlineData(2, 2, 4)]
		public void NetworkService_PingTimeout_ReturnsInt(int a, int b, int expected)
		{
			//Arrange
			var pingService = new NetworkService();

			//Act
			var result = pingService.PingTimeout(a,b);

			//Assert
			result.Should().Be(expected);
			result.Should().BeGreaterThanOrEqualTo(2);
			result.Should().NotBeInRange(-10000, 0);
		}
	}
}
