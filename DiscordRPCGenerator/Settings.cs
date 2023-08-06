using DiscordRPC;

namespace DiscordRPCGenerator
{
    public class Settings
    {
        public int UpdateDelayInSeconds;

        public string ClientId;

        public SettingsOptional SettingsOptional;

        public Settings()
        {
            this.UpdateDelayInSeconds = 1;

            this.ClientId = "";
            
            this.SettingsOptional = new SettingsOptional();
        }
    }
}
