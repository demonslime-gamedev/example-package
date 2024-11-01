using UnityEditor;
using UnityEngine.UIElements;

namespace ExamplePackage {
    [CustomPropertyDrawer(typeof(SerializableDictionary<,>))]
    public class SerializableDictionaryDrawer : PropertyDrawer {
        public override VisualElement CreatePropertyGUI(SerializedProperty property) {
            return base.CreatePropertyGUI(property);
        }
    }
}
