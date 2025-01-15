namespace Test2;

public class BaterieExterna
{
    int _SarcinaCurenta;
    int _SarcinaMaxima;

    public int SarcinaCurenta
    {
        get { return _SarcinaCurenta; }
        set {  _SarcinaCurenta = value;}
    }

    public int SarcinaMaxima
    {
        get { return _SarcinaMaxima; }
    }
    public BaterieExterna()
    {
        _SarcinaCurenta = 10000;
        _SarcinaMaxima = 10000;
    }
    public void IncarcaDispozitiv(int consum)
    {
        _SarcinaCurenta -= consum;
        if (_SarcinaCurenta < 0)
        {
            _SarcinaCurenta = 0;
        }
    }

    //public int GetSarcinaMaxima()
    //{
    //    return SarcinaMaxima; 
    //}

    //public int GetSarcinaCurenta()
    //{
    //    return _SarcinaCurenta;
    //}
}