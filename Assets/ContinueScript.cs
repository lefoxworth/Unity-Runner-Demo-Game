using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueScript : MonoBehaviour {

	public void Continue()
    {
        Destroy(GameOverController.score);
        SceneManager.LoadScene("Scene1");
    }

    public void Quit()
    {
        Application.Quit();
        
    }
}
