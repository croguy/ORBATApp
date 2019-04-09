using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbatAppV01
{
    class UnitGenerator
    {
        UnitDeclarations UnitHandlerFuncs = new UnitDeclarations();
        public UnitGenerator()
        {

        }
        public string OrbatOutput(string unitClassName, int unitID, string unitName, int unitTypeIndex, int unitDisplayIndex, int unitSideIndex, int unitSizeIndex, string unitInsignia, string unitCmdr, int unitRankIndex, string unitSubordinates, string unitDesc)
        {
            string output = $"Class {UnitHandlerFuncs.HandleString(unitClassName)} " +
                $"\r\n{{" +
                $"\r\n    id = {UnitHandlerFuncs.GetUnitID(unitID)};" +
                $"\r\n    idType = {UnitHandlerFuncs.GetIDType(unitTypeIndex)};" +
                $"\r\n    side = \"{UnitHandlerFuncs.GetUnitSide(unitSideIndex)}\";" +
                $"\r\n    size = \"{UnitHandlerFuncs.GetUnitSize(unitSizeIndex)}\";" +
                $"\r\n    type = \"{UnitHandlerFuncs.GetUnitType(unitTypeIndex)}\";" +
                $"\r\n    commander = \"{UnitHandlerFuncs.HandleString(unitCmdr)}\";" +
                $"\r\n    commanderRank = \"{UnitHandlerFuncs.GetCmdrRank(unitRankIndex)}\";" +
                $"\r\n    text = \"{UnitHandlerFuncs.HandleString(unitDesc)}\";" +
                $"\r\n    textShort = \"{UnitHandlerFuncs.HandleString(unitName)}\";" +
                $"\r\n    texture = \"{UnitHandlerFuncs.HandleString(unitInsignia)}\";" +
                $"\r\n    subordinates[] = {{{UnitHandlerFuncs.HandleString(unitSubordinates)}}};" +
                $"\r\n}}";
            return output;
        }
    }
}
