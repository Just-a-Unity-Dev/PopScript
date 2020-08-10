using UnityEngine;

public class LavaScript : MonoBehaviour
{
    public AudioSource audioSource;
    public bool DestroyEverything = false;
    public bool DisableSound = false;

    void OnTriggerEnter2D(Collider2D col) {
        if (DestroyEverything == false) {
            if (DisableSound == false) {
                if (col.tag == "Target") {
                    if (col.tag == "Target") {
                        audioSource.Play();
                        Destroy(col.gameObject);
                    }
                }
            }
            else {
                if (col.tag == "Target") {
                    Destroy(col.gameObject);
                }
            }

        }
        else {
            if (DisableSound == false) {
                audioSource.Play();
                Destroy(col.gameObject);
            }
            else {
                Destroy(col.gameObject);
            }
        }

    }
}