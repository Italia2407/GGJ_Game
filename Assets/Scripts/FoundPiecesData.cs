using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class FoundPiecesData
{
    private static bool medievalPiece = false;
    private static bool simonSaysPiece = false;

    public static bool Medieval { get => medievalPiece; }
    public static bool SimonSays { get => simonSaysPiece; }

    public static void MedievalFound() { medievalPiece = true; }
    public static void SimonSaysFound() { simonSaysPiece = true; }
}