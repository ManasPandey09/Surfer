using UnityEngine;
using UnityEngine.SceneManagement;
public class CrashDetector : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            Invoke("ReloadScene", 0.2f);
        }
    }
    
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
