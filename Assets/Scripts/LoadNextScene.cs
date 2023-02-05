using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour
{

    // Start is called before the first frame update
    void Start () {
        Invoke("LoadLevelAfterDelay", 23f);
    }

    void LoadLevelAfterDelay(){
        SceneManager.LoadScene(2);
    }
}
