using System;

namespace Api_Mongo.Data.Collections
{
    public class infectado
    {
        public infectado(DateTime dataNascimento, string sexo, double latitude, double longitude)
        {
            this.DataNascimento = dataNascimento;
            this.Sexo = sexo;
            this.Localizacao = new GeoJson2dGeographicCoordinates(longitude, latitude);

        }

        public DateTime DataNascimento {get; set;}

        public string Sexo {get; set;}

        public GeoJson2dGeographicCoordinates Localizacao {get; set;}



    }
}