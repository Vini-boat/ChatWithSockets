using System.Reflection;
using System.Windows.Forms;
using Xunit;
using Client;

namespace Client.Tests
{
    public class ChatFormTests
    {
        private static TextBox GetMessageTextBox(Client.ChatForm form)
        {
            var field = typeof(ChatForm).GetField("messageTextBox", BindingFlags.NonPublic | BindingFlags.Instance);
            return (TextBox)field.GetValue(form);
        }

        [StaFact]
        public void ChatForm_TextBox_ShouldEraseProtocolDelimiter()
        {
            var _networkClient = new NetworkClient();
            using var form = new Client.ChatForm(_networkClient, "Teste");
            var textBox = GetMessageTextBox(form);

            textBox.Text = "abc;df";

            Assert.DoesNotContain(";", textBox.Text);
        }
    }
}