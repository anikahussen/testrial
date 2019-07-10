using UnityEngine;

public class BottleCollide : MonoBehaviour
{



    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "player")
        {
            //Add to points 
            other.GetComponent<bottlePoints>().points++;


            //destroy 
            Destroy(gameObject);

        }
    }

}