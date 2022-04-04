using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundEffect : MonoBehaviour
{
    [SerializeField]
    private AudioClip _clip;

    //void Start()
    //{
      //  SoundManager.Instance.PlaySound(_clip);
    //}

    public void PlayEffect()
    {
        SoundManager.Instance.PlaySound(_clip);
    }

}
