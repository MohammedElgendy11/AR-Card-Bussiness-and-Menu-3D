using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURL : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void youtube()
    {
        Application.OpenURL("https://www.youtube.com/channel/UCJ2Nl7vKA9-j6795l6egubA?view_as=subscriber");
    }
    public void twitter()
    {
        Application.OpenURL("https://twitter.com/GameHou53267722");
    }
    public void linkedin()
    {
        Application.OpenURL("https://www.linkedin.com/in/game-house-35a1261b0/");
    }
}
