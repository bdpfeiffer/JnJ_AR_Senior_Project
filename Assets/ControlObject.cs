using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.MagicLeap;
public class ControlObject : MonoBehaviour
{
    // Start is called before the first frame update
    private MLInputController controller;
    void Start()
    {
            MLInput.Start();
            MLInput.OnControllerButtonDown += OnButtonDown;
            controller = MLInput.GetController(MLInput.Hand.Left);

    }

    void OnButtonDown( byte contorller_id, MLInputControllerButton button)
    {
        if(button == MLInputControllerButton.Bumper) {
                RaycastHit hit;
                if(Physics.Raycast(controller.Position,transform.forward,out hit)) {
                    GameObject test = hit.collider.gameObject;
                    test.transform.position = new  Vector3(0,0,400);
                }
        }
        if(button == MLInputControllerButton.HomeTap) {
            GameObject globe = GameObject.Find("Globe");
             globe.transform.position = new  Vector3(0,0,3);
             GameObject barChart = GameObject.Find("Plane");
             barChart.transform.position = new Vector3(-0.5f,0,1f);
        }
        
    }
    private void onDestroy()
    {
        MLInput.Stop();
        MLInput.OnControllerButtonDown -= OnButtonDown;
    }
    // Update is called once per frame
    void Update()
    {
        if(controller.TriggerValue > .2f) {
            RaycastHit hit;
            if(Physics.Raycast(controller.Position,transform.forward, out hit)) {
                GameObject obj = hit.collider.gameObject;
                if(obj.name == "nKAlert") {
                    GameObject nk = GameObject.Find("nkIPADDRESS");
                     nk.transform.position = new Vector3(0 ,0.1319f,1.087f);
                }else if(obj.name == "chinaAlert") {
                     GameObject nk = GameObject.Find("chinaIPADDRESS");
                     nk.transform.position = new Vector3(0 ,0.1319f,1.087f);
                }else if(obj.name == "russiaAlert") {
                     GameObject nk = GameObject.Find("russiaIPADDRESS");
                     nk.transform.position = new Vector3(0 ,0.1319f,1.087f);
                }else if(obj.name == "iranALERT") {
                     GameObject nk = GameObject.Find("iranIPADDRESS");
                     nk.transform.position = new Vector3(0 ,0.1319f,1.087f);
                }else if(obj.name == "russiaAlert2") {
                     GameObject nk = GameObject.Find("russiaIPADDRESS2");
                     nk.transform.position = new Vector3(0 ,0.1319f,1.087f);
                }
            }
        }
    }
}
