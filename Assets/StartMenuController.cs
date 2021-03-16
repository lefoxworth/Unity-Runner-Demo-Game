using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuController : MonoBehaviour {

    private void Start()
    {
        Screen.SetResolution(1280, 720, false);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Scene1");
    }
}
