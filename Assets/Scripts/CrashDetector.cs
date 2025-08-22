using UnityEngine;
using UnityEngine.SceneManagement;
public class CrashDetector : MonoBehaviour
{
    [SerializeField] float delayBeforeReload = 0.4f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSound;

    bool crash = true;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground" && crash)
        {
            FindFirstObjectByType<PlayerController>().DisableControls();
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSound);
            Invoke("ReloadScene", delayBeforeReload);
            crash = false;
        }
    }
    
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
