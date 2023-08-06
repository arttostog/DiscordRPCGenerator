using Newtonsoft.Json;
using System.IO;

namespace DiscordRPCGenerator
{
    public class SaveAndLoad<T> where T : new()
    {
        private string PathToSave;

        public SaveAndLoad(string PathToSave)
        {
            this.PathToSave = PathToSave;
        }

        public T Save(T Object)
        {
            using (StreamWriter StreamWriter = File.CreateText(PathToSave)) StreamWriter.WriteLine(JsonConvert.SerializeObject(Object));
            return Object;
        }

        public T Load()
        {
            try
            {
                using (TextReader TextReader = new StreamReader(new FileStream(PathToSave, FileMode.Open)))
                {
                    return JsonConvert.DeserializeObject<T>(TextReader.ReadLine());
                }
            }
            catch
            {
                return Save(new T());
            }
        }
    }
}
