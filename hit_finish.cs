using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit_finish : MonoBehaviour
{
    public GameObject menang;
    public GameObject btnkanan , btnkiri, btnup ;



    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("girl_end"))
        {
            menang.SetActive (true);
            print(" ya menang lah asw ");
            //btnUI lur
            btnkanan.SetActive(false);
            btnkiri.SetActive(false);
            btnup.SetActive(false);
        }
    }
}
