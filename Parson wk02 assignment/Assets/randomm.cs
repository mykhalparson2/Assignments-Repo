using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class randomm : MonoBehaviour
{
        public Transform myTransform;
        public float speed;
        private float timer;
    // Start is called before the first frame update
    void Start()
    {
        myTransform.position = new Vector3( -5, myTransform.position.y, 0);
        timer = 0;
    }
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1)
        {
            timer = 0;
            myTransform.position += new Vector3(Random.Range(-1, 2), 0, 0) * speed;
        }
    }
}
