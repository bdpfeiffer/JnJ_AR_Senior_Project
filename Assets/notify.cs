using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.MagicLeap;

public class notify : MonoBehaviour
{
    public GameObject test;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
      
            if (Input.GetKeyDown(KeyCode.S)){
                test.SetActive(false);
            }
            

     
      
            if (Input.GetKeyDown(KeyCode.W))
            {
                test.SetActive(true);
            }
   
    }
      
    }
