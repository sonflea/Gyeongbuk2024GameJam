using UnityEngine;

namespace CustomScriptableObject
{
    [CreateAssetMenu(fileName = "Item", menuName = "Scriptable Objects/Items/Item")]
    public class Item : ScriptableObject
    {
        public Sprite sprite;
        public string itemName;
    }
}
