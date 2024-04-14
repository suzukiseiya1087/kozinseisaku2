using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMagic : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Vine"))
        {
            // �c�^�̔j��
            Destroy(other.gameObject);

            // ��̏���T���A����������
            GameObject upperFloor = GameObject.FindGameObjectWithTag("UpperFloor");
            if (upperFloor != null)
            {
                Rigidbody2D rb = upperFloor.GetComponent<Rigidbody2D>();
                if (rb != null)
                {
                    rb.isKinematic = false;  // �����v�Z��L���ɂ��ė���������
                }
            }
        }
    }
}