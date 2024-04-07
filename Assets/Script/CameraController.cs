using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // �E�҂̃Q�[���I�u�W�F�N�g��ێ�
    public GameObject player;
    // �E�҂ƃJ�����̈ʒu�֌W��ێ�
    private Vector3 offset;


    // Start is called before the first frame update
    void Start()
    {
        // �Q�[���X�^�[�g���ł̔E�҂ƃJ�����̈ʒu�֌W���L��
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void LateUpdate()
    {
        // �E�҂̌��݈ʒu����V�����J�����̈ʒu���쐬
        Vector3 vector = player.transform.position + offset;
        // �c�����͌Œ�
        vector.y = transform.position.y;
        // �J�����̈ʒu���ړ�
        transform.position = vector;
        //// �I�u�W�F�N�g�E�R���|�[�l���g

        //// �e��ϐ�
        //private Vector2 basePos; // ��_���W

        ///// <summary>
        ///// �J�����̈ʒu�𓮂���
        ///// </summary>
        ///// <param name="targetPos">���W</param>
        //public void SetPosition(Vector2 targetPos)
        //{
        //    basePos = targetPos;
        //}

        //// FixedUpdate
        ////private void FixedUpdate()
        //{
        //    // �J�����ړ�
        //    Vector3 pos = transform.localPosition;
        //    // �A�N�^�[�̌��݈ʒu��菭���E����f���悤��X�EY���W��␳
        //    pos.x = basePos.x + 2.5f; // X���W
        //    pos.y = basePos.y + 1.5f; // Y���W
        //                              // Z���W�͌��ݒl(transform.localPosition)�����̂܂܎g�p

        //    // �v�Z��̃J�������W�𔽉f
        //    transform.localPosition = Vector3.Lerp(transform.localPosition, pos, 0.08f);
    }
}
