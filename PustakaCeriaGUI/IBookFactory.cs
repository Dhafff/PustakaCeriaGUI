using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManajemenBukuLibrary;

namespace PustakaCeriaGUI
{
    public interface IBookFactory
    {
        List<Buku> LoadBooks(string filePath);
    }
}
