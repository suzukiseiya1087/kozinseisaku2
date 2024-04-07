using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    public GameObject bulletPrefab; // 弾のプレハブ
    public Transform bulletSpawnPoint; // 弾を生成する位置
    public PlayerStatus playerStatus; // プレイヤーのステータス

    public float bulletSpeed = 10f; // 弾の速さ

    void Update()
    {
        ShootWithRightClick();
    }

    void ShootWithRightClick()
    {
        // プレイヤーが右クリックしたかを検出
        if (Input.GetMouseButtonDown(0)) // 1は右クリック
        {
            // MPが足りていれば魔法を発動
            if (playerStatus.ConsumeMP(10)) // 10MP消費
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
        // 弾を生成してbulletPrefabに設定
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);

        // 弾を右方向に飛ばす（またはbulletSpawnPointの向きに）
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = bulletSpawnPoint.right * bulletSpeed;
        }

        // 弾が画面外にいったら自動的に破棄する機能は削除し、別の方法で実装を検討
    }
}





