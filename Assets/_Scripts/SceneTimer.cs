using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTimer : MonoBehaviour
{
    public enum SceneType
    {
        Number,
        String
    }

    public float timeToWait = 3f;

    public SceneType sceneType;
    public int NextSceneInt;
    public string NextSceneString;

    void Start()
    {
        Invoke("NextScene", timeToWait);
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            NextScene();
        }
    }
    private void NextScene()
    {
        if (sceneType == SceneType.Number)
        {
            SceneManager.LoadScene(NextSceneInt);
        }
        else 
        {
            SceneManager.LoadScene(NextSceneString);
        }
    }
}
