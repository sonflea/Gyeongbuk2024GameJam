using UnityEditor;
using UnityEditor.Rendering;
using UnityEngine;

public class ObjectSpner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int mapX = 1920;
    public int mapY = 1080;

    public int itemMaxSize = 40;
    public bool[][] itemSponSpot;

    /// <summary>
    /// 아이템 개수
    /// </summary>
    public int itemsCount = 5;

    public GameObject Player;

    public GameObject[] FramingObjList;
    void Start()
    {
        SetSponer();
        Sponer();
        CheckList();
        SetCharactor();
    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log(string.Format("{0} , {1}", itemSponSpot.Length, itemSponSpot[0].Length));
    }

    public void SetCharactor()
    {
        Player.transform.position = new Vector2((int)(itemsCount / 2) * itemMaxSize + itemMaxSize / 2, (int)(itemsCount / 2) * itemMaxSize + itemMaxSize / 2);
        itemSponSpot[itemsCount / 2][itemsCount / 2] = true;
        //Vector2 vec = new Vector2(x * itemMaxSize + itemMaxSize / 2, y * itemMaxSize + itemMaxSize / 2);
    }

    public void SetSponer()
    {
        int minValue;//맵의 x와 y중 작은 값
        if (mapX > mapY)
        {
            minValue = mapY;
        }
        else
        {
            minValue = mapX;
        }
        int div = minValue / itemMaxSize;
        Debug.Log(div);
        itemSponSpot = new bool[div][];
        for (int i = 0; i < div; i++)
        {
            itemSponSpot[i] = new bool[div];
        }


    }
    public void Sponer()//itemSponSpot의 배열안에 bool값을넣음
    {
        //여기서 부터 랜덤으로 적군 스폰


        for(int i=0;i< FramingObjList.Length; i++)
        {
            for(int j= 0;j< itemsCount; j++)
            {
                int x = Random.Range(0, itemSponSpot.Length);
                int y = Random.Range(0, itemSponSpot.Length);
                if (itemSponSpot[x][y] == false)
                {
                    itemSponSpot[x][y] = true;
                    Vector2 vec = new Vector2(x*itemMaxSize+itemMaxSize/2, y * itemMaxSize + itemMaxSize / 2);
                    Instantiate(FramingObjList[i].gameObject, vec, Quaternion.identity);
                    Debug.Log(string.Format("{0} , {1} 생성",x,y));
                }
                else
                {
                    j--;
                    Debug.Log("중복");
                    continue;
                }


            }
        }
    }

    public void CheckList()//배열 내용 확인용
    {
        for(int i=0;i< itemSponSpot.Length; i++)
        {
            //for(int j = 0; j < itemSponSpot.Length; j++)
            //{
            //    //string.join
            //}
            string result = string.Join(",", itemSponSpot[i]);
            Debug.Log(result);
        }
        Debug.Log("완료");
    }
}
