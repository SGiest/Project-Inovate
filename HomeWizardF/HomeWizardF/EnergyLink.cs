namespace HomeWizardF
{
    //  Martin Beekhuizen
    /// <summary>
    /// Energy link class to get/set data retrieved from the url homwizard/password/enlist.
    /// </summary>
    
    public class Energylink
{
    public int id { get; set; }
    public string favorite { get; set; }
    public string name { get; set; }
    public string code { get; set; }
    public string t1 { get; set; }
    public int c1 { get; set; }
    public string t2 { get; set; }
    public int c2 { get; set; }
    public object tariff { get; set; }
    //public S1 s1 { get; set; }
    public object s2 { get; set; }
    //public Aggregate aggregate { get; set; }
    //public Used used { get; set; }
    public object gas { get; set; }
    public double kwhindex { get; set; }
    public int wp { get; set; }




    }
}
