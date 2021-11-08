using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TotalBooksUI : MonoBehaviour
{
    public TMP_Text totalBooksText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        totalBooksText.text = "Books: " + PlayerDamage.totalBooks.ToString() + " / 3";
    }
}
