using DiscordRPC;
using DiscordRPC.Logging;
using System;
using System.Diagnostics;

namespace DiscordRPCGenerator
{
    class Utils
    {
        public static void SetEvents(DiscordRpcClient client)
        {
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };

            client.OnReady += (sender, e) =>
            {
                Console.WriteLine("Received Ready from user {0}", e.User.Username);
            };

            client.OnConnectionFailed += (sender, e) =>
            {
                Console.WriteLine("Connection failed #{0}", e.FailedPipe);
            };

            client.OnPresenceUpdate += (sender, e) =>
            {
                Console.WriteLine("Received Update! {0}", e.Presence);
            };

            Process.GetCurrentProcess().Exited += (sender, e) =>
            {
                client.Dispose();
            };
        }

        public static Assets GetAssets(Settings settings)
        {
            return new Assets()
            {
                LargeImageKey = settings.SettingsOptional.Assets_LargeImageKey,
                LargeImageText = settings.SettingsOptional.Assets_LargeImageText,
                SmallImageKey = settings.SettingsOptional.Assets_SmallImageKey,
                SmallImageText = settings.SettingsOptional.Assets_SmallImageText
            };
        }

        public static Party GetParty(Settings settings)
        {
            return new Party()
            {
                ID = settings.SettingsOptional.Party_Id,
                Size = settings.Party_Size_CurrentSize,
                Max = settings.Party_Size_MaxSize
            };
        }
    }
}
