using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Application.Common
{
    public class KeyedServiceTracker
    {
        private readonly List<string> _keys = new();

        public void AddKey(string key)
        {
            if (!_keys.Contains(key))
                _keys.Add(key);
        }
        public IReadOnlyList<string> GetKeys() => _keys.AsReadOnly();
    }
}
