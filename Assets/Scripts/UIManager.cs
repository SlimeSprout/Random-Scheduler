using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class UIManager : MonoBehaviour
{

    [SerializeField] private Button RandomizeButton;
    private float Hours =1;
    [SerializeField] private Slider HoursPerSession;
    [SerializeField] private TextMeshProUGUI SliderText,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday;
    // Start is called before the first frame update
    
    void Start()
    {
        RandomizeButton.onClick.AddListener(Randomize);
        HoursPerSession.onValueChanged.AddListener(delegate {ValueChange ();});

        
    }
    void ValueChange ()
    {
        SliderText.text = HoursPerSession.value +" Hours Per Session";
        Hours = HoursPerSession.value;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Schedule(float hours) 
    {
        TextMeshProUGUI[] Days= {Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday};
        int hour = (int) hours;
        for(int i = 0;i<7 ;i++)
        {
            
            int randHour =0;
            randHour =(int)UnityEngine.Random.Range(0+hour, 24);
            int endHour = randHour;
            randHour=randHour-hour;
           
            Days[i].text = randHour+" - "+endHour;
            
            
        }

    }
    void Randomize()
    {
        Schedule(Hours);
    }
}
