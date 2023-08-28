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

        //индексатор словаря
        public string this[int index]
        {
            get => Get(index);
            set=>Add(index, value);
        }
        public void Add(int key, string value)
        {
            var keyhash = Math.Abs(key)%_string.Length;
            if (_string[keyhash] == null)
                _string[keyhash] = value;
            else //если в словаре по данному индексу уже есть элемент
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
                if (!isWrite) //если словарь необходимо расширить
                {
                    Ext();
                    Add(key, value);
                }
            }
        }

        //метод для расширения словаря в два раза
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
            var keyhash = Math.Abs(key) % _string.Length;
            if (_string[keyhash] != null)
                return _string[keyhash];
            else
                return $"элемент с индексом {key} не найден в словаре";
        }
    }
}
