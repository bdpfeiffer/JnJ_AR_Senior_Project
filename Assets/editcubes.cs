using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class editcubes : MonoBehaviour
{
    // Start is called before the first frame update

    private GameObject chinaCube;
    
    private GameObject nkCube;
    
    private GameObject russiaCube;
    
    private GameObject iranCube;

    public int count;
    void Start()
    {
        Behaviour halo = (Behaviour)GetComponent("Halo");
		halo.enabled=false;
        transform.position = new Vector3(-0.5f,0,1f);
        count = 0;
       StartCoroutine("DoCheck");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     IEnumerator DoCheck() {
     for(;;) {
         if(count == 2) {
             transform.GetChild(0).transform.localScale += new Vector3(0,1,0);
             transform.GetChild(0).transform.Translate(Vector3.up*.025f);

             
         }else if(count == 4) {
             transform.GetChild(2).transform.localScale += new Vector3(0,1,0);
             transform.GetChild(2).transform.Translate(Vector3.up*.025f);
         }else if(count == 6) {
             transform.GetChild(1).transform.localScale += new Vector3(0,1,0);
             transform.GetChild(1).transform.Translate(Vector3.up*.025f);
         }else if(count == 8) {
             transform.GetChild(3).transform.localScale += new Vector3(0,1,0);
              transform.GetChild(3).transform.Translate(Vector3.up*.025f);
         }else if(count == 10) {
             transform.GetChild(2).transform.localScale += new Vector3(0,1,0);
              transform.GetChild(2).transform.Translate(Vector3.up*.025f);
         }
         count++;
         yield return new WaitForSeconds(10f);
     }
 }
}
