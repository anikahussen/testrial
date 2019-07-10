using UnityEngine;

public class RoseCollide : MonoBehaviour
{



    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "player")
        {
            //Add to points 
            other.GetComponent<rosePoints>().points++;


            //destroy 
            Destroy(gameObject);

        }
    }

}