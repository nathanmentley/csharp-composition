using System;

namespace example.Core
{
    public static class ObjectExtensions {
        public static CompType As<CompType>(this CompType that) => that;
    }
}
