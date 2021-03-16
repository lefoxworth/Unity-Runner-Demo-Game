using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDScript : MonoBehaviour {

    public PlayerScore score;
    Vector2 nativeSize = new Vector2(1024, 768);

    private void OnGUI()
    {
        GUIStyle style = new GUIStyle();
        style.fontSize = (int)(20.0f * ((float)Screen.width / (float)nativeSize.x));
        GUI.Label(new Rect(10, 10, 100, 30), "Score: " + (int)score.playerScore);
    }
}
