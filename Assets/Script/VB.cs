using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VB : MonoBehaviour
{

    public float rotationSpeed;
    Vector3 scale;
    public GameObject Models;
     VirtualButtonBehaviour[] VBS;
    bool IsPressed = false;
    
    void Start()
    {
        VBS = GetComponentsInChildren<VirtualButtonBehaviour>();
        foreach (var vb in VBS)
        {
            vb.RegisterOnButtonPressed(OnButtonPressed);
            vb.RegisterOnButtonReleased(OnButtonReleased);

        }

    }

    // Update is called once per frame
    void Update()
    {
        if (IsPressed)
        {

            Debug.LogWarning("Still_Pressed");
                // Models[i].transform.localScale += new Vector3(1f * Time.deltaTime, 1f * Time.deltaTime, 1f * Time.deltaTime);
                Models.transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);

        }
    }
    public void OnButtonPressed(VirtualButtonBehaviour btn)
    {
        if (btn.VirtualButtonName == "rotate")
        {
            IsPressed = true;
            Debug.Log("rotateeeeeeeeeeeeeeeeeeeee");

        }
        if (btn.VirtualButtonName == "Link")
        {
            Debug.Log("linkkkkkkkkkkkkkkkkkkkk");
            Application.OpenURL("https://www.dunkindonuts.com/en/menu/donuts/product-donuts-id1001201");

        }

    }

    public void OnButtonReleased(VirtualButtonBehaviour btn)
    {
        if (btn.VirtualButtonName == "rotate")
        {
            IsPressed = false;
            
        }
       
    }
   /* public void openurl()
    {
        Debug.Log("Pressed");
        Application.OpenURL("https://www.sha.edu.eg/");

    }*/


}
