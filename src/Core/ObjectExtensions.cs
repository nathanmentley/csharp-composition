using System;

namespace example.Core
{
    public static class ObjectExtensions {
        public static CompType AsComp<CompType>(this object that) {
            if (that is CompType result) {
                return result;
            }

            return default(CompType);
        }
    }
}
