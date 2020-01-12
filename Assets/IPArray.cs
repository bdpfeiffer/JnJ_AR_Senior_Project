using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IPArray : MonoBehaviour
{
    public string[] IPAdd = { "52.92.249.179", "122.227.174.4", "63.17.193.115", "37.192.152.3",   "177.19.14.153", "175.45.176.0","214.213.63.64","5.112.0.0","133.29.28.121","37.9.0.0"};
    public string[] country = { "India", "China", "United States", "Russia",  "Brazil", "North Korea","United States","Iran","Japan","Russia"};
    public string[] city = { "Powai", "Ninghai", "Atlanta", "Novosibirsk", "Sao Paulo", "Pyongyang", "Cedar Rapids", "Tehran","Kariya","Saint Petersburg"};
    public float[] lati = {(float)19.076000213623047, (float)37.37990188598633, (float)33.798458099365234, (float)55.03923034667969,   (float)-23.5515193939209, (float)39.0392, (float)41.974700927734375, (float)35.68722152709961, (float)35.14854049682617, (float)59.93904113769531};
    public float[] longi = {(float)72.87770080566406, (float)121.58999633789062,  (float)-84.3882827758789, (float)82.92781829833984,  (float)-46.633140563964844, (float)125.7625, (float)-91.65540313720703, (float)51.415279388427734, (float)136.91885375976562, (float)30.3157901763916};

    // Start is called before the first frame update





    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public string accessIP(int i)
    {
        return IPAdd[i];
    }

    public string accessCount(int i)
    {
        return country[i];
    }

    public string accessCity(int i)
    {
        return city[i];
    }

    public float accessLati(int i)
    {
        return lati[i];
    }

    public float accessLongi(int i)
    {
        return longi[i];
    }
    public int getSize()
    {
        return lati.Length;
    }
}
