using DiscordRPC;

namespace DiscordRPCGenerator
{
    public class SettingsOptional
    {
        public string Assets_LargeImageKey;
        public string Assets_LargeImageText;
        public string Assets_SmallImageKey;
        public string Assets_SmallImageText;

        public string Party_Id;

        public Button[] Buttons;

        public SettingsOptional()
        {
            this.Assets_LargeImageKey = "";
            this.Assets_LargeImageText = "";
            this.Assets_SmallImageKey = "";
            this.Assets_SmallImageText = "";

            this.Party_Id = "";

            this.Buttons = new Button[]
            {
                new Button()
                {
                    Label = "Test",
                    Url = "https://www.google.com/"
                }
            };
        }
    }
}
