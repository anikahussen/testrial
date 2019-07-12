using UnityEngine;

public class Orbit : MonoBehaviour
{

    public GameObject obj1;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OrbitAround();
    }

    void OrbitAround()
    {
        transform.RotateAround(obj1.transform.position, Vector3.down, speed * Time.deltaTime);
    }

}
