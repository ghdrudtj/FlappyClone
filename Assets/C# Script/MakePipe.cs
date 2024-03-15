using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;
    public float TimeDiff;
    float timer = 0;

    void Start()
    {
        timer = TimeDiff;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > TimeDiff)
        {
            GameObject NewPipe=Instantiate(pipe);
            NewPipe.transform.position = new Vector3(3.83F, Random.Range(-1.5f, 3.27f), 0);
            timer = 0;

            Destroy(NewPipe, 10);
        }
    }
    
}
