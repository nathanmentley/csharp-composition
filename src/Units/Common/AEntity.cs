using System;
using System.Collections.Generic;

using example.Core;

namespace example.Units.Common
{
    abstract class AEntity: IComposable
    {
        //IComposable
        //  Super ugly. But we basically have a bag of data that composing code can use to store data.
        //   Since C# doesn't have a good model to do mixins with properties / fields we're doing this.
        //   In theory other code can access data setup and owned by composing code, but by convention
        //   that should be avoided since there isn't a good code enforced way to handle that.
        public Dictionary<String, object> _compositionData { get; private set; }

        protected AEntity() {
            _compositionData = new Dictionary<String, object>();
        }
    }
}

