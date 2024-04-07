using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningSpawner : MonoBehaviour
{
    public GameObject lightningPrefab; // �C���X�y�N�^�[����ݒ肷�闋�v���t�@�u
    public float spawnHeight = 10f; // �������鍂��

    void Update()
    {
        // �v���C���[���E�N���b�N�����������o
        if (Input.GetMouseButtonDown(1)) // 1�͉E�N���b�N
        {
            // �}�E�X�|�C���^�̈ʒu���Q�[�����̃��[���h���W�ɕϊ�
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // Z���W�𒲐��i�J�����Ɠ����[���ɂȂ�Ȃ��悤�Ɂj
            worldPosition.z = 0;
            // ���v���t�@�u�𐶐��i����ɃI�t�Z�b�g��������j
            Instantiate(lightningPrefab, new Vector3(worldPosition.x, spawnHeight, worldPosition.z), Quaternion.identity);
        }
    }
}

