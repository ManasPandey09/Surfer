using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Invoke("ReloadScene", 1f);
        }
    }
    
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
