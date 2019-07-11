using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScreen : MonoBehaviour
{
    public bool useGui = false;
    public GUIStyle style;
    public GUIStyle style2;
    public bool clickCheck = false;

    public void OnGUI()
    {
        if (useGui)
        {
            GUI.Label(new Rect(Screen.width / 2 - Screen.width / 6, Screen.height / 2, 100, 20), "Level " + GetComponent<GameManager>().levelName + " Complete", style);
            style.fontSize = 50;
            style.normal.textColor = Color.white;

            style2.fontSize = 35;
            style2.normal.textColor = Color.white;
            int nextlevel = GetComponent<GameManager>().levelName + 1;

            if (GUI.Button(new Rect(Screen.width / 2 - Screen.width / 12, (Screen.height / 2) + (Screen.height / 6), 100, 70), "Go to Level " + nextlevel , style2))
            {
                clickCheck = true;
            }
            if (clickCheck)
            {
                Debug.Log("CLICKED");
                //LOAD NEXT SCENE
                clickCheck = false;
            }


        }


    }

}
