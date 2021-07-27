using UnityEngine;
using UnityEngine.UI;

namespace BibaDev.Localizations
{
    
    [RequireComponent(typeof(Text))]
    [AddComponentMenu("BibaDev/Localization/Text Localizer")]
    public class TextLocalizer : MonoBehaviour
    {

        [SerializeField] private string _key;
        
        private void Start()
        {
            
            GetComponent<Text>().text = Localization.General.Get(in _key);
            
        } 
        
    }

}
