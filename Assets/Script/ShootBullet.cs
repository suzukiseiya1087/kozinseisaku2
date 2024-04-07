using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    public GameObject bulletPrefab; // �e�̃v���n�u
    public Transform bulletSpawnPoint; // �e�𐶐�����ʒu
    public PlayerStatus playerStatus; // �v���C���[�̃X�e�[�^�X

    public float bulletSpeed = 10f; // �e�̑���

    void Update()
    {
        ShootWithRightClick();
    }

    void ShootWithRightClick()
    {
        // �v���C���[���E�N���b�N�����������o
        if (Input.GetMouseButtonDown(0)) // 1�͉E�N���b�N
        {
            // MP������Ă���Ζ��@�𔭓�
            if (playerStatus.ConsumeMP(10)) // 10MP����
            {
                Shoot();
            }
            else
            {
                Debug.Log("Not enough MP.");
            }
        }
    }

    void Shoot()
    {
        // �e�𐶐�����bulletPrefab�ɐݒ�
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);

        // �e���E�����ɔ�΂��i�܂���bulletSpawnPoint�̌����Ɂj
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = bulletSpawnPoint.right * bulletSpeed;
        }

        // �e����ʊO�ɂ������玩���I�ɔj������@�\�͍폜���A�ʂ̕��@�Ŏ���������
    }
}





