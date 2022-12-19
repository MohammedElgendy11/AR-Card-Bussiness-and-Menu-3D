using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;



public class Animation : MonoBehaviour
{

   //public GameObject Btn;
    //public VirtualButtonBehaviour url_btn;
    // Start is called before the first frame update
    public void open_Web_url()
    {
            Debug.Log("Pressed");
            Application.OpenURL("https://www.sha.edu.eg/");
        
    }

    public void open_App()
    {
        Debug.Log("Pressed");
        Application.OpenURL("https://drive.google.com/drive/folders/1kirBwY35GZXiWwo9WnVsrFLdxQnGD3Yu?usp=sharing");

    }

}
