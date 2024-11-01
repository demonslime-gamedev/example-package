using System;
using System.Collections.Generic;

namespace ExamplePackage {
    [Serializable]
    public class SerializableDictionary<TKey, TValue> : Dictionary<TKey, TValue> { }
}
