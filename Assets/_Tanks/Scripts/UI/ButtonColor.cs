using UnityEngine;
using UnityEngine.UI;

public class ButtonColor : MonoBehaviour
{
    public ChangeTankColor colorPanel;

    public void OnClickChangeColor()
    {
        colorPanel.ChangeColor(transform.GetComponent<Image>().color);
    }
}
