using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCar : MonoBehaviour
{
    Transform carTransform;

    // Start is called before the first frame update
    void Start()
    {
        carTransform = GetComponent<Transform>();       
    }

    // Update is called once per frame
    void Update()
    {
        carTransform.Translate(0, 0.01f, 0);
    }
}
