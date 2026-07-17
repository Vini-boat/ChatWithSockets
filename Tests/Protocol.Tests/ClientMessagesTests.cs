using Xunit;
using Protocol;

namespace Protocol.Tests
{
    public class ClientMessagesTests
    {
        [Theory]
        [InlineData("")]
        [InlineData("   ")]
        [InlineData("LINE;WITH;DELIMITER")]
        [InlineData("user_login")]
        [InlineData("INVALID_COMMAND")]
        public void ParseCommand_Com_EntradaInvalida_LancaExecao(string input)
        {
            Assert.Throws<ArgumentException>(() => Protocol.Messages.Client.ParseCommand(input));
        }


        public static IEnumerable<object[]> AllClientCommands()
        {
            foreach (var command in Enum.GetValues<Protocol.Messages.Client.Commands>())
                yield return new object[] { command };
        }


        [Theory]
        [MemberData(nameof(AllClientCommands))]
        public void ParseCommand_Com_ComandoValido_RetornaComando(Protocol.Messages.Client.Commands command)
        {
            var result = Protocol.Messages.Client.ParseCommand(command.ToString());
            Assert.Equal(command, result);

        }
    }
}
