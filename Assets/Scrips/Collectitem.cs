using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private Text fruitText;

    [SerializeField] private AudioSource collectSound;
    private int Fruits = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fruit"))
        {
            collectSound.Play();
            Destroy(collision.gameObject);
            Fruits++;
            fruitText.text = "fruits : " + Fruits;
        }

    }
}
