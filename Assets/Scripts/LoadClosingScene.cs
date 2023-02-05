using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadClosingScene : MonoBehaviour
{

    private bool isMouseClick;

    public void OnMouseDown() {
        Debug.Log("click!");
        isMouseClick = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isMouseClick) {
            SceneManager.LoadScene(3);
        }
        
    }
}