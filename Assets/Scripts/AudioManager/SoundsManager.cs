using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundsManager : MonoBehaviour
{

    public static SoundsManager instance;

   
    //Sound Effects
    public AudioClip sfx_jump, sfx_money, sfx_flecha, sfx_Health, sfx_muerteFuego, sfx_attackEfecto;

    //sound effect
    public GameObject soundObject;


    private void Awake()
    {
        instance = this;
    }

   

    void SoundObjectCreation(AudioClip clip)
    {

        //Create soundObject
        GameObject newObject = Instantiate(soundObject, transform);
        //Assign audioClip
        newObject.GetComponent<AudioSource>().clip = clip;
        //PlayAudio
        newObject.GetComponent<AudioSource>().Play();

    }


    public void PlaySFX(string sfxname)
    {
        switch (sfxname)
        {
            case "jump":
                SoundObjectCreation(sfx_jump);
                break;

            case "money":
                SoundObjectCreation(sfx_money);
                break;

            case "flecha":
                SoundObjectCreation(sfx_flecha);
                break;

            case "Health":
                SoundObjectCreation(sfx_Health);
                break;

            case "muerte_fuego":
                SoundObjectCreation(sfx_muerteFuego);
                break;

            case "attack_efecto":
                SoundObjectCreation(sfx_attackEfecto);
                break;
         
            default:
                Debug.Log("not sound found");
                break;
        }
    }

}
