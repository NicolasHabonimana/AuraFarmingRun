using System.Collections;
using System.Data;
using UnityEngine;

public class SegementGenerator : MonoBehaviour
{
    public GameObject[] segment;
    [SerializeField] int zPos = 25;
    [SerializeField] bool creatingSegment = false;
    [SerializeField] int segmentNum;


    void Update()
    {
        if(creatingSegment == false)
        {
            creatingSegment = true;
            StartCoroutine(SegmentGen());
        }
        
    }

    IEnumerator SegmentGen()
    {
        segmentNum = Random.Range(0, 3);
        Instantiate(segment[segmentNum], new Vector3(0, 0, zPos), Quaternion.identity);
        zPos += 25;
        yield return new WaitForSeconds(2);
        creatingSegment = false;
    }

}
