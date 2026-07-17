using Xunit;
using Protocol;

namespace Protocol.Tests
{
    public class ServerMessagesTests
    {
        [Theory]
        [InlineData("")]
        [InlineData("   ")]
        [InlineData("LINE;WITH;DELIMITER")]
        [InlineData("user_login")]
        [InlineData("INVALID_COMMAND")]
        public void ParseCommand_Com_EntradaInvalida_LancaExecao(string input)
        {
            Assert.Throws<ArgumentException>(() => Protocol.Messages.Server.ParseCommand(input));
        }
        public static IEnumerable<object[]> AllServerCommands()
        {
            foreach (var command in Enum.GetValues<Protocol.Messages.Server.Commands>())
                yield return new object[] { command };
        }


        [Theory]
        [MemberData(nameof(AllServerCommands))]
        public void ParseCommand_Com_ComandoValido_RetornaComando(Protocol.Messages.Server.Commands command)
        {
            var result = Protocol.Messages.Server.ParseCommand(command.ToString());
            Assert.Equal(command, result);

        }
    }
}
