Using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class MonoEventsBehavior : MonoBehaviour
{
    public UnityEvent startEvent, awakeEvent, disableEvent;
    Public float holdTime;
    
    
    private void Awake()
    {
        awakeEvent.Invoke();
    }

    private void Start()
    {
        startEvent.Invoke();
    }

    private void OnEnable()
    {
        onEnableEvent.Invoke();
    }

    private void OnDisable()
    {
        disableEvent.Invoke();
    }
	
    private OnClick()
    {
		
    }


    private IEnumerator Start()
    {
        Yield return new WaitForSeconds(holdTime);
        startEvent.Invoke;
    }

}