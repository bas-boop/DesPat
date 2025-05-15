using System;
using System.Collections.Generic;

namespace Event
{
    public static class EventManager
    {
        private static readonly Dictionary<EventType, Action> _eventDict = new();

        public static void AddListener(EventType type, Action func)
        {
            _eventDict.TryAdd(type, null); // checks of the type is already in the dict or not
            _eventDict[type] += func;
        }
        
        public static void RemoveListener(EventType type, Action func)
        {
            if (_eventDict.ContainsKey(type)
                && _eventDict[type] != null)
            {
                _eventDict[type] -= func;
            }
        }
        
        public static void InvokeEvent(EventType type)
        {
            _eventDict[type]?.Invoke();
        }
    }
}