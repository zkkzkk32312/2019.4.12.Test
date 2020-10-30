using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Penis : MonoBehaviour
{

    public GameObject penis;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(penis, new Vector3(0,100.0f,0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
