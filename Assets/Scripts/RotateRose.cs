using UnityEngine;

public class RotateRose : MonoBehaviour
{
    public int rotateSpeed;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotateSpeed, 0, Space.World);
    }
}
