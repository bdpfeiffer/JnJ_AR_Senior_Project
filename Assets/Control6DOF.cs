using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.MagicLeap;
public class Control6DOF : MonoBehaviour
{
    // Start is called before the first frame update



    private MLInputController _controller;

    
    void Start()
    {
        MLInput.Start();
        _controller = MLInput.GetController(MLInput.Hand.Left);
        
        
    }

    void OnDestroy() {
        MLInput.Stop();
    }
    // Update is called once per frame
    void Update()
    {
    
        transform.position = _controller.Position;
        transform.rotation = _controller.Orientation;

        Vector3 vector3 = new Vector3(1,0,1);

        


    }
}
