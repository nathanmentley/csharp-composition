using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace example.Core
{
    public class ComposableObject: IComposable
    {
        //IComposable
        //  Super ugly. But we basically have a bag of data that composing code can use to store data.
        //   Since C# doesn't have a good model to do mixins with properties / fields we're doing this.
        //  To segment access to the composing code. We're splitting that by by type and using a seperate
        //   dictinoary per type. We're pulling the type from the stackframe up 1 level.
        private Dictionary<Type, Dictionary<String, object>> _compositionData { get; set; }

        protected ComposableObject() {
            _compositionData = new Dictionary<Type, Dictionary<String, object>>();
        }

        public ValueType GetField<ValueType>(String key) {
            StackFrame frame = new StackFrame(1);
            var method = frame.GetMethod();
            var type = method.DeclaringType;

            if (!_compositionData.ContainsKey(type)) {
                _compositionData[type] = new Dictionary<String, object>();
            }

            if (_compositionData[type].ContainsKey(key)) {
                if(_compositionData[type][key] is ValueType ret) {
                    return ret;
                }
            }

            return default(ValueType);
        }

        public void SetField<ValueType>(String key, ValueType value) {
            StackFrame frame = new StackFrame(1);
            var method = frame.GetMethod();
            var type = method.DeclaringType;

            if (!_compositionData.ContainsKey(type)) {
                _compositionData[type] = new Dictionary<String, object>();
            }

            _compositionData[type][key] = value;
        }
    }
}
