namespace ConsoleApplicationRepetitionInheritance
{
    public interface IBil
    {
        double BilPrisExAfgift { get; set; }
        double KøbsÅr { get; set; }
        string Mærke { get; set; }
        string RegistreringsNr { get; set; }
        int KmPrLiter { get; set; }
        double afgift105 { get; set; }
        double afgidt180 { get; set; }
        int Tank { get; set; }
        double RegistreringsAfgift();
        double TotalPris();
        double HalvÅrligEjerafgift();
        int Rækkevidde();
    }
}