using Unity.VisualScripting;
using UnityEngine;

public class PlayerSingleton : MonoBehaviour
{
    [SerializeField] public GameObject animator;
    [SerializeField] public AudioSource collisionFX;
    [SerializeField] public GameObject fadeOut;

    private static PlayerSingleton _instance;
    public static PlayerSingleton Instance 
    { 
        get { return _instance; } 
    } 

    private void Awake() 
    { 
        if (_instance != null && _instance != this) 
        { 
            Destroy(this.gameObject);
            return;
        }

        _instance = this;
        DontDestroyOnLoad(this.gameObject);
    } 

}
