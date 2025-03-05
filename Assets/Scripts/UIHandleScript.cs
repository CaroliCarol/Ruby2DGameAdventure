using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UIHandleScript : MonoBehaviour
{
    public float CurrentHealth = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        UIDocument uiDocument = GetComponent<UIDocument>();
        VisualElement healthBar = uiDocument.rootVisualElement.Q<VisualElement>("HealthBar");
        healthBar.style.width = Length.Percent(CurrentHealth * 100.0f);
    }

}
