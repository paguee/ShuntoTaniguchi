using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ObstacleController : MonoBehaviour
{
    private Rigidbody rigidbody;
    public float speed = 0.1f;

    private Vector3 pos;
    private bool isStop = false;
 
    void Start()
    {
        pos = transform.position;
    }
 
    void Update()
    {
        if (!isStop)
        {
            pos.x += Time.deltaTime * speed; // speedは移動速度
            transform.position = pos;
 
            if (pos.x > 15) // 終点（自由に変更可能）
            {
                isStop = true;
            }
        }
        else
        {
            pos.x -= Time.deltaTime * speed;
            transform.position = pos;
 
            if (pos.x < 0) // 始点（自由に変更可能）
            {
                isStop = false;
            }
        }
    }
}
    void Start()
    {
        this.rigidbody = GetComponent<Rigidbody>();
        this.counter = GameObject.Find("GameDirector").GetComponent<Counter>(); //GameDirectorという名前のオブジェクトを探して、その中のCounterを取得
        Debug.Log("Start");
    }

 

