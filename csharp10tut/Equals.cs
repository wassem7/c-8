class Equals
{

    static void Main()
    {
        Pupil P1 = new Pupil();
        P1.FirstName = "Kwame";
        P1.LastName = "Darkwa";

        Pupil P2 = new Pupil();
        P2.FirstName = "Kmwame";
        P2.LastName = "Darkwa";

        Console.WriteLine(P1.Equals(P2));

    }

    class Pupil
    {
        public string FirstName;
        public string LastName;

        public override bool Equals(object? obj)
        {
           if (obj == null)
            {
                return false;
            }

           if (!(obj is Pupil))
            {
                return false;
            }

            return this.FirstName == ((Pupil)obj).FirstName && this.LastName == ((Pupil)obj).LastName;
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }
    }

   
}