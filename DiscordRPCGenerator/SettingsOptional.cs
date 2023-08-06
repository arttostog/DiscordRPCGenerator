using DiscordRPC;

namespace DiscordRPCGenerator
{
    public class SettingsOptional
    {
        public string State;
        public string Details;

        public string Assets_LargeImageKey;
        public string Assets_LargeImageText;
        public string Assets_SmallImageKey;
        public string Assets_SmallImageText;

        public string Party_Id;
        public int Party_Size_CurrentSize;
        public int Party_Size_MaxSize;

        public Button[] Buttons;

        public SettingsOptional()
        {
            this.State = "";
            this.Details = "";

            this.Assets_LargeImageKey = "";
            this.Assets_LargeImageText = "";
            this.Assets_SmallImageKey = "";
            this.Assets_SmallImageText = "";

            this.Party_Id = "";

            this.Party_Size_CurrentSize = 0;
            this.Party_Size_MaxSize = 0;

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
