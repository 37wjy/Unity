using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageAlphaRaycast : MonoBehaviour
{

    public float alpha;   
    public Image theButton;

    // Start is called before the first frame update
    void Start()
    {
        theButton.alphaHitTestMinimumThreshold = alpha;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
