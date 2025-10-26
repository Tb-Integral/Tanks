using Tanks.Complete;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTankColor : MonoBehaviour
{
    public StartMenuSlot m_MenuSlot;

    public void ChangeColor(Color newColor)
    {
        m_MenuSlot.m_SlotColor = newColor;

        MeshRenderer[] meshRenderers = m_MenuSlot.TankPreview.GetComponentsInChildren<MeshRenderer>();
        foreach (var renderer in meshRenderers)
        {
            var mats = renderer.materials;
            for (int i = 0; i < mats.Length; i++)
            {
                if (mats[i] != null && mats[i].name.Contains("TankColor"))
                {
                    mats[i].color = newColor;
                }
            }

            renderer.materials = mats;
        }

        gameObject.SetActive(false);
    }
}
