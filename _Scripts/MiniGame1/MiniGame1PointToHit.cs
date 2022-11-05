using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGame1PointToHit : MonoBehaviour
{
    [SerializeField] float changeSpeed = 0.05f;
    [SerializeField] float minChangeTime = 0.5f;
    [SerializeField] float maxChangeTime = 2f;
    Vector3 newTargetPosition;
    void Start()
    {
        newTargetPosition = transform.position;
        StartCoroutine(RandomizePosition());
    }

    
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, newTargetPosition, changeSpeed * Time.deltaTime);
    }
    IEnumerator RandomizePosition(){
        while(true){
            //mew Y position
            newTargetPosition = new Vector3(transform.position.x, Random.Range(transform.parent.transform.position.y-4.3f, transform.parent.transform.position.y+4.3f), 0);
            //random time
            yield return new WaitForSeconds(Random.Range(minChangeTime, maxChangeTime));
        }
    }
}
