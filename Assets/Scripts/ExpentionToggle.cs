using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ExpentionButton : Button
{
    [SerializeField]
    private bool useToggle;

    public bool IsOn;

    [SerializeField]
    private Image iconImg;

    [SerializeField]
    private Text iconText;

    [SerializeField]
    private Color changingColor;

    [SerializeField]
    private Color defoColor;

    public override void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
    {
        base.OnPointerDown(eventData);

        if (useToggle)
        {
            IsOn = !IsOn;
            if (IsOn)
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
}
