using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class buttons : MonoBehaviour
{
    public static int levelNo;
    void Start()
    {
        levelNo = PlayerPrefs.GetInt("LevelNo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Reset(int mission)
    {
        SceneManager.LoadScene(mission);
    }

    public void Home()
    {
        SceneManager.LoadScene(0);
    }
    public void MissionMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void MissionPassContinue()
    {
        levelNo += 1;
        PlayerPrefs.SetInt("LevelNo", levelNo);
        SceneManager.LoadScene(1);

    }
    public void MissionSelect(int sceneNo)
    {
        SceneManager.LoadScene(sceneNo);
    }
    public void Quit()
    {
        {
#if UNITY_STANDALONE
            Application.Quit();
#endif
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
        }
    }
}
