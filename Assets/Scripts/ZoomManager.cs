using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomManager : MonoBehaviour
{
    [SerializeField]
    CycleObjectsManager cycleObjectsManager;
    GameObject objectToMove; 
    [Header("Debug")]
    [SerializeField]
    bool zoomIn, zoomOut;
    Vector3 min = new Vector3(0.1f, 0.1f, 0.1f);
    private void OnValidate()
    {
        if (zoomIn)
        {
            ZoomIn();
            zoomIn= false;
        }

        if (zoomOut)
        {
            ZoomOut();
            zoomOut = false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
#if UNITY_EDITOR
        //SetObject();
#endif
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*public void SetObject()
    {
        //return;
        cycleObjectsManager = ChangeButtonManager.instance.GetActiveCycleObject();

        if(cycleObjectsManager!=null)
        objectToMove = cycleObjectsManager.GetActiveObject();
    }*/
    public void ZoomIn()
    {
#if UNITY_EDITOR
        //objectToMove = this.gameObject;
#endif
        transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
        //objectToMove.transform.localScale -= Vector3.one;
        //transform.localScale -= Vector3.one;
        
        /*if (objectToMove != null)
        {
            //objectToMove.transform.Translate(-objectToMove.transform.forward * 5);
            //objectToMove.transform.localScale -= Vector3.one;
            objectToMove.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
            //objectToMove.transform.Rotate(-objectToMove.transform.up * 5);
            //transform.Rotate(-transform.up * 5);
        }*/
    }

    public void ZoomOut()
    {
#if UNITY_EDITOR
        //objectToMove = this.gameObject;
#endif
        //objectToMove.transform.localScale += Vector3.one;
        if(transform.localScale != min)
        transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
        /*if (objectToMove != null)
        {
            //objectToMove.transform.Translate(objectToMove.transform.forward * 5);
            //objectToMove.transform.localScale += Vector3.one;
            //objectToMove.transform.Rotate(objectToMove.transform.up * 5);
            //transform.Rotate(transform.up * 5);
            if(objectToMove.transform.localScale != min)
               objectToMove.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
        }*/
    }
}
