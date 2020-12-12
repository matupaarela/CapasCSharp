namespace Common.Helpers
{
    public struct Error
    {
        public const string Store = "Hemos tenido problemas al guardar el(los) registro(s)";
        public const string Show = "Hemos tenido problemas al cargar los registros";
        public const string Destroy = "Hemos tenido problemas al eliminar el registro";
        public const string Duplicate = "El registro ingresado ya existe";
        public const string Void = "Sin cambios";

        public const string NewRow = "Hemos tenido problemas para agregar una nueva fila";
        public const string Format = "Hemos tenido problemas para formatear los datos";

        public const string PleRoute = "Hemos tenido problemas para encontrar la ruta especificada";
        public const string PleGenerate = "Hemos tenido problemas para generar los libros electronicos (PLE)";

        public const string Import = "Hemos tenido problemas al importar los registros";
        public const string ImportRuc = "El ruc del archivo seleccionado no corresponde a la empresa actual";
        public const string LoadForm = "Hemos tenido problemas al abrir el formulario";
        
        public const string Period = "Hemos tenido problemas al definir un periodo";

        //Validaciones
        public const string Value = "El valor ingresado no es correcto";
        public const string Negative = "Solo se aceptan valores numericos negativos";
        public const string Positive = "Solo se aceptan valores numericos positivos";
        public const string OlderDate = "La fecha ingresada debe de ser menor o igual a la fecha actual";
        public const string LengthRuc = "El ruc debe de ser numerico y de 11 dígitos";

    }
}
