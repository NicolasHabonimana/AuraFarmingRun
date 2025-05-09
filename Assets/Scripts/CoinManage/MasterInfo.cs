using UnityEngine;

public class MasterInfo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public static int coinCount = 0;
    [SerializeField] GameObject coinDisplay;
    void Update()
    {
        coinDisplay.GetComponent<TMPro.TMP_Text>().text = "AURA : " + coinCount;
    }
}
