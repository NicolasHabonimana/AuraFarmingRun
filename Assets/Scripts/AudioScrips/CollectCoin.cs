using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    [SerializeField] AudioSource coinFX;

    [SerializeField] AudioClip coinFXClip;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided with : " + other);
        coinFX.clip = coinFXClip;
        coinFX.Play();
        
        MasterInfo.coinCount += 1000;
        this.gameObject.SetActive(false);
    }

}

