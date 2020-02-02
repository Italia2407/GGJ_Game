using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedievalPieceFound : HubLevelLoader
{
    public override void Interact()
    {
        FoundPiecesData.MedievalFound();
        base.Interact();
    }
}
