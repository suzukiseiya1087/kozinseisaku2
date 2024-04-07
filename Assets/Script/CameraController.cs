using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // 忍者のゲームオブジェクトを保持
    public GameObject player;
    // 忍者とカメラの位置関係を保持
    private Vector3 offset;


    // Start is called before the first frame update
    void Start()
    {
        // ゲームスタート時での忍者とカメラの位置関係を記憶
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void LateUpdate()
    {
        // 忍者の現在位置から新しいカメラの位置を作成
        Vector3 vector = player.transform.position + offset;
        // 縦方向は固定
        vector.y = transform.position.y;
        // カメラの位置を移動
        transform.position = vector;
        //// オブジェクト・コンポーネント

        //// 各種変数
        //private Vector2 basePos; // 基点座標

        ///// <summary>
        ///// カメラの位置を動かす
        ///// </summary>
        ///// <param name="targetPos">座標</param>
        //public void SetPosition(Vector2 targetPos)
        //{
        //    basePos = targetPos;
        //}

        //// FixedUpdate
        ////private void FixedUpdate()
        //{
        //    // カメラ移動
        //    Vector3 pos = transform.localPosition;
        //    // アクターの現在位置より少し右上を映すようにX・Y座標を補正
        //    pos.x = basePos.x + 2.5f; // X座標
        //    pos.y = basePos.y + 1.5f; // Y座標
        //                              // Z座標は現在値(transform.localPosition)をそのまま使用

        //    // 計算後のカメラ座標を反映
        //    transform.localPosition = Vector3.Lerp(transform.localPosition, pos, 0.08f);
    }
}
