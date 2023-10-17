using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectOnanOff : MonoBehaviour
{


    public void Wait(int duration) 
    {
        StartCoroutine(Object(duration));
    }
    
    public IEnumerator Object(int dur) 
    {
        yield return new WaitForSeconds(dur);
    }
}
