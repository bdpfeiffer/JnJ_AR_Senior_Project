using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.MagicLeap;
public class DyanmicBeam : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject controller;
    private LineRenderer beamLine;

    public Color startColor;
    public Color endColor;
    void Start()
    {
        beamLine = GetComponent<LineRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = controller.transform.position;
        transform.rotation = controller.transform.rotation;
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.collider.gameObject.name == "Globe")
            {
                Debug.Log("Hit Globe");
                Behaviour halo = (Behaviour)hit.collider.gameObject.GetComponent("Halo");
                halo.enabled = true;
            }else if (hit.collider.gameObject.name == "Plane")
            {
                Behaviour halo = (Behaviour)hit.collider.gameObject.GetComponent("Halo");
                halo.enabled = true;
            }
            beamLine.useWorldSpace = true;
            beamLine.SetPosition(0, transform.position);
            beamLine.SetPosition(1, hit.point);

        }
        else
        {
            beamLine.useWorldSpace = false;
            beamLine.SetPosition(0, transform.position);
            beamLine.SetPosition(1, Vector3.forward * 5);
            GameObject obj = GameObject.Find("Globe");
            Behaviour test = (Behaviour)obj.GetComponent("Halo");
            test.enabled = false;

            GameObject planeObj = GameObject.Find("Plane");
            Behaviour testHalo = (Behaviour)planeObj.GetComponent("Halo");
            testHalo.enabled = false;
        }





    }
}
