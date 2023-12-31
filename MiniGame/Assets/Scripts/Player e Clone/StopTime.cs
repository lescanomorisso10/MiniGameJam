using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StopTime : MonoBehaviour
{
    public static StopTime instance;
    public bool stopTime;
    [SerializeField]
    public Image FreezeTimeImage;
    [SerializeField]
    Image FreezeTimeBar;
    public AudioSource SoundaEffect;
    private void Start()
    {
        instance = this;
    }
    public void Stop()
    {
        stopTime = true;
        FreezeTimeImage.gameObject.SetActive(true);
        SoundaEffect.Play();
    }
    public void UpdateBar(float freezeTimeCoolDown, float maxFreezeTime)
    {
        FreezeTimeBar.fillAmount = freezeTimeCoolDown / maxFreezeTime;
        
    }
    private void Update()
    {
        
    }
}
