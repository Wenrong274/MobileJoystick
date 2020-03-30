using UnityEngine;
using UnityEngine.EventSystems;
public class JoystickButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool pressed;

    public bool Pressed
    {
        get { return pressed; }
    }

    #region IPointerDownHandler Member
    public void OnPointerDown(PointerEventData eventData)
    {
        pressed = true;
    }
    #endregion 

    #region IPointerUpHandler Member
    public void OnPointerUp(PointerEventData eventData)
    {
        pressed = false;
    }
    #endregion
}
