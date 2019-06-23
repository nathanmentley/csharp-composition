using System;

namespace example.Core
{
    public interface IComposable {
        ValueType GetField<ValueType>(String key);
        void SetField<ValueType>(String key, ValueType value);
    }
}
