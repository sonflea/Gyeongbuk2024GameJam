using System.Collections.Generic;
using UnityEngine;

namespace CustomScriptableObject
{
    [CreateAssetMenu(fileName = "ItemList", menuName = "Scriptable Objects/Items/ItemList")]
    public class ItemList : ScriptableObject
    {
        public List<Item> items;
    }
}