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
        // �n�ʂɐڐG�����Ƃ��̏���
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(gameObject); // �G�l�~�[�I�u�W�F�N�g��j�󂷂�
        }
    }
}
