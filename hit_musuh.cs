using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit_musuh : MonoBehaviour
{

    // Start is called before the first frame update

    // private void OnTriggerEnter2D(Collider2D other)
    // {
    //    Debug.Log("NGEBUG TEROOS...");
    //    Destroy(other.gameObject);
    // }

    //lose win
    public GameObject kalah;
    public GameObject btnkanan , btnkiri, btnup ;


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("virus"))
        {
            kalah.SetActive (true);
            print(" yah mati :( ");
            Destroy (gameObject);
            //btnUI lur
            btnkanan.SetActive(false);
            btnkiri.SetActive(false);
            btnup.SetActive(false);
            
        }
    }
}
