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
    //“–‚½‚è”»’è‚ðŽæ“¾
    void OnTriggerEnter2D(Collider2D t)
    {
        if (t.CompareTag("Player"))
        {
            Debug.Log("—Ž‚¿‚½‚Å");
            SceneManager.LoadScene("TitleScene");
        }
    }
}

