using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour {
    public bool taNoChao;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Chao"))
        {
            taNoChao = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if (other.CompareTag("Chao"))
        {
            taNoChao = false;
        }
    }
}
