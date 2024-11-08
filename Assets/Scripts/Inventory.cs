using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    [SerializeField] private CustomScriptableObject.ItemList itemList;
    [SerializeField] private GameObject itemPrefab;
    [SerializeField] private GridLayoutGroup itemBase;
    private Item[] items;

    public int setItemSize = 100;
    private int finalSize = 100;

    void Awake()
    {
        finalSize = Screen.width / 1920 * setItemSize;
        itemBase.cellSize = Vector2.one * finalSize;
        itemBase.spacing = Vector2.one * finalSize * 0.1f;
    }

    void Start()
    {
        items = new Item[itemList.items.Count];
        for(int i = 0; i < itemList.items.Count; i++)
        {
            GameObject go = Instantiate(itemPrefab, itemBase.transform);
            Item it = go.GetComponent<Item>();
            it.ItemSet(itemList.items[i]);
            items[i] = it;
        }
    }
}
