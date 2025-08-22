using UnityEngine;
using UnityEngine.SceneManagement;
public class CrashDetector : MonoBehaviour
{
    [SerializeField] float delayBeforeReload = 0.2f;
    [SerializeField] ParticleSystem crashEffect;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            crashEffect.Play();
            Invoke("ReloadScene", delayBeforeReload);
        }
    }
    
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
