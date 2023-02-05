using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewScene : MonoBehaviour
{

    public string nextScene = "Root Game";

    // Start is called before the first frame update
    void Start () {
        Invoke("LoadLevelAfterDelay", 20.25f);
    }

    void LoadLevelAfterDelay(){
        SceneManager.LoadScene(2);
    }
}
