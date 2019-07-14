using System;

namespace example.Core
{
    public interface MComposable {
        protected ValueType GetField<ValueType>() {
            return ComposableObjectData.GetField<ValueType>(this);
        }

        protected void SetField<ValueType>(ValueType value) {
            ComposableObjectData.SetField(this, value);
        }
    }
}
