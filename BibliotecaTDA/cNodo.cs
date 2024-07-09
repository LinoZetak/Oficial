namespace BibliotecaTDA
{
    public class cNodo
    {
        // atributos
        private object aElemento; // Elemento
        private cNodo aEnlace; // Sgt Nodo

        // constructores 
        public cNodo()
        {
            aElemento = null;
            aEnlace = null;
        }
        public cNodo(object pInformacion)
        {
            
            
            aElemento = pInformacion;
            aEnlace = null;
            
        }
        public cNodo(object pInformacion, cNodo pEnlace)
        {
            if (aElemento != null && pEnlace != null)
            {
                aElemento = pInformacion;
                aEnlace = pEnlace;
            }
        }
        // Propiedades 
        public object Elemento
        {
            get { return aElemento; }
            set { aElemento = value; }
        }

        public cNodo Enlace
        {
            get { return aEnlace; }
            set { aEnlace = value; }
        }

        public Boolean EsVacio()
        {
            return ((aElemento != null) && (aEnlace != null));
        }
    }
}