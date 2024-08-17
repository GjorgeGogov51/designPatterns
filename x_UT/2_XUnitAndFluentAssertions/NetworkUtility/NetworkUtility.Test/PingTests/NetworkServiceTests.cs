using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using FluentAssertions.Extensions;
using NetworkUtility.Ping;

namespace NetworkUtility.Test.PingTests
{
	public class NetworkServiceTests
	{
		private readonly NetworkService _pingService;
        public NetworkServiceTests()
        {
			//System under test - SUT
			_pingService = new NetworkService();
        }

        [Fact]
		public void NetworkService_SendPing_ReturnsString()
		{
			//Arrange

			//Act
			var result = _pingService.SendPing();

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

			//Act
			var result = _pingService.PingTimeout(a,b);

			//Assert
			result.Should().Be(expected);
			result.Should().BeGreaterThanOrEqualTo(2);
			result.Should().NotBeInRange(-10000, 0);
		}
		[Fact]
		public void NetworkService_LastPingDate_ReturnsDateTime()
		{
			//Arrange

			//Act
			var result = _pingService.LastPingDate();

			//Assert
			result.Should().BeAfter(1.January(2010));
			result.Should().BeBefore(1.January(2030));
		}
		[Fact]
		public void NetworkService_GetPingOptions_ReturnsPingOptions()
		{
			//Arrange
			var expected = new PingOptions()
			{
				DontFragment = true,
				Ttl = 1
			}; // Object can also be mocked

			//Act
			var result = _pingService.GetPingOptions();

			//Assert - Use BeEquivalentTo for objects
			result.Should().BeOfType<PingOptions>();
			result.Should().BeEquivalentTo(expected);
			result.Ttl.Should().Be(1);
			//Can also reach in an object for specific fields
		}
	}
}
