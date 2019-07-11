using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class applePoints : MonoBehaviour
{
    public GUIStyle style;
    public int points = 0;
    public int total = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnGUI()
    {
        GUI.Label(new Rect(Screen.width /11, Screen.height / 15, 100, 20), points + " / "+ total, style);
        style.fontSize = 25;
        style.normal.textColor = Color.white;
    }
}