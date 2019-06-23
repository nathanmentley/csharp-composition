using System;
using System.Collections.Generic;

namespace example.Core
{
    public class ExampleObject: IComposable
    {
        //IComposable
        //  Super ugly. But we basically have a bag of data that composing code can use to store data.
        //   Since C# doesn't have a good model to do mixins with properties / fields we're doing this.
        //   In theory other code can access data setup and owned by composing code, but by convention
        //   that should be avoided since there isn't a good code enforced way to handle that.
        private Dictionary<String, object> _compositionData { get; set; }

        protected ExampleObject() {
            _compositionData = new Dictionary<String, object>();
        }

        public ValueType GetField<ValueType>(String key) {
            if (_compositionData.ContainsKey(key)) {
                if(_compositionData[key] is ValueType ret) {
                    return ret;
                }
            }

            return default(ValueType);
        }

        public void SetField<ValueType>(String key, ValueType value) {
            _compositionData[key] = value;
        }
    }
}
