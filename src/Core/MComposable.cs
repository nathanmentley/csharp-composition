using System;

namespace example.Core
{
    public interface MComposable {
        protected ValueType GetField<ValueType>(String key) {
            return ComposableObjectData.GetField<ValueType>(this, key);
        }

        protected void SetField<ValueType>(String key, ValueType value) {
            ComposableObjectData.SetField(this, key, value);
        }
    }
}
