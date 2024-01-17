
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerLife : MonoBehaviour
{
   bool dead = false;
   [SerializeField] AudioSource DeathSound;
   private void Update(){
      if(transform.position.y < -1f && !dead){
       
         Die();
      }
   }
   
   private void OnCollisionEnter(Collision collision) {
    if(collision.gameObject.CompareTag("Enemy Body")){
      GetComponent<MeshRenderer>().enabled=false;
    GetComponent<Rigidbody>().isKinematic=true;
    GetComponent<PlayerMovement>().enabled=false;
        Die();
    }
   }
   void Die(){
    dead = true;
    Invoke(nameof(ReloadLevel),1.2f);
     DeathSound.Play();
   }
   void ReloadLevel(){
SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
}
