using UnityEngine;
using UnityEngine.UI;

public class bottlePoints : MonoBehaviour
{
    public GUIStyle style;
    public int points = 0;
    public int total = 1;
    // Start is called before the first frame update
    

    private void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 11, (Screen.height / 3) + (Screen.height / 4), 100, 20), points + " / "+ total, style);
        style.fontSize = 25;
        style.normal.textColor = Color.white;
    }
}
