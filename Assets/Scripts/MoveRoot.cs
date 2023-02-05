using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRoot : MonoBehaviour
{

    private bool isMouseDragging;

    public void OnMouseDown() {
            isMouseDragging = true;
    }

    public void OnMouseUp() {
            isMouseDragging = false;
    }

    void Update() {

        // roots respond to user click and drag
        if (isMouseDragging) {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = Camera.main.transform.position.z + Camera.main.nearClipPlane;
            transform.position = mousePosition;

        }
        
    }
}
