using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Epithet_Erased_System.Types
{
    public class CharacterSheet_AnimeCampaign
    {
        public CharacterSheet_AnimeCampaign()
        {

        }

        public int SheetID;
        public string TabName;
        public string SheetAuthor;
        public string DateCreated; //May need to change from string later

        public Brush RibbonColor;
        //public x RibbonIcon;
        //public y 


        public Brush Stat1_Stroke;
        public Brush Stat1_Foreground;
        public string Stat1_Text;
        
        public Brush Stat2_Stroke;
        public Brush Stat2_Foreground;
        public string Stat2_Text;
        
        public Brush Stat3_Stroke;
        public Brush Stat3_Foreground;
        
        public string Stat3_Text;
        public Brush Stat4_Stroke;
        public Brush Stat4_Foreground;
        public string Stat4_Text;
    }
}
