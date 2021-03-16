using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour {

    public float playerScore = 0;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        playerScore += Time.deltaTime;
    }

    public void ChangeScore(int amount)
    {
        playerScore += amount;
    }
}
