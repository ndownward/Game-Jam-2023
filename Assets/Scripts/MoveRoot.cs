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
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }

            // make sure roots are always touching

        // check if overlapping




        // no overlap? level complete!

        
    }
}
