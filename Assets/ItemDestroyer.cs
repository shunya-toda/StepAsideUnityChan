using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Camera.main.gameObject.transform.position.z>this.transform.position.z)
        {
            Destroy(this.gameObject);
        }
    }
}
