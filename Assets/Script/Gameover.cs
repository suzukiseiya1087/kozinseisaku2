using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //当たり判定を取得
    void OnTriggerEnter2D(Collider2D t)
    {
        if (t.CompareTag("Player"))
        {
            Debug.Log("落ちたで");
            SceneManager.LoadScene("TitleScene");
        }
    }
}

