using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation_trig : MonoBehaviour
{
        public GameObject Obj;
        public string NameAnimation;
        private AudioSource aud;
    void Start() {
        aud = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Sphere") {
            Obj.GetComponent<Animation>().Play(NameAnimation);
            aud.Play ();
        }
    }
}
