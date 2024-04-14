using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMagic : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Vine"))
        {
            // ツタの破壊
            Destroy(other.gameObject);

            // 上の床を探し、落下させる
            GameObject upperFloor = GameObject.FindGameObjectWithTag("UpperFloor");
            if (upperFloor != null)
            {
                Rigidbody2D rb = upperFloor.GetComponent<Rigidbody2D>();
                if (rb != null)
                {
                    rb.isKinematic = false;  // 物理計算を有効にして落下させる
                }
            }
        }
    }
}