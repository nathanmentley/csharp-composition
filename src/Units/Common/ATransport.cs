using System;

namespace example.Units.Common
{
    abstract class ATransport: AEntity
    {
        protected String name { get; private set; }

        protected ATransport(String _name): base() {
            name = _name;
        }

        public virtual String GetName() {
            return name;
        }
    }
}
