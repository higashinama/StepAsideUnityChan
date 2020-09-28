using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InvisibleDestroy : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z < GameObject.FindWithTag("Player").transform.position.z - 5)
        {
                Destroy(this.gameObject);
        }
    }
}
