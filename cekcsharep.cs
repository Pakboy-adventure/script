using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cekcsharep : MonoBehaviour
{
    public string nama;                     //untuk huruf / karakter
    public int angka;                       // untuk angka tanpa koma
    public bool aktif;                      // untuk aktif/ tidak ( true / false )
    public float kecepatan;                 //untuk angka berkoma (1,3432)

    // Start is called before the first frame update
    void Start() // frame awal (tidak looping)
    {
        
    }

    // Update is called once per frame
    void Update()                           // looping
    {
        kecepatan += Time.deltaTime;        // kecepatan akan bertambah karena (+) || kalo kurang  ganti ae (-) contoh (kecepatan (+)(-)=Time.deltatime;)

        if(kecepatan > 3)                   // ketika float kecepatan lebih dari 3
        {
            aktif = true;                   // maka fariable bolean / aktif bakal jadi true (sebelum e false)
        }
        if(aktif == true)                   // ketika fariable bolean / aktif
        {
            angka = 500 ;                   // maka angka akan mencetak 500
        }
        if(angka == 500)                    // ketika fariable int angka 500 
        {
            print ("nama");                 // maka akan mencetak karakter di variable nama
        }
    }
}
