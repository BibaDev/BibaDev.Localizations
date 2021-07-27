using TMPro;
using UnityEngine;

/*
 * Created by BibaDev: (https://biba.dev)
 * Contact me: https://biba.dev/feedback
 * Follow me: https://twitter.com/BibaDevOfficial
 * GitHub: https://github.com/BibaDev/BibaDev.Localizations
 */
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
