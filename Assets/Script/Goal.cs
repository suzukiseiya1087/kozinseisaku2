using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // ゴールに接触したときの処理
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("TitleScene");
        }
    }
}
