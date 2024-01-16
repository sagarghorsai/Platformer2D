using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
  
    public void LoadLevel(int scene)
    {
        //ButtonClick();

        //if (SoundMangager.instance != null)
        //{
        //    SoundMangager.instance.musicSource.Stop();
        //    SoundMangager.instance.musicSource.clip =
        //        SoundMangager.instance.musicClips[0];
        //    SoundMangager.instance.musicSource.time = 13;
        //    SoundMangager.instance.musicSource.Play();
        //}

        SceneManager.LoadScene(scene);

    }

    public void ExitGame()
    {

#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#endif

#if UNITY_STANDALONE_WIN
        Application.Quit();
#endif
    }

}
