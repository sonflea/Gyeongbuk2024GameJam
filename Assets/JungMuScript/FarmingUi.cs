using TMPro;
using UnityEngine;

public class FarmingUi : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TMP_Text timeTMP;

    private void Awake()
    {
        //text= GetComponent<TMP_Text>();
    }

    private void Update()
    {
        ChangeTimeText(GameManger.Instance.FarmingTime.ToString());
    }

    private void ChangeTimeText(string time)
    {
        //string.Format("{0}", GameManger.Instance.FarmingTime);
        //Debug.Log(GameManger.Instance.FarmingTime.ToString());
        timeTMP.text = time;

    }

}
