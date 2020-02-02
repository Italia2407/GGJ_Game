using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoundPiece : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer icon;

    public Color foundColour = new Color(0, 255, 0);
    public Color missingColour = new Color(255, 0, 0);

    public bool MedOrSim;

    private void Start()
    {
        if (MedOrSim)
        {
            if (FoundPiecesData.Medieval)
            {
                icon.color = foundColour;
            }
            else
                icon.color = missingColour;
        }
        else
        {
            if (FoundPiecesData.SimonSays)
            {
                icon.color = foundColour;
            }
            else
                icon.color = missingColour;
        }
    }
}
