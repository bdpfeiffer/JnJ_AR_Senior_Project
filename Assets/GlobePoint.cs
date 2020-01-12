using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobePoint : MonoBehaviour
{

    public static GlobePoint Instance { get; private set; }

    Vector3 pointVec, tempVec, tempVec2, pointOnTop, spherecenter, GlobeOrigin; // = GameObject.transform.position;
    float latitude, longitude, latRad, longRad, radi, xP, yP, zP, tempVecLength;
    public Transform c0, c1, c2, c3, c4, c5, c6, c7, c8, c9;
    public float off1, off2;
    // Mesh mesh;
    //float radius;
    public IPArray ip;
    public int count = 0;


    private void Awake()
    {
        // children ie points to appear on globe
        c0 = this.gameObject.transform.GetChild(0);
        c1 = this.gameObject.transform.GetChild(1);
        c2 = this.gameObject.transform.GetChild(2);
        c3 = this.gameObject.transform.GetChild(3);
        c4 = this.gameObject.transform.GetChild(4);
        c5 = this.gameObject.transform.GetChild(5);
        c6 = this.gameObject.transform.GetChild(6);
        c7 = this.gameObject.transform.GetChild(7);
        c8 = this.gameObject.transform.GetChild(8);
        c9 = this.gameObject.transform.GetChild(9);


        ip = this.gameObject.GetComponent<IPArray>();

        GlobeOrigin = this.transform.position; // is questionable

        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);

        }
    }
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine("DoCheck");

    }

    // Update is called once per frame
    void Update()
    {
        spherecenter = this.transform.position;
        this.GetComponent<SphereCollider>().center = spherecenter;

    }

    Vector3 calc_coords(float lat, float lon)
    {

        latRad = lat * (float)(3.142 / 180);
        longRad = lon * (float)(3.142 / 180);

        radi = this.GetComponent<SphereCollider>().radius;
        //radi = this.GetComponent<Renderer>().bounds.extents.magnitude;
        //radi = radius;
        xP = (radi) * Mathf.Cos(latRad) * Mathf.Cos(longRad);
        yP = (radi) * Mathf.Sin(latRad);
        zP = (radi) * Mathf.Cos(latRad) * Mathf.Sin(longRad);
        pointVec = new Vector3(xP, yP, zP);
        //print(pointVec);

        tempVec = pointVec - GlobeOrigin;
        tempVecLength = Mathf.Sqrt(tempVec.x * tempVec.x + tempVec.y * tempVec.y + tempVec.z * tempVec.z);
        tempVec2 = (radi / Mathf.Abs(tempVecLength)) * tempVec;
        return tempVec2 + tempVec;

    }

    IEnumerator DoCheck()
    {
        int n = ip.getSize();
        //print(n);
        for (; ; )
        {
            count = 0;
            for (int i = 0; i < n; i++)
            {
                latitude = ip.accessLati(i);
                longitude = ip.accessLongi(i);
                off2 = 75; // 110;
                off1 = 0;
                //rad1 = this.GetComponent<SphereCollider>().radius;
                //rad2 = this.GetComponent<Renderer>().bounds.extents.magnitude;


                if (count == 0)
                {
                    pointOnTop = calc_coords(latitude + off1, longitude + off2);
                    c0.localPosition = pointOnTop;
                }
                else if (count == 1)
                {
                    pointOnTop = calc_coords(latitude + off1, longitude + off2);
                    Vector3 test = new Vector3(-15.58f,9.22f,-8.9f);
                    c1.localPosition = test;
                }
                else if (count == 2)
                {
                    off2 = off2 + 35;
                    off1 = off1 - 2;
                    pointOnTop = calc_coords(latitude + off1, longitude + off2);
                    c2.localPosition = pointOnTop;
                    off2 = off2 - 35;
                    off1 = off1 + 2;
                }
                else if (count == 3)
                {

                    pointOnTop = calc_coords(latitude + off1, longitude + off2);
                    c3.localPosition = pointOnTop;
                }
                else if (count == 4)
                {
                    off2 = off2 + 25;
                    off1 = off1 + 3;
                    pointOnTop = calc_coords(latitude + off1, longitude + off2);
                    c4.localPosition = pointOnTop;
                    off2 = off2 - 25;
                    off1 = off1 - 3;
                }
                else if (count == 5)
                {
                    pointOnTop = calc_coords(latitude + off1, longitude + off2);
                    c5.localPosition = pointOnTop;
                }
                else if (count == 6)
                {
                    off2 = off2 + 35;
                    off1 = off1 - 2;
                    pointOnTop = calc_coords(latitude + off1, longitude + off2);
                    c6.localPosition = pointOnTop;
                    off2 = off2 - 35;
                    off1 = off1 + 2;
                }
                else if (count == 7)
                {
                    off1 = off1 - 6;
                    pointOnTop = calc_coords(latitude + off1, longitude + off2);
                    c7.localPosition = pointOnTop;
                    off1 = off1 + 6;
                }
                else if (count == 8)
                {
                    float temp = off2;
                    float temp1 = off1;
                    off2 = 69;
                    off1 = -3;
                    pointOnTop = calc_coords(latitude + off1, longitude + off2);
                    c8.localPosition = pointOnTop;
                    off2 = temp;
                    off1 = temp1;
                }
                else if (count == 9)
                {
                    float temp = off2;
                    float temp1 = off1;
                    off2 = 72;
                    off1 = -10;
                    pointOnTop = calc_coords(latitude + off1, longitude + off2);
                    c9.localPosition = pointOnTop;
                    off2 = temp;
                    off1 = temp1;

                }
                count++;
                yield return new WaitForSeconds(10f);
            }
        }
        //count = 0;
    }
}
