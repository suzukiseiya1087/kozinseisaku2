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
        //vector.y = transform.position.y;
        // �J�����̈ʒu���ړ�
        transform.position = vector;
        //// �I�u�W�F�N�g�E�R���|�[�l���g

       
    }
}
