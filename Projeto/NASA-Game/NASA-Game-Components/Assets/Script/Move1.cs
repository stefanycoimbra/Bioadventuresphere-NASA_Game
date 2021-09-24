using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move1 : MonoBehaviour
{
  private Material currentMaterial;
  public float speeed;
  private float offset;
    // Start is called before the first frame update
    void Start()
    {
        currentMaterial = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        offset = Time.time * speeed;
        currentMaterial.SetTextureOffset ("_MainTex", new Vector2 (offset,0));
    }
}
