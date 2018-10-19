using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbScript : MonoBehaviour, IVirtualButtonEventHandler {

    private GameObject vButtonObject;
    private GameObject cubo;



    // Use this for initialization
    void Start () {

        vButtonObject = GameObject.Find("actionButton");
        cubo = GameObject.Find("cuboide");
        vButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		
	}
	
	
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        //throw new System.NotImplementedException();
        cubo.SetActive(false);

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //throw new System.NotImplementedException();
        cubo.SetActive(true);
    }
}
