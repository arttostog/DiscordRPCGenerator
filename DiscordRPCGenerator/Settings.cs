using DiscordRPC;

namespace DiscordRPCGenerator
{
    public class Settings
    {
        public int UpdateDelayInSeconds;

        public string ClientId;
        public string State;
        public string Details;

        public int Party_Size_CurrentSize;
        public int Party_Size_MaxSize;

        public SettingsOptional SettingsOptional;

        public Settings()
        {
            this.UpdateDelayInSeconds = 1;

            this.ClientId = "";
            this.State = "";
            this.Details = "";

            this.Party_Size_CurrentSize = 0;
            this.Party_Size_MaxSize = 0;

            this.SettingsOptional = new SettingsOptional();
        }
    }
}
