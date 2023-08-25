using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW35
{
    public class OtusDictionary
    {
        string[] _string = new string[32];
        public void Add(int key, string value)
        {
            if (_string[key] == null)
                _string[key] = value;
            else
                throw new Exception("элемент с таким ключом уже есть в словаре");
        }
        public string Get(int key)
        {
            if (_string[key] != null)
                return _string[key];
            else
                throw new Exception("элемент с таким ключом не найден в словаре");
        }
    }
}
