using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimetor : MonoBehaviour
{
    // Start is called before the first frame update
    public void getAnimetorHipHop(){
        this.GetComponent<Animetor>().Play("Hip Hop Dancing");
    }
    public void getAnimetorSalsa(){
        this.GetComponent<Animetor>().Play("Salsa Dancing");
    }
}
