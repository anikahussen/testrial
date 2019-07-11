using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public int levelName = 1;
   
    public void EndGame()
    {
       
            Debug.Log("GAME OVER");
            GetComponent<GameOverScreen>().useGui = true;

            GameObject Player = GameObject.Find("player");
            Player.GetComponent<PlayerMovement>().enabled = false;


            

    }

    public void Reset()
    {
        SceneManager.LoadScene("Level01");
    }


}
