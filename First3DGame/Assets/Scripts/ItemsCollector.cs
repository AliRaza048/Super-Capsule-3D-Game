
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemsCollector : MonoBehaviour
{
    [SerializeField] Text CoinsText;
    [SerializeField] AudioSource CollectionSound;

    int coins=0;
  private void OnTriggerEnter(Collider collision){
    if(collision.gameObject.CompareTag("coin")){
        Destroy(collision.gameObject);
        coins++;
         CoinsText.text="Coins : "+coins;
         CollectionSound.Play();
    }
   }
}
