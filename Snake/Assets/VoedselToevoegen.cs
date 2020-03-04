using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoedselToevoegen : MonoBehaviour
{
    // Voor het eten
    public GameObject foodPrefab;

    // De randen van het spel
    public Transform borderTop;
    public Transform borderBottom;
    public Transform borderLeft;
    public Transform borderRight;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(EtenMaken), 3, 4);
    }

    void EtenMaken()
    {
        // Positie van links en rechts
        var linkerRandX = borderLeft.position.x;
        var rechterRandX = borderRight.position.x;

        // Willekeurige positie tussen links en rechts
        var etenX = (int)Random.Range(linkerRandX, rechterRandX);

        // Positie van boven en onder
        var bovenRandY = borderTop.position.y;
        var onderRandY = borderBottom.position.y;

        // Willekeurige positie tussen boven en onder
        var etenY = (int)Random.Range(bovenRandY, onderRandY);

        // Aanmaken eten
        Instantiate(foodPrefab, new Vector2(etenX, etenY), Quaternion.identity);
    }
}
