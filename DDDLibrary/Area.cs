using System;

namespace DDDLibrary
{
    public class Area : IEquatable<Area>
    {
        private const decimal HectareInSquareMeters = 10000;

        private const decimal AcreInSquareMeters = 4046.856422m;

        private const decimal AlqueireDoNorteInSquareMeters = 27000.225m;

        private const decimal AlqueirePaulistaInSquareMeters = 24000.200m;

        private const decimal AlqueireMineiroInSquareMeters = 48000.400m;

        private readonly decimal _squareMeters;

        private Area(decimal squareMeteres)
        {
            _squareMeters = squareMeteres;
        }

        public static Area FromSquareMeters(decimal squareMeters)
        {
            return new Area(squareMeters);
        }

        public static Area FromHectares(decimal hectares)
        {
            return new Area(hectares * HectareInSquareMeters);
        }

        public static Area FromAcres(decimal acres)
        {
            return new Area(acres * AcreInSquareMeters);
        }

        public static Area FromAlqueiresDoNorte(decimal alqueiresDoNorte)
        {
            return new Area(alqueiresDoNorte * AlqueireDoNorteInSquareMeters);
        }

        public static Area FromAlqueiresPaulista(decimal alqueiresPaulista)
        {
            return new Area(alqueiresPaulista * AlqueirePaulistaInSquareMeters);
        }

        public static Area FromAlqueiresMineiro(decimal alqueiresMineiro)
        {
            return new Area(alqueiresMineiro * AlqueireMineiroInSquareMeters);
        }

        public bool Equals(Area other)
        {
            if (other == null)
                return false;

            if (ReferenceEquals(this, other))
                return true;

            return InSquareMeters().Equals(other.InSquareMeters());
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (ReferenceEquals(this, obj))
                return false;

            var area = obj as Area;

            return area != null && Equals(area);
        }

        public override int GetHashCode()
        {
            return _squareMeters.GetHashCode();
        }

        public static bool operator ==(Area left, Area right)
        {
            return Equals(left, null) ? (Equals(right, null)) : left.Equals(right);
        }

        public static bool operator !=(Area left, Area right)
        {
            return !(left == right);
        }

        public static Area operator +(Area area1, Area area2)
        {
            return FromSquareMeters(area1.InSquareMeters() + area2.InSquareMeters());
        }
        public static Area operator +(Area area, decimal squareMeters)
        {
            return FromSquareMeters(area.InSquareMeters() + squareMeters);
        }

        public static Area operator -(Area area, Area area2)
        {
            return FromSquareMeters(area.InSquareMeters() - area2.InSquareMeters());
        }

        public static Area operator -(Area area, decimal squareMeters)
        {
            return FromSquareMeters(area.InSquareMeters() - squareMeters);
        }

        public static Area operator *(Area area, Area area2)
        {
            return FromSquareMeters(area.InSquareMeters() * area2.InSquareMeters());
        }

        public static Area operator *(Area area, decimal multiplier)
        {
            return FromSquareMeters(area.InSquareMeters() * multiplier);
        }

        public static Area operator /(Area area, Area area2)
        {
            return FromSquareMeters(area.InSquareMeters() / area2.InSquareMeters());
        }

        public static Area operator /(Area area, decimal divider)
        {
            return FromSquareMeters(area.InSquareMeters() / divider);
        }

        public decimal InSquareMeters()
        {
            return _squareMeters;
        }

        public decimal InHectares()
        {
            return _squareMeters / HectareInSquareMeters;
        }

        public decimal InAcres()
        {
            return _squareMeters / AcreInSquareMeters;
        }

        public decimal InAlqueiresDoNorte()
        {
            return _squareMeters / AlqueireDoNorteInSquareMeters;
        }

        public decimal InAlqueiresPaulista()
        {
            return _squareMeters / AlqueirePaulistaInSquareMeters;
        }

        public decimal InAlqueiresMineiro()
        {
            return _squareMeters / AlqueireMineiroInSquareMeters;
        }
    }
}
