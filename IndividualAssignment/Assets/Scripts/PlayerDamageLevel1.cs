using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerDamageLevel1 : MonoBehaviour
{
    //public float health1 = 100f;
    //public static float totalBooks1 = 0;
    //private Scene scene;
    //public AudioSource hitAudio;
    //public GameObject hitEffect;

    //public GameObject loseScreen;
    //public int totalBooks = 0;

    //Start is called before the first frame update
    //void Start()
    //{
    //    scene = SceneManager.GetActiveScene();
    //    hitAudio = GetComponent<AudioSource>();
    //}

    //Update is called once per frame
    //void Update()
    //{
    //    if (hitEffect != null)
    //    {
    //        if (hitEffect.GetComponent<Image>().color.a > 0)
    //        {
    //            var color = hitEffect.GetComponent<Image>().color;
    //            color.a -= 0.005f;
    //            hitEffect.GetComponent<Image>().color = color;
    //        }
    //    }
    //    if (loseScreen != null)
    //    {
    //        if (loseScreen.GetComponent<Image>().color.a > 0)
    //        {
    //            var color2 = loseScreen.GetComponent<Image>().color;
    //            color2.a -= 0.005f;
    //            loseScreen.GetComponent<Image>().color = color2;
    //        }
    //    }
    //}

    //void OnCollisionEnter(Collision other)
    //{
    //    if (other.gameObject.tag == "Enemy")
    //    {
    //        hitAudio.Play();
    //        health1 -= 15;
    //        print(health1);

    //        var color = hitEffect.GetComponent<Image>().color;
    //        color.a = 1f;
    //        hitEffect.GetComponent<Image>().color = color;

    //        if (health1 <= 0)
    //        {
    //            Application.LoadLevel("LoseScreenLevel1");
    //        }

    //    }

    //}
}
