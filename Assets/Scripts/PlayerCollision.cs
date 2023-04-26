using UnityEngine;
public class PlayerCollision : MonoBehaviour
{  public PlayerMovement1 movement;
	public bool isjumped = true;
   void OnCollisionEnter(Collision collisionInfo)
   {// OnCollisionEnter must be put to react to collision

	   if(collisionInfo.gameObject.tag == "Obstacle")
	   {
		   movement.enabled =false;
			// or GetComponent <PlayerMovement1>().enabled= false;
			FindObjectOfType<GameManager>().EndGame();
	   }
   }
}
