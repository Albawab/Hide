namespace HenE.Aeolus.Shared.Permissions
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public enum Permission : ushort
    {
        // NotSet: Error Condition
        NotSet = PermissionGroup.Overzichten_Algemeen | 0x0000,

        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwaanvragenwwb", Description = "Kan Vwaanvragenwwb Opvragen")]
        Overzichten_Alg_Vwaanvragenwwb = PermissionGroup.Overzichten_Algemeen | 0x0001,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwaanvrapport", Description = "Kan Vwaanvrapport Opvragen")]
        Overzichten_Alg_Vwaanvrapport = PermissionGroup.Overzichten_Algemeen | 0x0002,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwactiefvervoer", Description = "Kan Vwactiefvervoer Opvragen")]
        Overzichten_Alg_Vwactiefvervoer = PermissionGroup.Overzichten_Algemeen | 0x0003,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwactivfacturendoel", Description = "Kan Vwactivfacturendoel Opvragen")]
        Overzichten_Alg_Vwactivfacturendoel = PermissionGroup.Overzichten_Algemeen | 0x0004,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwactiviteitenpp", Description = "Kan Vwactiviteitenpp Opvragen")]
        Overzichten_Alg_Vwactiviteitenpp = PermissionGroup.Overzichten_Algemeen | 0x0005,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwactueledossiers", Description = "Kan Vwactueledossiers Opvragen")]
        Overzichten_Alg_Vwactueledossiers = PermissionGroup.Overzichten_Algemeen | 0x0006,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwactueletrajecten", Description = "Kan Vwactueletrajecten Opvragen")]
        Overzichten_Alg_Vwactueletrajecten = PermissionGroup.Overzichten_Algemeen | 0x0007,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwarbeidsgeschiktheid", Description = "Kan Vwarbeidsgeschiktheid Opvragen")]
        Overzichten_Alg_Vwarbeidsgeschiktheid = PermissionGroup.Overzichten_Algemeen | 0x0008,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwarbeidverpl2012", Description = "Kan Vwarbeidverpl2012 Opvragen")]
        Overzichten_Alg_Vwarbeidverpl2012 = PermissionGroup.Overzichten_Algemeen | 0x0009,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwarbeidverpl", Description = "Kan Vwarbeidverpl Opvragen")]
        Overzichten_Alg_Vwarbeidverpl = PermissionGroup.Overzichten_Algemeen | 0x000A,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwbeeindigdevoorzjeugd", Description = "Kan Vwbeeindigdevoorzjeugd Opvragen")]
        Overzichten_Alg_Vwbeeindigdevoorzjeugd = PermissionGroup.Overzichten_Algemeen | 0x000B,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwbeeindigdevoorzzorg", Description = "Kan Vwbeeindigdevoorzzorg Opvragen")]
        Overzichten_Alg_Vwbeeindigdevoorzzorg = PermissionGroup.Overzichten_Algemeen | 0x000C,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwberichtenaeolus", Description = "Kan Vwberichtenaeolus Opvragen")]
        Overzichten_Alg_Vwberichtenaeolus = PermissionGroup.Overzichten_Algemeen | 0x000D,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwberoepen", Description = "Kan Vwberoepen Opvragen")]
        Overzichten_Alg_Vwberoepen = PermissionGroup.Overzichten_Algemeen | 0x000E,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwbeslissingdebi", Description = "Kan Vwbeslissingdebi Opvragen")]
        Overzichten_Alg_Vwbeslissingdebi = PermissionGroup.Overzichten_Algemeen | 0x000F,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwbeslissingjeugd", Description = "Kan Vwbeslissingjeugd Opvragen")]
        Overzichten_Alg_Vwbeslissingjeugd = PermissionGroup.Overzichten_Algemeen | 0x0010,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwbeslissingrecht", Description = "Kan Vwbeslissingrecht Opvragen")]
        Overzichten_Alg_Vwbeslissingrecht = PermissionGroup.Overzichten_Algemeen | 0x0011,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwbeslissingzorg", Description = "Kan Vwbeslissingzorg Opvragen")]
        Overzichten_Alg_Vwbeslissingzorg = PermissionGroup.Overzichten_Algemeen | 0x0012,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwbetalingproduct", Description = "Kan Vwbetalingproduct Opvragen")]
        Overzichten_Alg_Vwbetalingproduct = PermissionGroup.Overzichten_Algemeen | 0x0013,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwbetenontv", Description = "Kan Vwbetenontv Opvragen")]
        Overzichten_Alg_Vwbetenontv = PermissionGroup.Overzichten_Algemeen | 0x0014,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwbijzbijproducten", Description = "Kan Vwbijzbijproducten Opvragen")]
        Overzichten_Alg_Vwbijzbijproducten = PermissionGroup.Overzichten_Algemeen | 0x0015,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwcaseloadperklantmanager", Description = "Kan Vwcaseloadperklantmanager Opvragen")]
        Overzichten_Alg_Vwcaseloadperklantmanager = PermissionGroup.Overzichten_Algemeen | 0x0016,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwclientenoverleden", Description = "Kan Vwclientenoverleden Opvragen")]
        Overzichten_Alg_Vwclientenoverleden = PermissionGroup.Overzichten_Algemeen | 0x0017,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwcontrbudg", Description = "Kan Vwcontrbudg Opvragen")]
        Overzichten_Alg_Vwcontrbudg = PermissionGroup.Overzichten_Algemeen | 0x0018,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwcontrolecak", Description = "Kan Vwcontrolecak Opvragen")]
        Overzichten_Alg_Vwcontrolecak = PermissionGroup.Overzichten_Algemeen | 0x0019,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwcontrolefactpainjourn", Description = "Kan Vwcontrolefactpainjourn Opvragen")]
        Overzichten_Alg_Vwcontrolefactpainjourn = PermissionGroup.Overzichten_Algemeen | 0x001A,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwcontroleperbet", Description = "Kan Vwcontroleperbet Opvragen")]
        Overzichten_Alg_Vwcontroleperbet = PermissionGroup.Overzichten_Algemeen | 0x001B,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwdossierstatdoel", Description = "Kan Vwdossierstatdoel Opvragen")]
        Overzichten_Alg_Vwdossierstatdoel = PermissionGroup.Overzichten_Algemeen | 0x001C,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwdubadressen", Description = "Kan Vwdubadressen Opvragen")]
        Overzichten_Alg_Vwdubadressen = PermissionGroup.Overzichten_Algemeen | 0x001D,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwdubbeledossiers", Description = "Kan Vwdubbeledossiers Opvragen")]
        Overzichten_Alg_Vwdubbeledossiers = PermissionGroup.Overzichten_Algemeen | 0x001E,
        [Display(GroupName = "Overzichten_Algemeen", Name = "VweenmoverdrawbzAlg", Description = "Kan VweenmoverdrawbzAlg Opvragen")]
        Overzichten_Alg_VweenmoverdrawbzAlg = PermissionGroup.Overzichten_Algemeen | 0x001F,
        [Display(GroupName = "Overzichten_Algemeen", Name = "VweenmoverdrawbzC", Description = "Kan VweenmoverdrawbzC Opvragen")]
        Overzichten_Alg_VweenmoverdrawbzC = PermissionGroup.Overzichten_Algemeen | 0x0020,
        [Display(GroupName = "Overzichten_Algemeen", Name = "VweenmoverdrawbzG", Description = "Kan VweenmoverdrawbzG Opvragen")]
        Overzichten_Alg_VweenmoverdrawbzG = PermissionGroup.Overzichten_Algemeen | 0x0021,
        [Display(GroupName = "Overzichten_Algemeen", Name = "VweenmoverdrjeugdAlg", Description = "Kan VweenmoverdrjeugdAlg Opvragen")]
        Overzichten_Alg_VweenmoverdrjeugdAlg = PermissionGroup.Overzichten_Algemeen | 0x0022,
        [Display(GroupName = "Overzichten_Algemeen", Name = "VweenmoverdrjeugdLev", Description = "Kan VweenmoverdrjeugdLev Opvragen")]
        Overzichten_Alg_VweenmoverdrjeugdLev = PermissionGroup.Overzichten_Algemeen | 0x0023,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vweigenbijdragecak", Description = "Kan Vweigenbijdragecak Opvragen")]
        Overzichten_Alg_Vweigenbijdragecak = PermissionGroup.Overzichten_Algemeen | 0x0024,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwexterneadviezen", Description = "Kan Vwexterneadviezen Opvragen")]
        Overzichten_Alg_Vwexterneadviezen = PermissionGroup.Overzichten_Algemeen | 0x0025,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwfactuurregelsalg", Description = "Kan Vwfactuurregelsalg Opvragen")]
        Overzichten_Alg_Vwfactuurregelsalg = PermissionGroup.Overzichten_Algemeen | 0x0026,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwfactuurregelsdoel", Description = "Kan Vwfactuurregelsdoel Opvragen")]
        Overzichten_Alg_Vwfactuurregelsdoel = PermissionGroup.Overzichten_Algemeen | 0x0027,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwfactuurregelszorg", Description = "Kan Vwfactuurregelszorg Opvragen")]
        Overzichten_Alg_Vwfactuurregelszorg = PermissionGroup.Overzichten_Algemeen | 0x0028,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwhbhper4weken", Description = "Kan Vwhbhper4weken Opvragen")]
        Overzichten_Alg_Vwhbhper4weken = PermissionGroup.Overzichten_Algemeen | 0x0029,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwhbhperjaar", Description = "Kan Vwhbhperjaar Opvragen")]
        Overzichten_Alg_Vwhbhperjaar = PermissionGroup.Overzichten_Algemeen | 0x002A,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwheronderzoek", Description = "Kan Vwheronderzoek Opvragen")]
        Overzichten_Alg_Vwheronderzoek = PermissionGroup.Overzichten_Algemeen | 0x002B,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwhhfinancien", Description = "Kan Vwhhfinancien Opvragen")]
        Overzichten_Alg_Vwhhfinancien = PermissionGroup.Overzichten_Algemeen | 0x002C,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwhhfraudebron", Description = "Kan Vwhhfraudebron Opvragen")]
        Overzichten_Alg_Vwhhfraudebron = PermissionGroup.Overzichten_Algemeen | 0x002D,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwhhhuisbezoeken", Description = "Kan Vwhhhuisbezoeken Opvragen")]
        Overzichten_Alg_Vwhhhuisbezoeken = PermissionGroup.Overzichten_Algemeen | 0x002E,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwhhverzorging", Description = "Kan Vwhhverzorging Opvragen")]
        Overzichten_Alg_Vwhhverzorging = PermissionGroup.Overzichten_Algemeen | 0x002F,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwhistoriewerkvoorr", Description = "Kan Vwhistoriewerkvoorr Opvragen")]
        Overzichten_Alg_Vwhistoriewerkvoorr = PermissionGroup.Overzichten_Algemeen | 0x0030,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwhuidigewerkvoorraad", Description = "Kan Vwhuidigewerkvoorraad Opvragen")]
        Overzichten_Alg_Vwhuidigewerkvoorraad = PermissionGroup.Overzichten_Algemeen | 0x0031,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwhuishoudleden", Description = "Kan Vwhuishoudleden Opvragen")]
        Overzichten_Alg_Vwhuishoudleden = PermissionGroup.Overzichten_Algemeen | 0x0032,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwicpp", Description = "Kan Vwicpp Opvragen")]
        Overzichten_Alg_Vwicpp = PermissionGroup.Overzichten_Algemeen | 0x0033,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwict", Description = "Kan Vwict Opvragen")]
        Overzichten_Alg_Vwict = PermissionGroup.Overzichten_Algemeen | 0x0034,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwinactiefvervoer", Description = "Kan Vwinactiefvervoer Opvragen")]
        Overzichten_Alg_Vwinactiefvervoer = PermissionGroup.Overzichten_Algemeen | 0x0035,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwindicaties", Description = "Kan Vwindicaties Opvragen")]
        Overzichten_Alg_Vwindicaties = PermissionGroup.Overzichten_Algemeen | 0x0036,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwindicatieskennisgevingen", Description = "Kan Vwindicatieskennisgevingen Opvragen")]
        Overzichten_Alg_Vwindicatieskennisgevingen = PermissionGroup.Overzichten_Algemeen | 0x0037,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwingezetteproducten", Description = "Kan Vwingezetteproducten Opvragen")]
        Overzichten_Alg_Vwingezetteproducten = PermissionGroup.Overzichten_Algemeen | 0x0038,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwinkafhbijdrage", Description = "Kan Vwinkafhbijdrage Opvragen")]
        Overzichten_Alg_Vwinkafhbijdrage = PermissionGroup.Overzichten_Algemeen | 0x0039,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwinstroomdebi", Description = "Kan Vwinstroomdebi Opvragen")]
        Overzichten_Alg_Vwinstroomdebi = PermissionGroup.Overzichten_Algemeen | 0x003A,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwinstroomdoel", Description = "Kan Vwinstroomdoel Opvragen")]
        Overzichten_Alg_Vwinstroomdoel = PermissionGroup.Overzichten_Algemeen | 0x003B,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwinstroomjeugd", Description = "Kan Vwinstroomjeugd Opvragen")]
        Overzichten_Alg_Vwinstroomjeugd = PermissionGroup.Overzichten_Algemeen | 0x003C,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwinstroomrecht", Description = "Kan Vwinstroomrecht Opvragen")]
        Overzichten_Alg_Vwinstroomrecht = PermissionGroup.Overzichten_Algemeen | 0x003D,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwinstroomzorg", Description = "Kan Vwinstroomzorg Opvragen")]
        Overzichten_Alg_Vwinstroomzorg = PermissionGroup.Overzichten_Algemeen | 0x003E,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwintake", Description = "Kan Vwintake Opvragen")]
        Overzichten_Alg_Vwintake = PermissionGroup.Overzichten_Algemeen | 0x003F,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwintakeverwijderd", Description = "Kan Vwintakeverwijderd Opvragen")]
        Overzichten_Alg_Vwintakeverwijderd = PermissionGroup.Overzichten_Algemeen | 0x0040,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwintakevoorraad", Description = "Kan Vwintakevoorraad Opvragen")]
        Overzichten_Alg_Vwintakevoorraad = PermissionGroup.Overzichten_Algemeen | 0x0041,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwjeugdnaw", Description = "Kan Vwjeugdnaw Opvragen")]
        Overzichten_Alg_Vwjeugdnaw = PermissionGroup.Overzichten_Algemeen | 0x0042,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwjournalisering", Description = "Kan Vwjournalisering Opvragen")]
        Overzichten_Alg_Vwjournalisering = PermissionGroup.Overzichten_Algemeen | 0x0043,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwklantdiagnose", Description = "Kan Vwklantdiagnose Opvragen")]
        Overzichten_Alg_Vwklantdiagnose = PermissionGroup.Overzichten_Algemeen | 0x0044,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwklantgegevens", Description = "Kan Vwklantgegevens Opvragen")]
        Overzichten_Alg_Vwklantgegevens = PermissionGroup.Overzichten_Algemeen | 0x0045,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwklantgesprekresult", Description = "Kan Vwklantgesprekresult Opvragen")]
        Overzichten_Alg_Vwklantgesprekresult = PermissionGroup.Overzichten_Algemeen | 0x0046,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwkostenplaatsen", Description = "Kan Vwkostenplaatsen Opvragen")]
        Overzichten_Alg_Vwkostenplaatsen = PermissionGroup.Overzichten_Algemeen | 0x0047,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwllvproducten", Description = "Kan Vwllvproducten Opvragen")]
        Overzichten_Alg_Vwllvproducten = PermissionGroup.Overzichten_Algemeen | 0x0048,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwloonkostensubsidie", Description = "Kan Vwloonkostensubsidie Opvragen")]
        Overzichten_Alg_Vwloonkostensubsidie = PermissionGroup.Overzichten_Algemeen | 0x0049,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwlvnaw", Description = "Kan Vwlvnaw Opvragen")]
        Overzichten_Alg_Vwlvnaw = PermissionGroup.Overzichten_Algemeen | 0x004A,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwmatrixtotalen", Description = "Kan Vwmatrixtotalen Opvragen")]
        Overzichten_Alg_Vwmatrixtotalen = PermissionGroup.Overzichten_Algemeen | 0x004B,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwnotities", Description = "Kan Vwnotities Opvragen")]
        Overzichten_Alg_Vwnotities = PermissionGroup.Overzichten_Algemeen | 0x004C,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vworganisaties", Description = "Kan Vworganisaties Opvragen")]
        Overzichten_Alg_Vworganisaties = PermissionGroup.Overzichten_Algemeen | 0x004D,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwpgbssvb", Description = "Kan Vwpgbssvb Opvragen")]
        Overzichten_Alg_Vwpgbssvb = PermissionGroup.Overzichten_Algemeen | 0x004E,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwprijsafspraken", Description = "Kan Vwprijsafspraken Opvragen")]
        Overzichten_Alg_Vwprijsafspraken = PermissionGroup.Overzichten_Algemeen | 0x004F,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwproductdefinities", Description = "Kan Vwproductdefinities Opvragen")]
        Overzichten_Alg_Vwproductdefinities = PermissionGroup.Overzichten_Algemeen | 0x0050,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwproductenenbetalingen", Description = "Kan Vwproductenenbetalingen Opvragen")]
        Overzichten_Alg_Vwproductenenbetalingen = PermissionGroup.Overzichten_Algemeen | 0x0051,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwproductenrecht", Description = "Kan Vwproductenrecht Opvragen")]
        Overzichten_Alg_Vwproductenrecht = PermissionGroup.Overzichten_Algemeen | 0x0052,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwproductextravelden", Description = "Kan Vwproductextravelden Opvragen")]
        Overzichten_Alg_Vwproductextravelden = PermissionGroup.Overzichten_Algemeen | 0x0053,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwproductperiodes", Description = "Kan Vwproductperiodes Opvragen")]
        Overzichten_Alg_Vwproductperiodes = PermissionGroup.Overzichten_Algemeen | 0x0054,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwrechtnaw ", Description = "Kan Vwrechtnaw  Opvragen")]
        Overzichten_Alg_Vwrechtnaw = PermissionGroup.Overzichten_Algemeen | 0x0055,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwrekeningnummers", Description = "Kan Vwrekeningnummers Opvragen")]
        Overzichten_Alg_Vwrekeningnummers = PermissionGroup.Overzichten_Algemeen | 0x0056,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwshvafghrapp", Description = "Kan Vwshvafghrapp Opvragen")]
        Overzichten_Alg_Vwshvafghrapp = PermissionGroup.Overzichten_Algemeen | 0x0057,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwshvdemogeg", Description = "Kan Vwshvdemogeg Opvragen")]
        Overzichten_Alg_Vwshvdemogeg = PermissionGroup.Overzichten_Algemeen | 0x0058,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwshvdoorloop", Description = "Kan Vwshvdoorloop Opvragen")]
        Overzichten_Alg_Vwshvdoorloop = PermissionGroup.Overzichten_Algemeen | 0x0059,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwshvgemschuld", Description = "Kan Vwshvgemschuld Opvragen")]
        Overzichten_Alg_Vwshvgemschuld = PermissionGroup.Overzichten_Algemeen | 0x005A,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwshvingezetteproducten", Description = "Kan Vwshvingezetteproducten Opvragen")]
        Overzichten_Alg_Vwshvingezetteproducten = PermissionGroup.Overzichten_Algemeen | 0x005B,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwshvinkomensbronnen", Description = "Kan Vwshvinkomensbronnen Opvragen")]
        Overzichten_Alg_Vwshvinkomensbronnen = PermissionGroup.Overzichten_Algemeen | 0x005C,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwshvoverzklanten", Description = "Kan Vwshvoverzklanten Opvragen")]
        Overzichten_Alg_Vwshvoverzklanten = PermissionGroup.Overzichten_Algemeen | 0x005D,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwshvregelingen", Description = "Kan Vwshvregelingen Opvragen")]
        Overzichten_Alg_Vwshvregelingen = PermissionGroup.Overzichten_Algemeen | 0x005E,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwshvrestrajecten", Description = "Kan Vwshvrestrajecten Opvragen")]
        Overzichten_Alg_Vwshvrestrajecten = PermissionGroup.Overzichten_Algemeen | 0x005F,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwshvtotaantmeld", Description = "Kan Vwshvtotaantmeld Opvragen")]
        Overzichten_Alg_Vwshvtotaantmeld = PermissionGroup.Overzichten_Algemeen | 0x0060,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwshvwsnpverkl", Description = "Kan Vwshvwsnpverkl Opvragen")]
        Overzichten_Alg_Vwshvwsnpverkl = PermissionGroup.Overzichten_Algemeen | 0x0061,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwsituatiescredits", Description = "Kan Vwsituatiescredits Opvragen")]
        Overzichten_Alg_Vwsituatiescredits = PermissionGroup.Overzichten_Algemeen | 0x0062,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwsrgplus", Description = "Kan Vwsrgplus Opvragen")]
        Overzichten_Alg_Vwsrgplus = PermissionGroup.Overzichten_Algemeen | 0x0063,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwtakenperklantmanager", Description = "Kan Vwtakenperklantmanager Opvragen")]
        Overzichten_Alg_Vwtakenperklantmanager = PermissionGroup.Overzichten_Algemeen | 0x0064,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwtechlog", Description = "Kan Vwtechlog Opvragen")]
        Overzichten_Alg_Vwtechlog = PermissionGroup.Overzichten_Algemeen | 0x0065,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwterugvorderingdebi", Description = "Kan Vwterugvorderingdebi Opvragen")]
        Overzichten_Alg_Vwterugvorderingdebi = PermissionGroup.Overzichten_Algemeen | 0x0066,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwtestclienten", Description = "Kan Vwtestclienten Opvragen")]
        Overzichten_Alg_Vwtestclienten = PermissionGroup.Overzichten_Algemeen | 0x0067,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwtoetsbesluiten", Description = "Kan Vwtoetsbesluiten Opvragen")]
        Overzichten_Alg_Vwtoetsbesluiten = PermissionGroup.Overzichten_Algemeen | 0x0068,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwtotaleninstroom", Description = "Kan Vwtotaleninstroom Opvragen")]
        Overzichten_Alg_Vwtotaleninstroom = PermissionGroup.Overzichten_Algemeen | 0x0069,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwtrajecttrechter", Description = "Kan Vwtrajecttrechter Opvragen")]
        Overzichten_Alg_Vwtrajecttrechter = PermissionGroup.Overzichten_Algemeen | 0x006A,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwuitstroomdebi", Description = "Kan Vwuitstroomdebi Opvragen")]
        Overzichten_Alg_Vwuitstroomdebi = PermissionGroup.Overzichten_Algemeen | 0x006B,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwuitstroomdoel", Description = "Kan Vwuitstroomdoel Opvragen")]
        Overzichten_Alg_Vwuitstroomdoel = PermissionGroup.Overzichten_Algemeen | 0x006C,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwuitstroomjeugd", Description = "Kan Vwuitstroomjeugd Opvragen")]
        Overzichten_Alg_Vwuitstroomjeugd = PermissionGroup.Overzichten_Algemeen | 0x006D,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwuitstroomrecht", Description = "Kan Vwuitstroomrecht Opvragen")]
        Overzichten_Alg_Vwuitstroomrecht = PermissionGroup.Overzichten_Algemeen | 0x006E,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwuitstroomzorg", Description = "Kan Vwuitstroomzorg Opvragen")]
        Overzichten_Alg_Vwuitstroomzorg = PermissionGroup.Overzichten_Algemeen | 0x006F,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwverhaaldebi", Description = "Kan Vwverhaaldebi Opvragen")]
        Overzichten_Alg_Vwverhaaldebi = PermissionGroup.Overzichten_Algemeen | 0x0070,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwverhuizingen", Description = "Kan Vwverhuizingen Opvragen")]
        Overzichten_Alg_Vwverhuizingen = PermissionGroup.Overzichten_Algemeen | 0x0071,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwverstrekjeugd", Description = "Kan Vwverstrekjeugd Opvragen")]
        Overzichten_Alg_Vwverstrekjeugd = PermissionGroup.Overzichten_Algemeen | 0x0072,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwverstrekzorg", Description = "Kan Vwverstrekzorg Opvragen")]
        Overzichten_Alg_Vwverstrekzorg = PermissionGroup.Overzichten_Algemeen | 0x0073,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwvervoerleerlingen", Description = "Kan Vwvervoerleerlingen Opvragen")]
        Overzichten_Alg_Vwvervoerleerlingen = PermissionGroup.Overzichten_Algemeen | 0x0074,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwwoonverstrekkingen", Description = "Kan Vwwoonverstrekkingen Opvragen")]
        Overzichten_Alg_Vwwoonverstrekkingen = PermissionGroup.Overzichten_Algemeen | 0x0075,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwworkloadperuser", Description = "Kan Vwworkloadperuser Opvragen")]
        Overzichten_Alg_Vwworkloadperuser = PermissionGroup.Overzichten_Algemeen | 0x0076,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwzorgnaw", Description = "Kan Vwzorgnaw Opvragen")]
        Overzichten_Alg_Vwzorgnaw = PermissionGroup.Overzichten_Algemeen | 0x0077,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Vwaangepastewoningen", Description = "Kan Vwaangepastewoningen Opvragen")]
        Overzichten_Alg_Vwaangepastewoningen = PermissionGroup.Overzichten_Algemeen | 0x0078,
        [Display(GroupName = "Overzichten_Algemeen", Name = "Alles", Description = "Kan Alles Opvragen")]
        Overzichten_Alg_Alles = PermissionGroup.Overzichten_Algemeen | 0x00FF,

        [Display(GroupName = "Overzichten_HR", Name = "DimAdressen", Description = "Kan DimAdressen Opvragen")]
        Overzichten_HR_DimAdressen = PermissionGroup.Overzichten_HollandRijnland | 0x0001,
        [Display(GroupName = "Overzichten_HR", Name = "DimGemeenten", Description = "Kan DimGemeenten Opvragen")]
        Overzichten_HR_DimGemeenten = PermissionGroup.Overzichten_HollandRijnland | 0x0002,
        [Display(GroupName = "Overzichten_HR", Name = "DimKlanten", Description = "Kan DimKlanten Opvragen")]
        Overzichten_HR_DimKlanten = PermissionGroup.Overzichten_HollandRijnland | 0x0003,
        [Display(GroupName = "Overzichten_HR", Name = "DimProductCodes", Description = "Kan DimProductCodes Opvragen")]
        Overzichten_HR_DimProductCodes = PermissionGroup.Overzichten_HollandRijnland | 0x0004,
        [Display(GroupName = "Overzichten_HR", Name = "TDbBerichtenOverzicht", Description = "Kan TDbBerichtenOverzicht Opvragen")]
        Overzichten_HR_TDbBerichtenOverzicht = PermissionGroup.Overzichten_HollandRijnland | 0x0005,
        [Display(GroupName = "Overzichten_HR", Name = "TDbBerichtVoorzieningenOverzicht", Description = "Kan TDbBerichtVoorzieningenOverzicht Opvragen")]
        Overzichten_HR_TDbBerichtVoorzieningenOverzicht = PermissionGroup.Overzichten_HollandRijnland | 0x0006,
        [Display(GroupName = "Overzichten_HR", Name = "TDbBetalingenEnOntvangsten", Description = "Kan TDbBetalingenEnOntvangsten Opvragen")]
        Overzichten_HR_TDbBetalingenEnOntvangsten = PermissionGroup.Overzichten_HollandRijnland | 0x0007,
        [Display(GroupName = "Overzichten_HR", Name = "TDbBetalingenEnProducten", Description = "Kan TDbBetalingenEnProducten Opvragen")]
        Overzichten_HR_TDbBetalingenEnProducten = PermissionGroup.Overzichten_HollandRijnland | 0x0008,
        [Display(GroupName = "Overzichten_HR", Name = "TDbControleFactPainJourn", Description = "Kan TDbControleFactPainJourn Opvragen")]
        Overzichten_HR_TDbControleFactPainJourn = PermissionGroup.Overzichten_HollandRijnland | 0x0009,
        [Display(GroupName = "Overzichten_HR", Name = "TDbFactuurregelsAlgemeen", Description = "Kan TDbFactuurregelsAlgemeen Opvragen")]
        Overzichten_HR_TDbFactuurregelsAlgemeen = PermissionGroup.Overzichten_HollandRijnland | 0x000A,
        [Display(GroupName = "Overzichten_HR", Name = "TDbInterneControleTotaal", Description = "Kan TDbInterneControleTotaal Opvragen")]
        Overzichten_HR_TDbInterneControleTotaal = PermissionGroup.Overzichten_HollandRijnland | 0x000B,
        [Display(GroupName = "Overzichten_HR", Name = "TDbInterneControleVoorZ", Description = "Kan TDbInterneControleVoorZ Opvragen")]
        Overzichten_HR_TDbInterneControleVoorZ = PermissionGroup.Overzichten_HollandRijnland | 0x000C,
        [Display(GroupName = "Overzichten_HR", Name = "TDbVerstrekkingenJeugd", Description = "Kan TDbVerstrekkingenJeugd Opvragen")]
        Overzichten_HR_TDbVerstrekkingenJeugd = PermissionGroup.Overzichten_HollandRijnland | 0x000D,
        [Display(GroupName = "Overzichten_HR", Name = "THrannualInsightAanlevering", Description = "Kan THrannualInsightAanlevering Opvragen")]
        Overzichten_HR_THrannualInsightAanlevering = PermissionGroup.Overzichten_HollandRijnland | 0x000E,
        [Display(GroupName = "Overzichten_HR", Name = "THrannualInsight", Description = "Kan THrannualInsight Opvragen")]
        Overzichten_HR_THrannualInsight = PermissionGroup.Overzichten_HollandRijnland | 0x000F,
        [Display(GroupName = "Overzichten_HR", Name = "THrannualInsightIntern", Description = "Kan THrannualInsightIntern Opvragen")]
        Overzichten_HR_THrannualInsightIntern = PermissionGroup.Overzichten_HollandRijnland | 0x0010,
        [Display(GroupName = "Overzichten_HR", Name = "THrannualInsightToewAanl", Description = "Kan THrannualInsightToewAanl Opvragen")]
        Overzichten_HR_THrannualInsightToewAanl = PermissionGroup.Overzichten_HollandRijnland | 0x0011,
        [Display(GroupName = "Overzichten_HR", Name = "THrannualInsightToewijzingen", Description = "Kan THrannualInsightToewijzingen Opvragen")]
        Overzichten_HR_THrannualInsightToewijzingen = PermissionGroup.Overzichten_HollandRijnland | 0x0012,
        [Display(GroupName = "Overzichten_HR", Name = "THrDb315sZonderProduct", Description = "Kan THrDb315sZonderProduct Opvragen")]
        Overzichten_HR_THrDb315sZonderProduct = PermissionGroup.Overzichten_HollandRijnland | 0x0013,
        [Display(GroupName = "Overzichten_HR", Name = "THrDbControleFactPainJourn", Description = "Kan THrDbControleFactPainJourn Opvragen")]
        Overzichten_HR_THrDbControleFactPainJourn = PermissionGroup.Overzichten_HollandRijnland | 0x0014,
        [Display(GroupName = "Overzichten_HR", Name = "THrDbFacturenBerZonderNogTeOntvangen", Description = "Kan THrDbFacturenBerZonderNogTeOntvangen Opvragen")]
        Overzichten_HR_THrDbFacturenBerZonderNogTeOntvangen = PermissionGroup.Overzichten_HollandRijnland | 0x0015,
        [Display(GroupName = "Overzichten_HR", Name = "THrDbGeen301", Description = "Kan THrDbGeen301 Opvragen")]
        Overzichten_HR_THrDbGeen301 = PermissionGroup.Overzichten_HollandRijnland | 0x0016,
        [Display(GroupName = "Overzichten_HR", Name = "THrDbMogelijkeDubbeleBetalingen", Description = "Kan THrDbMogelijkeDubbeleBetalingen Opvragen")]
        Overzichten_HR_THrDbMogelijkeDubbeleBetalingen = PermissionGroup.Overzichten_HollandRijnland | 0x0017,
        [Display(GroupName = "Overzichten_HR", Name = "THrDbOntbrekendeBetaalvoorstellen", Description = "Kan THrDbOntbrekendeBetaalvoorstellen Opvragen")]
        Overzichten_HR_THrDbOntbrekendeBetaalvoorstellen = PermissionGroup.Overzichten_HollandRijnland | 0x0018,
        [Display(GroupName = "Overzichten_HR", Name = "THrDbVerantwoordelijkeGemeente", Description = "Kan THrDbVerantwoordelijkeGemeente Opvragen")]
        Overzichten_HR_THrDbVerantwoordelijkeGemeente = PermissionGroup.Overzichten_HollandRijnland | 0x0019,
        [Display(GroupName = "Overzichten_HR", Name = "THrtympaanClientGegevens", Description = "Kan THrtympaanClientGegevens Opvragen")]
        Overzichten_HR_THrtympaanClientGegevens = PermissionGroup.Overzichten_HollandRijnland | 0x001A,
        [Display(GroupName = "Overzichten_HR", Name = "THrtympaanFacturatie", Description = "Kan THrtympaanFacturatie Opvragen")]
        Overzichten_HR_THrtympaanFacturatie = PermissionGroup.Overzichten_HollandRijnland | 0x001B,
        [Display(GroupName = "Overzichten_HR", Name = "THrtympaanKosten", Description = "Kan THrtympaanKosten Opvragen")]
        Overzichten_HR_THrtympaanKosten = PermissionGroup.Overzichten_HollandRijnland | 0x001C,
        [Display(GroupName = "Overzichten_HR", Name = "VwHrannualInsightAanlevering", Description = "Kan VwHrannualInsightAanlevering Opvragen")]
        Overzichten_HR_VwHrannualInsightAanlevering = PermissionGroup.Overzichten_HollandRijnland | 0x001D,
        [Display(GroupName = "Overzichten_HR", Name = "VwHrannualInsightIntern", Description = "Kan VwHrannualInsightIntern Opvragen")]
        Overzichten_HR_VwHrannualInsightIntern = PermissionGroup.Overzichten_HollandRijnland | 0x001E,
        [Display(GroupName = "Overzichten_HR", Name = "VwHrannualInsightToewAanl", Description = "Kan VwHrannualInsightToewAanl Opvragen")]
        Overzichten_HR_VwHrannualInsightToewAanl = PermissionGroup.Overzichten_HollandRijnland | 0x001F,
        [Display(GroupName = "Overzichten_HR", Name = "Alles", Description = "Kan Alles van groep Overzichten_HR Opvragen")]
        Overzichten_HR_Alles = PermissionGroup.Overzichten_HollandRijnland | 0x00FF,

        // AccessAll -> Allow access to everything (Super User): 65535
        AccessAll = ushort.MaxValue,
    }
}
