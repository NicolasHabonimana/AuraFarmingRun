using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetect : MonoBehaviour
{
    [SerializeField] GameObject thePlayer;
    [SerializeField] GameObject playerAnim;
    [SerializeField] AudioSource collisionFX;
    [SerializeField] GameObject fadeOut;

    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(CollissionEnd());
    }
    public void Start()
    {
        if(thePlayer==null) {
            thePlayer = PlayerSingleton.Instance.gameObject;
        }
        playerAnim = PlayerSingleton.Instance.animator;
        collisionFX = PlayerSingleton.Instance.collisionFX;
        fadeOut = PlayerSingleton.Instance.fadeOut;
    }
    IEnumerator CollissionEnd()
    {
        collisionFX.Play();
        thePlayer.GetComponent<PlayerMove>().enabled = false;
        playerAnim.GetComponent<Animator>().Play("Stumble Backwards");
        yield return new WaitForSeconds(1);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene(0);
    }
}
