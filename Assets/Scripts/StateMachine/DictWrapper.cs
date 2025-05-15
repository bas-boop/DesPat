using System.Collections.Generic;

namespace StateMachine
{
    public sealed class DictWrapper
    {
        private readonly Dictionary<string, object> _data = new ();

        public T Get<T>(string key)
        {
            if (_data.TryGetValue(key, out object value))
                return (T)value;
            
            return default;
        }

        public void Set<T>(string key, T value) => _data[key] = value;
    }
}