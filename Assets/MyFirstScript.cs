using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc : MonoBehaviour
{
    public int frameNum;

    // Start is called before the first frame update
    void Start()
    {
        frameNum = 1;
        Debug.Log("I was told to start " + this.gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Frame " + frameNum + " Update at Time:" + Time.time);
        frameNum = frameNum + 1;
    }
}
