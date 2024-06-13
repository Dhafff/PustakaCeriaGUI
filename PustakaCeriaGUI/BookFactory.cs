using ManajemenBukuLibrary;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PustakaCeriaGUI
{
    public class BookFactory : IBookFactory
    {
        public List<Buku> LoadBooks(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("File not found", filePath);
            }

            var json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<Buku>>(json);
        }
    }
}
