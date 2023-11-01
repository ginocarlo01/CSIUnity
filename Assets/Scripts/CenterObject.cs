using Imagine.WebAR;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterObject : MonoBehaviour
{
    ImageTracker imageTracker;
    ARCamera arCamera;
    [SerializeField]
    float zOffset;
    //public static CenterObject instance;
    // Start is called before the first frame update
    void Awake()
    {
        //instance = this;
        imageTracker = FindObjectOfType<ImageTracker>();
        arCamera = FindObjectOfType<ARCamera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (imageTracker.GetKeepObjectInScene())
        {
            transform.position = new Vector3(arCamera.gameObject.transform.position.x, 
                arCamera.gameObject.transform.position.y, 
                arCamera.gameObject.transform.position.z + zOffset);
        }
    }
}
