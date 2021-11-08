using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupBook : MonoBehaviour
{

    public AudioSource pickupAudio;

    // Start is called before the first frame update
    void Start()
    {
        pickupAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            pickupAudio.Play();
            Destroy(gameObject);
            PlayerDamage.totalBooks++;
            print("Total Books: " + PlayerDamage.totalBooks);
            if (PlayerDamage.totalBooks >= 3)
            {
                Application.LoadLevel("WinScreen");
            }
        }
    }
}

//    private void OnCollisionEnter(Collision collision)
//    {
//        if (collision.gameObject.tag == "Player")
//        {
            
//        }
//    }
//}
