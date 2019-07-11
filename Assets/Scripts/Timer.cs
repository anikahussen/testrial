using UnityEngine;




public class Timer : MonoBehaviour
{
    float timer = 60.0f;
    public GUIStyle style;



    




    private void OnGUI()
    {
        if (timer > 0)
        {
            
            timer -= Time.deltaTime;
            int seconds = (int)(timer % 60);

            GUI.Label(new Rect(Screen.width - Screen.width / 10, Screen.height / 11, 100, 20), ": " + seconds, style);
            style.fontSize = 50;
            style.normal.textColor = Color.white;
        }
        GameObject GM = GameObject.Find("GameManager");

        GameObject thePlayer = GameObject.Find("player");
        int appleTtl = thePlayer.GetComponent<applePoints>().total;
        int coinTtl = thePlayer.GetComponent<coinPoints>().total;
        int roseTtl = thePlayer.GetComponent<rosePoints>().total;
        int bottleTtl = thePlayer.GetComponent<bottlePoints>().total;

        int applePts = thePlayer.GetComponent<applePoints>().points;
        int coinPts = thePlayer.GetComponent<coinPoints>().points;
        int rosePts = thePlayer.GetComponent<rosePoints>().points;
        int bottlePts = thePlayer.GetComponent<bottlePoints>().points;

        if ((timer < 0) && ((applePts != appleTtl) || (coinPts != coinTtl) || (rosePts != roseTtl) || (bottlePts != bottleTtl)))
        {
            
            GM.GetComponent<GameManager>().EndGame();

            thePlayer.GetComponent < PlayerMovement>().enabled = false;

            timer = 0.0f;
        }

        if ((timer > 0) && ((applePts == appleTtl) && (coinPts == coinTtl) && (rosePts == roseTtl) && (bottlePts == bottleTtl)))
        {
            thePlayer.GetComponent<PlayerMovement>().enabled = false;
            GM.GetComponent<WinScreen>().useGui = true ;
        }




    }





}
