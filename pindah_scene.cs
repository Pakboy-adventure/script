using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pindah_scene : MonoBehaviour
{
    // Start is called before the first frame update
    public void pindahscene (int yangdituju)
    {
        Application.LoadLevel(yangdituju);
    }
}
