using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Portal : MonoBehaviour
{
    public Material[] materials;
    // Start is called before the first frame update
    void Start()
    {
        foreach (var mat in materials)
        {
            mat.SetInt("stest", (int)CompareFunction.Equal);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider collider)
    {
        if(collider.tag!="MainCamera")
        {
            Debug.Log("Not MainCamera");
            return;
        }

        //outside the portal
        if(transform.position.z>collider.transform.position.z)
        {
            Debug.Log("Outside Portal");
            foreach (var mat in materials)
            {
                mat.SetInt("stest", (int)CompareFunction.Equal);
                
            }
        }
        //inside
        else
        {
            Debug.Log("Inside Portal");
            foreach (var mat in materials)
            {
                
                mat.SetInt("stest", (int)CompareFunction.NotEqual);
            }
        }
    }
}
