
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
     void OnTriggerEnter()
    {
        gameManager.Completelevel();
        // for classes we can do search by using( FindObjectOfType<GameManager>().Completelevel();)
        // or create a reference
    }
}
