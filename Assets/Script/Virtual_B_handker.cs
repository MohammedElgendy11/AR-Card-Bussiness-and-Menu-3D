using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Virtual_B_handker : MonoBehaviour
{
    public float rotationSpeed;
    Vector3 scale;
    public GameObject[] Models;
    public VirtualButtonBehaviour VBS;
    bool IsPressed = false;

    void Start()
    {
        VBS = GetComponentInChildren<VirtualButtonBehaviour>();
        VBS.RegisterOnButtonPressed(OnButtonPressed);
        VBS.RegisterOnButtonReleased(OnButtonReleased);

    }

    // Update is called once per frame
    void Update()
    {
       /* if (IsPressed)
        {

            Debug.LogWarning("Still_Pressed");
            for (int i = 0; i < Models.Length; i++)
            {
                // Models[i].transform.localScale += new Vector3(1f * Time.deltaTime, 1f * Time.deltaTime, 1f * Time.deltaTime);
                Models[i].transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);

            }

        }*/
    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
       // IsPressed = true;
       // Application.OpenURL("https://www.sha.edu.eg/");

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        IsPressed = false;

    }
}


/* public void setScale(int index)
 {
     if (index >= 0 && index < Models.Length)
     {
         for (int i = 0; i < Models.Length; i++)
         {
             Models[i].transform.localScale = scale;
         }
         scale = transform.localScale;
         scale.x += Time.deltaTime;
     }
 }
/* public void setupScale()
 {

         for (int i = 0; i < Models.Length; i++)
         {
             Models[i].transform.localScale = scale;
         }
         scale = transform.localScale;
         scale.x += Time.deltaTime;

 }*/

