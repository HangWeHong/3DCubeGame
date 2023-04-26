
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool gameend = false;
    public float TimeDelay = 1.6f;
    public GameObject levelcompleteUI;
    
    public void Completelevel()
    {
        levelcompleteUI.SetActive(true) ;
    }
    public void EndGame()
    {
        if (gameend == false)
        {
            gameend = true;
            Debug.Log("Game Over");
            Invoke("Restart", TimeDelay);
            
        }
       
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        // SceneManager.LoadScene("Level 1") <--not good
    }
}
