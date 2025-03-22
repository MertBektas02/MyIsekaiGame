using UnityEngine;
using UnityEngine.UI;

public class Planet1 : MonoBehaviour
{
    [SerializeField] private GameObject planet1;
    private PlanetStats currentPlanet;
    [SerializeField]private Button button;

    void Start()
    {
        if(button != null)
        {
            button.onClick.AddListener(OnButtonCheck); // Butona tıklandığında OnButtonCheck fonksiyonunu çalıştır
        }
    }
    
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject==planet1.gameObject)
        {
            PlanetStats currentPlanet = planet1.GetComponent<PlanetStats>();

            
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject==planet1)
        {
            Debug.Log("planet1 çıktı.");
            currentPlanet=null;
        }
    }

    public void OnButtonCheck()
    {
        if (currentPlanet != null)
        {
            Debug.Log($"Seçilen gezegenle işlem yapılıyor: {currentPlanet}");
            // Burada currentPlanet ile işlem yapabilirsiniz
        }
        else
        {
            Debug.LogError("Henüz bir gezegen seçilmedi!");
        }
    }

}
