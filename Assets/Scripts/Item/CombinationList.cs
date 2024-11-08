using System.Collections.Generic;
using UnityEngine;

namespace CustomScriptableObject
{
    [CreateAssetMenu(fileName = "CombinationList", menuName = "Scriptable Objects/Items/CombinationList")]
    public class CombinationList : ScriptableObject
    {
        public List<Combination> _combinations;

        public Dictionary<(Item, Item), Item> combinations;

        private void OnEnable()
        {
            combinations = new();
            foreach(var com in _combinations)
            {
                if(combinations.ContainsKey((com.inputItem1, com.inputItem2))) continue;
                combinations.Add((com.inputItem1, com.inputItem2), com.outputItem);
                combinations.Add((com.inputItem2, com.inputItem1), com.outputItem);
            }
        }
    }
}