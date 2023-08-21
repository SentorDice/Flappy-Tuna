using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{
    public int playerScore = 0;
    public Text textbox;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddScore(int scoreToAdd = 1)
    {
        playerScore = playerScore + scoreToAdd;
        textbox.text = "" + playerScore;
    }
}
