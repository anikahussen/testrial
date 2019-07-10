using UnityEngine;

public class CoinCollide : MonoBehaviour
{



    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "player")
        {
            //Add to points 
            other.GetComponent<coinPoints>().points++;

             
                //destroy 
                Destroy(gameObject);

        }
    }

}
