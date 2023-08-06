using DiscordRPC;
using System;
using System.Threading;

namespace DiscordRPCGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SaveAndLoad<Settings> SettingsSave = new SaveAndLoad<Settings>("Settings.json");

            Settings settings = SettingsSave.Load();

            if (settings.ClientId == "")
            {
                Console.WriteLine("Please, modify Settings.json!\n");
                Console.ReadLine();
                return;
            }

            DiscordRpcClient client = new DiscordRpcClient(settings.ClientId);

            Utils.SetEvents(client);

            client.Initialize();

            new Thread(() => UpdatePresence(client, settings, Utils.GetAssets(settings), Timestamps.Now, Utils.GetParty(settings))).Start();
        }

        private static void UpdatePresence(DiscordRpcClient client, Settings settings, Assets assets, Timestamps timestamps, Party party)
        {
            while (true)
            {
                client.SetPresence(new RichPresence()
                {
                    State = settings.SettingsOptional.State,
                    Details = settings.SettingsOptional.Details,

                    Assets = assets,

                    Timestamps = timestamps,

                    Party = party,

                    Buttons = settings.SettingsOptional.Buttons
                });
                Thread.Sleep(settings.UpdateDelayInSeconds * 1000);
            }
        }
    }
}
