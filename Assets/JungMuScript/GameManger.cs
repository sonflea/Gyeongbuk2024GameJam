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
    private void Start()//의도 씬이 시작 될때 시작 측정 시작하고 timeover값을 false로 설정하고 true로 바뀌게 될것임 
    {
        StartTimer();
    }
    public void ChangeScene()
    {
        
        if (timeOver)//시간이 다 되었을때
        {
            //여기 부분에 씬 변경 코드 들어가면됨
        }
    }

}
