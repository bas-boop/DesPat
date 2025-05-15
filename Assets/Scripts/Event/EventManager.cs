using System;
using System.Collections.Generic;

namespace Event
{
    public static class EventManager
    {
        private static readonly Dictionary<EventType, Action> EvenDict = new();

        public static void AddListener(EventType type, Action func)
        {
            EvenDict.TryAdd(type, null); // checks of the type is already in the dict or not
            EvenDict[type] += func;
        }
        
        public static void RemoveListener(EventType type, Action func)
        {
            if (EvenDict.ContainsKey(type)
                && EvenDict[type] != null)
            {
                EvenDict[type] -= func;
            }
        }
        
        public static void InvokeEvent(EventType type)
        {
            EvenDict[type]?.Invoke();
        }
    }
}