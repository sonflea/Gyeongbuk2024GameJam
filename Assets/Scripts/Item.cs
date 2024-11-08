using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public CustomScriptableObject.Item item { get; private set; }
    public bool isGot
    {
        get => unknown.activeSelf;
        set => unknown.SetActive(!value);
    }
    private int _count;
    public int count
    {
        get => _count;
        set
        {
            _count = value;
            if (_count > 0)
            {
                isGot = true;
                disable.SetActive(false);
            }
            else disable.SetActive(true);
        }
    }

    public Image itemImg;
    public GameObject unknown;
    public GameObject disable;

    public void ItemSet(CustomScriptableObject.Item item)
    {
        this.item = item;
        if(item.sprite != null) itemImg.sprite = item.sprite;
    }

    void Start()
    {
        itemImg = GetComponent<Image>();
    }


    public void CountUp() => count++;
}
