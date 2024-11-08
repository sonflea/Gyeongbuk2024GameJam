using UnityEngine;

namespace CustomScriptableObject
{
    [CreateAssetMenu(fileName = "Combination", menuName = "Scriptable Objects/Items/Combination")]
    public class Combination : ScriptableObject
    {
        public Item inputItem1;
        public Item inputItem2;
        public Item outputItem;
    }
}