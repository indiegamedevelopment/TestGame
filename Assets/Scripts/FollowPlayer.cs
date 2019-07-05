using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;

    public Vector3 offset;  // "Vector3" is a datatype that stores 3 floats values like position in a 3-D graph (x,y,z)

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
