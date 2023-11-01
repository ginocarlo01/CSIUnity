using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CycleObjectsManager : MonoBehaviour
{

    [SerializeField]
    GameObject[] objects;
    [SerializeField]
    GameObject spawned;
    [SerializeField]
    int index;
    [Header("Debug")]
    [SerializeField]
    bool changeModel;
    private void OnValidate()
    {
        if (changeModel)
        {
            Cycle();
            changeModel= false;
        }
    }
    private void Awake()
    {
        //objects[index].SetActive(true);
        SpawnObjec();
        enableAnim = true;
    }
    public void Cycle()
    {
        index++;

        if(index > objects.Length-1)
        {
            index= 0;
        }

        /*foreach(GameObject i in objects) 
         {
             i.SetActive(false);
         }*/

        //objects[index].SetActive(true);

        SpawnObjec();
    }

    public int GetIndex()
    {
        return index;
    }

    public GameObject GetActiveObject()
    {
        return spawned;
    }

    void SpawnObjec()
    {
        if (spawned == null)
            spawned = Instantiate(objects[index], transform);
        else
        {
            DestroyImmediate(spawned);
            spawned = Instantiate(objects[index], transform);
        }
    }
    Animator anim;
    [SerializeField]
    bool enableAnim;
    public void EnableDisableAnimation()
    {
        enableAnim = !enableAnim;
        if (spawned != null)
        {
            anim = spawned.GetComponent<Animator>();

            if(anim != null) {
                
                anim.enabled = enableAnim;

            }
            else
            {
#if UNITY_EDITOR
                Debug.LogError("Object does not have animator component");
#endif


                return;
            }
        }
    }
}
