using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class koin : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            print("coin diambil");
            Destroy(gameObject);
            scorecoincincin.hitungcoin += 10;
        }
    }
}
