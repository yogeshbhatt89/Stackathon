
using UnityEngine;
public class KillPlayer : MonoBehaviour
{
  [SerializeField] private AudioClip dead;
    [SerializeField]Transform spawnPoint;

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.transform.CompareTag("Player")){collision.transform.position = spawnPoint.position;
        SoundManager.instance.PlaySound(dead);}

    }
}
