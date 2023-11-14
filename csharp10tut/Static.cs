class Circle
{
    static float _PI;
    int _Radius;

    static Circle()
    {
        Circle._PI = 3.142f;
    }

    public Circle(int Radius)
    {
        this._Radius = Radius;
    }

    public float Area()
    {
        return _PI * this._Radius * this._Radius;
    }

    public static void Print() { }

    static void main()
    {
        Circle C1 = new Circle(4);
        System.Console.WriteLine("Area : {0} units", C1.Area());
    }
}
