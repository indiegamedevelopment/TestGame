using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 2000f;

    public float sidewaysForce = 500f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if ( Input.GetKey("d") )                                                            // In Unity we also have fourth dimension
        {                                                                                   // that is force (x,y,z,force)
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);    // without force mode (x,y,z) the player
        }                                                                                   // turns slowly due mass and velocity
                                                                                            // but with "ForceMode" we can control the
        if( Input.GetKey("a") )                                                             // force. "ForceMode.Force" is standard and
        {                                                                                   // shows no difference but with
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);   // "ForceMode.VelocityChange" the player
        }                                                                                   // immediately turns disregarding the mass
                                                                                            // and velocity of player
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }                                                                                       
}
