using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicController : MonoBehaviour
{
    public float range = 5f;
    public float liftForce = 10f;
    public string floatableTag = "Floatable"; // �����������u���b�N�̃^�O

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // ���@���g���L�[
        {
            LiftNearbyBlocks();
        }
    }

    void LiftNearbyBlocks()
    {
        Collider2D[] blocks = Physics2D.OverlapCircleAll(transform.position, range);
        foreach (Collider2D block in blocks)
        {
            if (block.CompareTag(floatableTag)) // �^�O�Ńt�B���^�����O
            {
                Rigidbody2D rb = block.GetComponent<Rigidbody2D>();
                if (rb != null)
                {
                    rb.AddForce(Vector2.up * liftForce, ForceMode2D.Impulse);
                }
            }
        }
    }
}


