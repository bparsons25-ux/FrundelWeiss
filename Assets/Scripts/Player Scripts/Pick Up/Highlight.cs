using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Highlight : MonoBehaviour
{
    // assigns all of the renderers here through the inspector
    [SerializeField] private List<Renderer> renderers;

    [SerializeField] private Color color = Color.white;

    // creates a list to cache all of the materials of this object
    [SerializeField] private List<Material> materials;

    // gets all of the materials from each object renderer

    private void Awake()
    {
        materials = new List<Material>();
        foreach (var renderer in renderers)
        {
            // a single child object might have multiple materials attached - therefore this
            materials.AddRange(new List<Material>(renderer.materials));

        }
    }

    public void ToggleHighlight(bool val)
    {
        if (val)
        {
            foreach (var material in materials)
            {
                // enables emission
                material.EnableKeyword("_EMISSION");
                // set the colour
                material.SetColor("_EmissionColour", color);
            }

        }

        else
        {
            foreach (var material in materials)
            {
                // disables the emission when emission colours are not used anywhere else
                material.DisableKeyword("_EMISSION");
            }
        }
    }


}
