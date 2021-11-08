using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupBookLevel1 : MonoBehaviour
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
            PlayerDamage.totalBooks1++;
            print("Total Books: " + PlayerDamage.totalBooks1);
            if (PlayerDamage.totalBooks1 >= 3)
            {
                Application.LoadLevel("LevelTransition");
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
