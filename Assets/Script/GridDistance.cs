using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridDistance : MonoBehaviour
{
    private void Start()
    {
        // Grid�̐e�I�u�W�F�N�g��RectTransform���擾
        RectTransform parentRect = GetComponentInParent<RectTransform>();

        // Grid�̍��[����E�[�܂ł̋����i���j���擾
        float gridWidth = parentRect.rect.width;

        Debug.Log("Grid�̕�: " + gridWidth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
