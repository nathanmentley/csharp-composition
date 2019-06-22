using System;
using System.Collections.Generic;

namespace example.Core
{
    public interface IComposable {
        Dictionary<String, object> _compositionData { get; }
    }
}
