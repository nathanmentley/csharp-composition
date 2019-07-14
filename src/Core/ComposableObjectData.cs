using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace example.Core
{
    internal static class ComposableObjectData {
        private static ConditionalWeakTable<object, Dictionary<Type, Dictionary<String, object>>> _compositionData { get; set; }

        static ComposableObjectData() {
            _compositionData = new ConditionalWeakTable<object, Dictionary<Type, Dictionary<String, object>>>();
        }

        static internal ValueType GetField<ValueType>(object obj, string key) {
            StackFrame frame = new StackFrame(2);
            var method = frame.GetMethod();
            var type = method.DeclaringType;

            Dictionary<Type, Dictionary<String, object>> compData;
            bool found = _compositionData.TryGetValue(obj, out compData);
            if (!found)
            {
                compData = new Dictionary<Type, Dictionary<String, object>>();
                _compositionData.Add(obj, compData);
            }

            if (!compData.ContainsKey(type))
            {
                compData[type] = new Dictionary<String, object>();
            }

            if (compData[type].ContainsKey(key) && compData[type][key] is ValueType ret)
            {
                return ret;
            }

            return default(ValueType);
        }

        static internal void SetField<ValueType>(object obj, string key, ValueType value) {
            StackFrame frame = new StackFrame(2);
            var method = frame.GetMethod();
            var type = method.DeclaringType;
            
            Dictionary<Type, Dictionary<String, object>> compData;
            bool found = _compositionData.TryGetValue(obj, out compData);
            if (!found)
            {
                compData = new Dictionary<Type, Dictionary<String, object>>();
                _compositionData.Add(obj, compData);
            }

            if (!compData.ContainsKey(type)) {
                compData[type] = new Dictionary<String, object>();
            }

            compData[type][key] = value;
        }
    }
}
