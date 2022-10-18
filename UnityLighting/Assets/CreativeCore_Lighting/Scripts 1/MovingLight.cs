using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingLight : MonoBehaviour
{

    GameObject thise;
    // Start is called before the first frame update
    void Start()
    {
      thise = this.gameObject;

    }

    // Update is called once per frame
    void Update()
    {
      thise.transform.position = new Vector3(thise.transform.position.x, thise.transform.position.y,  (Mathf.Sin(Mathf.PingPong(Time.time*Mathf.PI/10, Mathf.PI))+1));

    }
}
