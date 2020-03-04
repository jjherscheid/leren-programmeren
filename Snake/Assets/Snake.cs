using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Snake : MonoBehaviour
{
    Vector2 richting = Vector2.right;
    List<Transform> staartstukjes = new List<Transform>();
    bool gegeten = false;
    float snelheid = 0.3f;
    
    public GameObject staartPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(nameof(BeweegLus));
        InvokeRepeating(nameof(VerhoogSnelheid), 1, 10);
    }

    void VerhoogSnelheid()
    {
        this.snelheid = this.snelheid * 0.8f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) && richting != Vector2.left)
            richting = Vector2.right;
        else if (Input.GetKey(KeyCode.LeftArrow) && richting != Vector2.right)
            richting = Vector2.left;
        else if (Input.GetKey(KeyCode.UpArrow) && richting != Vector2.down)
            richting = Vector2.up;
        else if (Input.GetKey(KeyCode.DownArrow) && richting != Vector2.up)
            richting = Vector2.down;
    }

    void Beweeg()
    {
        // We slaan eerst de vorige positie van het hoofd op
        Vector2 vorigePositieHoofd = transform.position;

        // Nu bewegen we het hoofd (en ontstaat er een gat als we een staart hebben)
        transform.Translate(richting);

        // Heeft Snake gegeten? Dan moeten we extra stukje staart maken
        if(gegeten)
        {
            // Stuke staart inladen in het spel en op de vorige postitie
            // van het hoofd neerzetten
            GameObject staart = (GameObject)Instantiate(
                staartPrefab,
                vorigePositieHoofd,
                Quaternion.identity);

            // Ook het stukje toevoegen aan de lijst met staart stukjes
            staartstukjes.Insert(0, staart.transform);

            // En weer laten weten dat Snake weer kan eten
            gegeten = false;
        }
        // Controleren of we een staart hebben
        else if (staartstukjes.Any())
        {
            // Pak het laatste staartstukje en geef het de positie waar het hoofd was
            staartstukjes.Last().position = vorigePositieHoofd;

            // Zet het laatste stukje in de lijst als eerste in de lijst
            staartstukjes.Insert(0, staartstukjes.Last());

            // Haal het staartstukje aan het einde weg
            staartstukjes.RemoveAt(staartstukjes.Count - 1);
        }
    }

    IEnumerator BeweegLus()
    {
        while(true)
        {
            yield return new WaitForSeconds(snelheid);
            Beweeg();
        }
    }

    private void OnTriggerEnter2D(Collider2D gebotstMet)
    {
        // Is Snake gebotst met FoodPrefab
        if (gebotstMet.name.StartsWith("FoodPrefab"))
        {
            // Snake heeft gegeten
            this.gegeten = true;

            // Het eten weghalen uit het spel
            Destroy(gebotstMet.gameObject);
        }
        else
        {
            // Je bent met iets anders gebotst.. 
            Time.timeScale = 0; // Stop het spel
        }
    }
}
