using TMPro;
using UnityEngine;

namespace BibaDev.Localizations
{
    
    [RequireComponent(typeof(TextMeshProUGUI))]
    [AddComponentMenu("BibaDev/Localization/TextMeshPro Localizer")]
    public class TMPLocalizer : MonoBehaviour
    {

        [SerializeField] private string _key;

        private void Start()
        {
            
            GetComponent<TextMeshProUGUI>().text = Localization.General.Get(in _key);
            
        } 
        
    }
    
}
