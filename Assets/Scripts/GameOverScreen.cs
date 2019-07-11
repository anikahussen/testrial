using UnityEngine;

public class GameOverScreen : MonoBehaviour
{
    public GUIStyle style;
    public GUIStyle style2;
    public GUIStyle style3;
    public bool useGui  = false;
    public bool clickCheck = false;
    public void OnGUI()
    {
        if (useGui)
        {
            GUI.Label(new Rect(Screen.width / 2 - Screen.width / 6, Screen.height / 2, 100, 20), "GAME OVER", style);
            style.fontSize = 60;
            style.normal.textColor = Color.white;

            style2.fontSize = 45;
            style2.normal.textColor = Color.white;


            if (GUI.Button(new Rect(Screen.width / 2 - Screen.width / 12, (Screen.height / 2) + (Screen.height / 6), 100, 70), "Try Again", style2))
            {
                clickCheck = true;
            }
            if (clickCheck)
            {
                Debug.Log("CLICKED");
                GetComponent<GameManager>().Reset();
                clickCheck = false;
            }
        }

       }

    
}
