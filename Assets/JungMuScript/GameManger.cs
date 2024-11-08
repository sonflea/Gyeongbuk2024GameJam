using System.Collections;
using System.Threading.Tasks;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public static GameManger Instance;

    public int FarmingTime = 5;
    public bool timeOver = false;   

    private void Awake()
    {
        if(Instance== null)
        {
            Instance = this;
        }

    }
    IEnumerator FarmingTimer()
    {
        float now= 0;

        timeOver = false;
        while (FarmingTime>0)
        {
            now += Time.deltaTime;
            if (now >= 1)
            {
                FarmingTime--;
                now = 0;
            }
            yield return null;

        }

        timeOver = true;

    }

    void StartTimer()
    {
        StartCoroutine(FarmingTimer () );
    }
    private void Start()//�ǵ� ���� ���� �ɶ� ���� ���� �����ϰ� timeover���� false�� �����ϰ� true�� �ٲ�� �ɰ��� 
    {
        StartTimer();
    }
    public void ChangeScene()
    {
        
        if (timeOver)//�ð��� �� �Ǿ�����
        {
            //���� �κп� �� ���� �ڵ� �����
        }
    }

}
