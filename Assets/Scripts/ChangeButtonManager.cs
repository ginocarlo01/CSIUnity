using Imagine.WebAR;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeButtonManager : MonoBehaviour
{
    CycleObjectsManager cycleObjectsManager;
    ZoomManager zoomManager;
    [SerializeField]
    Button changeModelButton, zoomInButton, zoomOutButton, disableAnimation;
    [SerializeField]
    Toggle toggle;
    public static ChangeButtonManager instance;
    [Header("Debug")]
    [SerializeField]
    bool initialize;
    private void OnValidate()
    {
        if (initialize)
        {
            SetCycleObjectsManager();
            SetZoomManager();
            initialize= false;
        }
    }
    // Start is called before the first frame update
    void Awake()
    {
        instance= this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void SetCycleObjectsManager()
    {

        cycleObjectsManager = FindObjectOfType<CycleObjectsManager>();

        if (cycleObjectsManager != null)
        {
            changeModelButton.onClick.RemoveAllListeners();
            changeModelButton.onClick.AddListener(delegate { cycleObjectsManager.Cycle(); });
            disableAnimation.onClick.RemoveAllListeners();
            disableAnimation.onClick.AddListener(delegate { cycleObjectsManager.EnableDisableAnimation(); });
            //changeModelButton.onClick.AddListener(SetObject);
        }
    }

    public CycleObjectsManager GetActiveCycleObject()
    {
        return cycleObjectsManager;
    }

    public void SetZoomManager()
    {
        zoomManager = FindObjectOfType<ZoomManager>();
       
        if (zoomManager != null)
        { 
            //zoomManager.SetObject();
            zoomInButton.onClick.RemoveAllListeners();
            zoomOutButton.onClick.RemoveAllListeners();

            zoomInButton.onClick.AddListener(delegate { zoomManager.ZoomIn(); });
            zoomOutButton.onClick.AddListener(delegate { zoomManager.ZoomOut(); });
        }
    }

    public void SetObject()
    {
        return;
        if (zoomManager != null)
        {
            zoomManager = FindObjectOfType<ZoomManager>();
            //zoomManager.SetObject();
        }
    }

    public void SetToogle()
    {
        ImageTracker imageTracker = FindObjectOfType<ImageTracker>();
        if(imageTracker == null)
        {
            print("Image tracker is null");
        }
        if (imageTracker != null && toggle!=null)
        {
            print("is kept");
            imageTracker.SetKeepObjectInScene(toggle.isOn);
        }
    }
}
