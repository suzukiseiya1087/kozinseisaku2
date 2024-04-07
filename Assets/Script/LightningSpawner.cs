using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningSpawner : MonoBehaviour
{
    public GameObject lightningPrefab; // インスペクターから設定する雷プレファブ
    public float spawnHeight = 10f; // 生成する高さ

    void Update()
    {
        // プレイヤーが右クリックしたかを検出
        if (Input.GetMouseButtonDown(1)) // 1は右クリック
        {
            // マウスポインタの位置をゲーム内のワールド座標に変換
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // Z座標を調整（カメラと同じ深さにならないように）
            worldPosition.z = 0;
            // 雷プレファブを生成（上方にオフセットを加える）
            Instantiate(lightningPrefab, new Vector3(worldPosition.x, spawnHeight, worldPosition.z), Quaternion.identity);
        }
    }
}

