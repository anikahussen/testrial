using UnityEngine;

public class AppleCollide : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "player")
        {
            //Add to points 
            other.GetComponent<applePoints>().points++;


            //destroy 
            Destroy(gameObject);

        }
    }

}
