using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbatAppV01
{
    class UnitDeclarations
    {
        public string HandleString(string inputLine)
        {
            return inputLine;
        }

        public string GetUnitID (int idValue)
        {
            return idValue.ToString();
        }

        public string GetIDType(int idType)
        {
            string selectedValue = null;
            switch(idType)
            {
                default:
                    selectedValue = "0";
                    break;
                case 0: //ordinal
                    selectedValue = "0";
                    break;
                case 1: //roman
                    selectedValue = "1";
                    break;
                case 2: //NATO
                    selectedValue = "2";
                    break;
                case 3: //Color
                    selectedValue = "3";
                    break;
            }
            return selectedValue;
        }

        public string GetUnitSide (int sideIndex)
        {
            string selectedValue = null;
            switch(sideIndex)
            {
                default:
                    selectedValue = "unknown";
                    break;
                case 0: //blufor
                    selectedValue = "west";
                    break;
                case 1: //opfor
                    selectedValue = "east";
                    break;
                case 2: //independent
                    selectedValue = "resistance";
                    break;
                case 3: //civilian
                    selectedValue = "civilian";
                    break;
                case 4: //unknown
                    selectedValue = "unknown";
                    break;
            }
            return selectedValue;
        }

        public string GetUnitSize(int sizeIndex)
        {
            string selectedValue = null;
            switch(sizeIndex)
            {
                default:
                    selectedValue = "";
                    break;
                case 0:
                    selectedValue = "FireTeam";
                    break;
                case 1:
                    selectedValue = "Squad";
                    break;
                case 2:
                    selectedValue = "Platoon";
                    break;
                case 3:
                    selectedValue = "Company";
                    break;
                case 4:
                    selectedValue = "Battalion";
                    break;
                case 5:
                    selectedValue = "Brigade";
                    break;
                case 6:
                    selectedValue = "Division";
                    break;
                case 7:
                    selectedValue = "Corps";
                    break;
                case 8:
                    selectedValue = "Army";
                    break;
                case 9:
                    selectedValue = "ArmyGroup";
                    break;
                case 10:
                    selectedValue = "";
                    break;
            }
            return selectedValue;
        }
        
        public string GetUnitType(int unitType)
        {
            string selectedValue = null;
            switch(unitType)
            {
                default:
                    selectedValue = "Unknown";
                    break;
                case 0:
                    selectedValue = "Airborne";
                    break;
                case 1:
                    selectedValue = "Armored";
                    break;
                case 2:
                    selectedValue = "Artillery";
                    break;
                case 3:
                    selectedValue = "Fighter";
                    break;
                case 4:
                    selectedValue = "Helicopter";
                    break;
                case 5:
                    selectedValue = "HQ";
                    break;
                case 6:
                    selectedValue = "Infantry";
                    break;
                case 7:
                    selectedValue = "Maintenance";
                    break;
                case 8:
                    selectedValue = "Maritime";
                    break;
                case 9:
                    selectedValue = "MechanizedInfantry";
                    break;
                case 10:
                    selectedValue = "Medical";
                    break;
                case 11:
                    selectedValue = "Mortar";
                    break;
                case 12:
                    selectedValue = "MotorizedInfantry";
                    break;
                case 13:
                    selectedValue = "Recon";
                    break;
                case 14:
                    selectedValue = "Service";
                    break;
                case 15:
                    selectedValue = "Support";
                    break;
                case 16:
                    selectedValue = "UAV";
                    break;
                case 17:
                    selectedValue = "Unknown";
                    break;
            }
            return selectedValue;
        }
        
        public string GetCmdrRank(int cmdrRank)
        {
            string selectedValue = null;
            switch(cmdrRank)
            {
                default:
                    selectedValue = "SERGEANT";
                    break;
                case 0:
                    selectedValue = "PRIVATE";
                    break;
                case 1:
                    selectedValue = "CORPORAL";
                    break;
                case 2:
                    selectedValue = "SERGEANT";
                    break;
                case 3:
                    selectedValue = "LIEUTENANT";
                    break;
                case 4:
                    selectedValue = "CAPTAIN";
                    break;
                case 5:
                    selectedValue = "MAJOR";
                    break;
                case 6:
                    selectedValue = "COLONEL";
                    break;
                case 7:
                    selectedValue = "GENERAL";
                    break;
            }
            return selectedValue;
        }
    }
}
