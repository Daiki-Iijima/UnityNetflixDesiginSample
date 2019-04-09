using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ExpentionToggle : Toggle
{
    [SerializeField]
    private Image iconImg;

    [SerializeField]
    private Text iconText;

    [SerializeField]
    private Color changingColor;

    [SerializeField]
    private Color defoColor;

    public void Update()
    {
        if (isOn)
        {
            iconImg.color = changingColor;
            iconText.color = changingColor;
        }
        else
        {
            iconImg.color = defoColor;
            iconText.color = defoColor;

        }
    }
}
