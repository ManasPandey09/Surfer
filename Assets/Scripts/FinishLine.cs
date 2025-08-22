using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float delayBeforeReload = 1f;
    [SerializeField] ParticleSystem finishEffect;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {   
            finishEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", delayBeforeReload);
        }
    }
    
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
