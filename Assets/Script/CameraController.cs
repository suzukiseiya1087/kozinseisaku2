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
        //vector.y = transform.position.y;
        // カメラの位置を移動
        transform.position = vector;
        //// オブジェクト・コンポーネント

       
    }
}
