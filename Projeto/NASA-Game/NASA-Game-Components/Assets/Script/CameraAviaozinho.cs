using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAviaozinho : MonoBehaviour
{

    public Transform MoveAviaozinho;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(MoveAviaozinho.position.x, transform.position.y, transform.position.z);
    }
}
