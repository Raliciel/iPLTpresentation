using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewScreen : MonoBehaviour
{
    //load Screen by Index
    public int SceneBuildIndexToLoad = 0;
    public void LoadScreen()
    {
        SceneManager.LoadSceneAsync(SceneBuildIndexToLoad);
    }

}
