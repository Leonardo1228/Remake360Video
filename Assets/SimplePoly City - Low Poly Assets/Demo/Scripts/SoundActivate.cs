using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activarsonido : MonoBehaviour
{
    public GameObject post;
    public GameObject post1;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Act")
        {
            AudioManager.Instance.Play3D("Sound", post.transform.position);
            //AudioManager.Instance.Play2D("");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Act")
        {
            AudioManager.Instance.Play3D("Wind", post1.transform.position);
            //AudioManager.Instance.Play2D("Salir");
        }
    }
}
