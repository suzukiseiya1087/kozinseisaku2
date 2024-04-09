using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridDistance : MonoBehaviour
{
    private void Start()
    {
        // Gridの親オブジェクトのRectTransformを取得
        RectTransform parentRect = GetComponentInParent<RectTransform>();

        // Gridの左端から右端までの距離（幅）を取得
        float gridWidth = parentRect.rect.width;

        Debug.Log("Gridの幅: " + gridWidth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
