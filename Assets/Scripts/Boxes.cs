using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;

public class Boxes : MonoBehaviour
{
    public float _stepLength, _stepDuration;
    public Button _pressedButton;
    private Vector3 positionX;

    public void MoveOneStepRight()
    {
        //call text to change
        GameObject.FindFirstObjectByType<NewSentence>().nowTextPlusOne();

        var stepVelocity = -_stepLength / _stepDuration;
        var newPosition = transform.position + _stepLength * Vector3.right;
        StartCoroutine(MovingStepRoutine(stepVelocity, newPosition));
        Debug.Log("Moved +1 Step");
    }
    public void MoveOneStepLeft()
    {
        //call text to change
        GameObject.FindFirstObjectByType<NewSentence>().nowTextMinusOne();

        var stepVelocity = _stepLength / _stepDuration;
        var newPosition = transform.position + _stepLength * Vector3.left;
        StartCoroutine(MovingStepRoutine(stepVelocity, newPosition));
        Debug.Log("Moved -1 Step");
    }
    IEnumerator MovingStepRoutine(float velocity, Vector3 newPos)
    {
        Debug.Log("Moving Step One");
        bool movedToNewPos = false;
        bool reachedLeftBound = false;
        bool reachedRightBound = true;
        float timer = 0f;

        while (movedToNewPos == false && reachedLeftBound == false)
        {
            transform.Translate(Vector3.right * velocity * Time.deltaTime);
            yield return null;
            timer += Time.deltaTime;
            movedToNewPos = timer >= _stepDuration;
            reachedLeftBound = transform.position.x >= 20.75f;
        }

        while (movedToNewPos == false && reachedRightBound == false)
        {
            transform.Translate(Vector3.left * velocity * Time.deltaTime);
            yield return null;
            timer += Time.deltaTime;
            movedToNewPos = timer >= _stepDuration;
            reachedRightBound = transform.position.x <= -150f;
            Debug.LogError(reachedRightBound);
        }
            _pressedButton.transform.GetComponent<backgroundShift>().ChangeColorBack();
        GameObject.FindFirstObjectByType<NewSentence>().changeToNewText();
        GameObject.FindFirstObjectByType<characterTalking>().TriggerSoundEffect();

    }
}
