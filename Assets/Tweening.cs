using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tweening : MonoBehaviour
{

    [SerializeField] GameObject ColorWheel, StartButton, SettingButton, Text_Draw, Text_Away, Text_Bugs, LogoPanel;
    void Start()
    {
        LeanTween.rotateAround(ColorWheel, Vector3.forward, 360f, 10f).setLoopClamp();
        LeanTween.scale(StartButton, new Vector3(0.06f, 0.06f, 1f), 1.5f).setDelay(1.7f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.scale(SettingButton, new Vector3(0.03f, 0.03f, 1f), 1f).setDelay(1.8f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.moveLocal(LogoPanel,new Vector3(0f, 0.6f, 1f), .6f).setEase(LeanTweenType.easeInOutCubic);
        LeanTween.moveLocal(Text_Draw,new Vector3(0f, 1.9f, 1f), .8f).setEase(LeanTweenType.easeInOutCubic);
        LeanTween.moveLocal(Text_Away,new Vector3(0f, 1.0f, 1f), 1.0f).setEase(LeanTweenType.easeInOutCubic);
        LeanTween.moveLocal(Text_Bugs,new Vector3(0f, -0.16f, 1f), 1.2f).setEase(LeanTweenType.easeInOutCubic);
    }


    
}