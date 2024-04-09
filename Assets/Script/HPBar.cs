using UnityEngine;

public class HPBar : MonoBehaviour
{
    [SerializeField]
    Human human;
    RectTransform rect;

    void Start()
    {
        rect = GetComponent<RectTransform>();
    }

    void Update()
    {
        //rect.localScale = new Vector2(human.PerHP, 1f);
    }
}

