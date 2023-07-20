using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private bool isDragging = false;

    private void OnMouseDown()
    {
        isDragging = true;
    }

    private void OnMouseUp()
    {
        isDragging = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isDragging)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }
    }
}
