using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayAnimation : MonoBehaviour
{
    public Button up;
    //public AudioClip sound;
    public Animator anim;
    public Canvas canvas;

    // Start is called before the first frame update
    void Start()
    {
        up = up.GetComponent<Button>();
        anim.enabled = false;
        canvas.enabled = true;
    }

    public void Press()
    {
        up.enabled = true;
        //AudioSource.PlayClipAtPoint(sound, transform.position);
        anim.enabled = true;
    }
}
