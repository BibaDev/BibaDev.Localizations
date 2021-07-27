using UnityEngine;
using UnityEngine.UI;

/*
 * Created by BibaDev: (https://biba.dev)
 * Contact me: https://biba.dev/feedback
 * Follow me: https://twitter.com/BibaDevOfficial
 * GitHub: https://github.com/BibaDev/BibaDev.Localizations
 */
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
