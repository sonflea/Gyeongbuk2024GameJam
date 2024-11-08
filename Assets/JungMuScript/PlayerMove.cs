using System.Threading.Tasks;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Rigidbody2D rg2d;
    public float speed = 3f;
    private int move = 1;
    public void FixedUpdate()
    {
        float xMove = Input.GetAxis("Horizontal");
        float zMove = Input.GetAxis("Vertical");

        Vector3 getVal = new Vector3(xMove, zMove); 
        rg2d.linearVelocity = getVal*speed*move;

    }

    public void Awake()
    {
        rg2d=GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// 여기서 collision이 먹는 오브젝트 
    /// </summary>
    /// <param name="collision"></param>
    private async void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.transform.name);
        Destroy(collision.gameObject);
        move = 0;
        await Stay();
        move = 1;
    }


    private async Task Stay()
    {
        Debug.Log("대기 시작");
        //this.gameObject.transform.position = vec;
        await Awaitable.WaitForSecondsAsync(0.5f);
        Debug.Log("대기 완료");
    }
}
