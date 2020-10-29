using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ChangeMaterial : MonoBehaviour
{
    public Material redMatial;
    public Material blueMaterial;
    private Renderer renderer;
    private bool isRed = false;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.B))
        {
            renderer.material = blueMaterial;
        }

        if (Input.GetKeyUp(KeyCode.R))
        {
            renderer.material = redMatial;
        }
    }
}
