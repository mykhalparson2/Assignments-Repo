using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovementRight : MonoBehaviour
{
  private Transform myTransform;
  private float speed;
    // Start is called before the first frame update
    void Start()
    {
      myTransform = transform;
      speed = Random.Range(-3.50f, 3.50f);
    }

    // Update is called once per frame
    void Update()
    {
        myTransform.position += (Vector3.right * Time.deltaTime * speed) /1.5 ;
    }
}
