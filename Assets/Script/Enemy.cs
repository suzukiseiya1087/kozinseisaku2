using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Bullet")) // �e�ۂ̃^�O���m�F
    //    {

    //        Destroy(gameObject); // �G�I�u�W�F�N�g������
    //    }
    //}
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet")) // �e�ۂ̃^�O���m�F
        {

            Destroy(gameObject); // �G�I�u�W�F�N�g������
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // �n�ʂɐڐG�����Ƃ��̏���
        if (collision.gameObject.tag == "Lightning")
        {
            Destroy(gameObject); // �G�l�~�[�I�u�W�F�N�g��j�󂷂�
        }
    }
}
