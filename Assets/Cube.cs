using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        Vector3 movement = Vector3.one;
        Matrix4x4 rotation = Matrix4x4.Rotate(Quaternion.Euler(0,0,45f));
        Matrix4x4 translation = Matrix4x4.Translate(movement);

        Vector4 newPosition = rotation * translation * new Vector4(transform.position.x, transform.position.y, transform.position.z, 1);
        transform.position = new Vector3(newPosition.x, newPosition.y, newPosition.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
