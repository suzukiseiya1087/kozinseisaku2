using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ivy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 地面に接触したときの処理
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(gameObject); // エネミーオブジェクトを破壊する
        }
    }
}
