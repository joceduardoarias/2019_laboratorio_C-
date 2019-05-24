using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
   public class PlacaVideo:Periferico
    {
        private int ramMB;

        #region CONSTRUCTOR
        public PlacaVideo(string marca,string modelo, int ramMB):base(marca,modelo,EConector.PCIexpress)
        {
            this.ramMB = ramMB;
        }
        #endregion

        #region METODOS
        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ramMB:" + this.ramMB);
            sb.AppendLine((string)this);
            return sb.ToString();
        }

        #endregion
    }
}
