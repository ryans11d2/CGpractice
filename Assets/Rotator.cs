using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.FilePathAttribute;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 20 * Time.deltaTime, 0));
        //if (Input.GetKey(KeyCode.RightArrow)) transform.Rotate(new Vector3(0, -20 * Time.deltaTime, 0));
    }
}