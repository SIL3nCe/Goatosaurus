using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public List<AudioClip> ScreamSounds;

    private AudioSource audioComp;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        audioComp = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("Scream", true);
        }
    }

    public void OnScream()
    {
        //TODO 1 function per scream, force anim stop by hand depending on sound length
        audioComp.PlayOneShot(ScreamSounds[0]);
        animator.SetBool("Scream", false);
    }
}
