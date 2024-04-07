using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LightningSpell : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 地面に接触したときの処理
        if (collision.gameObject.tag == "Ground")
        {
            Destroy(gameObject); // 雷オブジェクトを破壊する
        }
    }
}