using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LightningSpell : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // �n�ʂɐڐG�����Ƃ��̏���
        if (collision.gameObject.tag == "Ground")
        {
            Destroy(gameObject); // ���I�u�W�F�N�g��j�󂷂�
        }
    }
}