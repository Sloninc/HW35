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
            var keyhash = key%_string.Length;
            if (_string[keyhash] == null)
                _string[keyhash] = value;
            else
            {
                bool isWrite = false;
                keyhash = 0;
                while (keyhash < _string.Length)
                {
                    if(_string[keyhash] == null)
                    {
                        _string[keyhash] = value;
                        isWrite = true;
                        break;
                    }
                    keyhash++;
                }
                if (!isWrite)
                {
                    Ext();
                    Add(keyhash, value);
                }
            }
        }
        private void Ext()
        {
            var temp = _string;
            _string = new string[2 * temp.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                _string[i % _string.Length] = temp[i];
            }
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
