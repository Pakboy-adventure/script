using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class gerak_karakter : MonoBehaviour
{
    
    //bagian membuat jalan kanan kiri 
    public int kecepatan; 
    //

    //bagian membuat lompat
    Rigidbody2D lompat; 
    public int kekuatanlompat;

    //bagian animasinya biar bisa flip
    public int pindah;
    public bool balik;

    //bagian detektor tanah supaya bisa 1x jump
    public bool tanah;
    public LayerMask targetlayer;
    public Transform deteksitanah;
    public float jangkauan;

    //gambar animasinya
    Animator anim;

    //tombol gerak di UInya (andro)
    public bool tombolkiri , tombolkanan , tombolloncat;

    //buat target coin (side quest)
    public int coin;





    // Start is called before the first frame update
    void Start()
    {
        
        lompat = GetComponent<Rigidbody2D>(); // memanggil komponen lompat saat start frame
        anim = GetComponent<Animator>();
    }

    
    // Update is called once per frame
    void Update()
    {
        //  membuat kondisi dan set tombol jalan kanan kiri
        if (Input.GetKey(KeyCode.D) || (tombolkanan == true))
        {
            anim.SetBool ("mulai_lari",true);
            transform.Translate(Vector2.right * kecepatan * Time.deltaTime);
            pindah = -1; // membuat tanda animasinya ketika ke kanan

        } else if (Input.GetKey(KeyCode.A) || (tombolkiri == true))
        {
            anim.SetBool("mulai_lari", true);
            transform.Translate(Vector2.right * -kecepatan * Time.deltaTime); // yang mebedakan cuman di ( kecepatan || - kecepatan)
            pindah = 1; //membuat tanda animasinya ketika ke kiri
        } else
        {
            anim.SetBool ("mulai_lari", false);
        }

        // membuat set tombol dan kekuatan lompat
        if (tanah == true && (Input.GetKey(KeyCode.W) || (tombolloncat == true)))
        {
            anim.SetBool("mulai_terbang",true);
            lompat.AddForce(new Vector2(0, kekuatanlompat));
        } 

        // step 3 membuat kondisi anim flip
        if (pindah > 0 && !balik)
        {
            balikbadan();
        } else if ( pindah < 0 && balik)
        {
            balikbadan();
        }


        if (tanah == false)
        {
            anim.SetBool("mulai_terbang", true);
        }
        else
        {
            anim.SetBool("mulai_terbang", false);
        } //nama transisi jump di animator

        // winlose condisionnya
        

        tanah = Physics2D.OverlapCircle(deteksitanah.position, jangkauan, targetlayer);
    }

    void balikbadan() //step 3 membuat perhitungan 
    {
        balik = !balik;
        Vector3 karakter = transform.localScale;
        karakter.x *= -1;
        transform.localScale = karakter;
    }

    //UItombolkiri 
    public void tekankiri()
    {
        tombolkiri = true;
    }

    public void lepaskiri()
    {
        tombolkiri = false;
    }

    //UItombol kanan
    public void tekankanan()
    {
        tombolkanan = true;
    }

    public void lepaskanan()
    {
        tombolkanan = false;
    }

    //UItombol lompat
    public void tekanlompat()
    {
        tombolloncat = true;
    }

    public void lepaslompat()
    {
        tombolloncat = false;
    }

}
