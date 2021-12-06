using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameRuler : MonoBehaviour
{
    [SerializeField] private Arrow arrow1;
    [SerializeField] private int numberOfStart = 5;

    public UnityEvent winEvent;
    public UnityEvent loseEvent;



    public void StartGame()
    {
      
     
    }

    public void StopGame()
    {

        if (arrow1.collidedObject.GetComponent<Cell>().Value % 2 == 0) winEvent?.Invoke();
        else loseEvent?.Invoke();

    }

    private IEnumerator StopMachineCor()
    {
        yield break;
    }
}
