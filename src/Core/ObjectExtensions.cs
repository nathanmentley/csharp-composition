using System;

namespace example.Core
{
    public static class ObjectExtensions {
        public static CompType AsComp<CompType>(this CompType that)
        {
            if (that is CompType result) {
                return result;
            }

            return default(CompType);
        }
    }
}
