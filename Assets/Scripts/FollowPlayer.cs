using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    //or can use (public Transform camera; )
    public Vector3 offset;
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position=player.position + offset;
        //(camera.position=player.position + offset);
        
    }
}
