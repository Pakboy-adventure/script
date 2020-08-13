using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotasi : MonoBehaviour
{
    public int kecepatanX, kecepatanY, kecepatanZ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(kecepatanX, kecepatanY, kecepatanZ); //cara kedua ( bisa custom di unity)
        //transform.Rotate(0, 0, 0);  // transform ( berasal dari inspektor) rotate (dari rotation) 0,0,0 ( urutan sumbu X,Y,Z) cara pertama ini
    }
}
