using System;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBarManager : MonoBehaviour
{

    [SerializeField]
    private Transform finishLine;
    [SerializeField]
    private Transform startLine;

    private Slider slider;
    private float distance;

    private void OnEnable()
    {
        PlayerMouvement.OnPlayerMouvement += UpdateProgressBar;
    }

    void Start()
    {
        slider = this.GetComponent<Slider>();
        distance = MathF.Abs(finishLine.position.y - startLine.position.y);
    }

    private void UpdateProgressBar(float playerY)
    {
        if(playerY < finishLine.position.y)
            slider.value = 1 - (MathF.Abs(finishLine.position.y - playerY) / distance);
    }

    private void OnDisable()
    {
        PlayerMouvement.OnPlayerMouvement -= UpdateProgressBar;
    }
}
