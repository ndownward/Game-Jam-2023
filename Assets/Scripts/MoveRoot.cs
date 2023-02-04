using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRoot : MonoBehaviour
{

    private bool isMouseDragging;

    // Start is called before the first frame update
    void onMouseDown() {
            isMouseDragging = true;
        }

        void onMouseUp() {
            isMouseDragging = false;
        }

        // Update is called once per frame
        void Update() {

        // roots respond to user click and drag
        if (isMouseDragging) {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

            // make sure roots are always touching

        // check if overlapping




        // no overlap? level complete!

        
    }
}
