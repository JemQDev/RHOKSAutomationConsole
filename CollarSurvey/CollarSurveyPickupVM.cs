using CommunityToolkit.Mvvm.ComponentModel;
using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.IdentityModel.Tokens;
using RHOKSAutomationConsole.EFACQ;
using RHOKSAutomationConsole.EFRHOKS2020;
using RHOKSAutomationConsole.EFRHOKS2024;
using RHOKSAutomationConsole.Pegging;
using RHOKSAutomationConsole.Settings;
using System.Globalization;

namespace RHOKSAutomationConsole.CollarSurvey;

public partial class CollarSurveyPickupVM : ObservableObject
{
    [ObservableProperty] CollarSurveyPickupM? m_CollarSurveyPickupSettings;
    [ObservableProperty] AcquireCommandLineM? m_AcquireCommandLineModel;
    [ObservableProperty] Options m_OptionsData;
    [ObservableProperty] RHOKS_2024Context m_Rhoks2024Context;
    [ObservableProperty] RHOKS_2020Context m_Rhoks2020Context;
    [ObservableProperty] ACQContext m_AcquireContext;

    public CollarSurveyPickupVM(
        RHOKS_2024Context rhoks2024context,
        RHOKS_2020Context rhoks2020context,
        ACQContext acquirecontext,
        Options options,
        CollarSurveyPickupM? collarSurveyModel,
        AcquireCommandLineM acquireCommandLineModel,
        PeggingSettingsM peggingModel
        )
    {
        Rhoks2024Context = rhoks2024context ?? throw new ArgumentNullException(nameof(rhoks2024context));
        Rhoks2020Context = rhoks2020context ?? throw new ArgumentNullException(nameof(rhoks2020context));
        AcquireContext = acquirecontext ?? throw new ArgumentNullException(nameof(acquirecontext));
        OptionsData = options ?? throw new ArgumentNullException(nameof(options));

        PeggingModel = peggingModel ?? throw new ArgumentNullException(nameof(peggingModel));
        AcquireCommandLineModel = acquireCommandLineModel ?? throw new ArgumentNullException(nameof(acquireCommandLineModel));
        CollarSurveyPickupSettings = collarSurveyModel ?? throw new ArgumentNullException(nameof(collarSurveyModel));
    }

    public PeggingSettingsM PeggingModel { get; }

    public void ProcessSurveyCollarPickupTest()
    {
        EFRHOKS2024.CollarPickup? currentprocessing = new();

        Console.WriteLine();
        //Console.WriteLine($"Processing Survey Collar Pickup...{Options.DataSource}");
        Console.WriteLine($"Processing Survey Collar Pickup...");
        Console.WriteLine();

        // Check Options for command line settings of TEST or PROD
        //if (Options is not null && Options.DataSource is not null && Options.DataSource.Equals("TEST", StringComparison.CurrentCultureIgnoreCase))
        //{
            if (CollarSurveyPickupSettings is not null && !CollarSurveyPickupSettings.OreDefSourceTEST.IsNullOrEmpty())
            {
                // Check Directory Exists
                if (Directory.Exists(CollarSurveyPickupSettings?.OreDefSourceTEST))
                {
                    foreach (var file in Directory.GetFiles(CollarSurveyPickupSettings?.OreDefSourceTEST!))
                    {
                        Console.WriteLine(file);
                        var configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
                        {
                            HasHeaderRecord = true,
                        };

                        string[] allLines = System.IO.File.ReadAllLines(file);

                        using var reader = new StreamReader(file);
                        using var csv = new CsvReader(reader, configuration);
                        csv.Read();
                        csv.ReadHeader();
                        // Hole_ID,Easting,Northing,RL,Date Surveyed,Survey_Method,Peg #/Comment
                        while (csv.Read())
                        { 
                            currentprocessing = new();
                            FileInfo fi = new(file);
                            currentprocessing.Drillhole = csv.GetField<string>("Hole_ID");
                            currentprocessing.CollarPickupEasting = decimal.TryParse(csv.GetField<string>("Easting"), out decimal pe) ? pe : null;
                            currentprocessing.CollarPickupNorthing = decimal.TryParse(csv.GetField<string>("Northing"), out decimal pn) ? pn : null;
                            currentprocessing.CollarPickupRL = decimal.TryParse(csv.GetField<string>("RL"), out decimal prl) ? prl : null;
                            currentprocessing.DateCollarPickup = DateOnly.TryParse(csv.GetField<string>("Date Surveyed"), out DateOnly dcp) ? dcp : currentprocessing.DateCollarPickupFile;
                            currentprocessing.CollarPickupMethod = csv.GetField<string>("Survey_Method");
                            currentprocessing.CollarPickupComment = csv.GetField<string>("Peg #/Comment");
                            currentprocessing.DateCollarPickupFile = DateOnly.FromDateTime(fi.LastWriteTime);

                            EFRHOKS2024.CollarPickup? existingDatabaseRecord = Rhoks2024Context.CollarPickup
                                .Where(c => c.Drillhole.Equals(currentprocessing.Drillhole))
                                .Where(c => c.DateCollarPickupFile.Equals(currentprocessing.DateCollarPickupFile))
                                .Where(c => c.DateCollarPickup.Equals(currentprocessing.DateCollarPickup))
                                .Where(c => c.CollarPickupMethod.Equals(currentprocessing.CollarPickupMethod))
                                .FirstOrDefault();

                            bool isexisting = existingDatabaseRecord is not null;

                            HOLELOCATION? hl = AcquireContext.HOLELOCATION
                            .Where(h => h.HOLEID.Equals(currentprocessing.Drillhole))
                            .FirstOrDefault();

                            IEnumerable<HOLECOORD>? hc = AcquireContext.HOLECOORD
                                .Where(hc => hc.HOLEID.Equals(currentprocessing.Drillhole));

                            var planned = hc.FirstOrDefault(hc => hc.COORDINATESET.Equals("GDA94_50_S_PLAN", StringComparison.CurrentCultureIgnoreCase));
                            if (planned is not null)
                            {
                                currentprocessing.CollarPlannedEasting = decimal.TryParse(planned.X.ToString(), out decimal planeastdec) ? planeastdec : null;
                                currentprocessing.CollarPlannedNorthing = decimal.TryParse(planned.Y.ToString(), out decimal plannorthdec) ? plannorthdec : null;
                                currentprocessing.CollarPlannedRL = decimal.TryParse(planned.Z.ToString(), out decimal planrldec) ? planrldec : null;

                            }

                            var pegged = hc.FirstOrDefault(hc => hc.COORDINATESET.Equals("PEGGING_GPS", StringComparison.CurrentCultureIgnoreCase));
                            if (pegged is not null)
                            {
                                currentprocessing.CollarPeggedEasting = decimal.TryParse(pegged.X.ToString(), out decimal pegeastdec) ? pegeastdec : null;
                                currentprocessing.CollarPeggedNorthing = decimal.TryParse(pegged.Y.ToString(), out decimal pegnorthdec) ? pegnorthdec : null;
                                currentprocessing.CollarPeggedRL = decimal.TryParse(pegged.Z.ToString(), out decimal pegrldec) ? pegrldec : null;
                            }

                            var rtk = hc.FirstOrDefault(hc => hc.COORDINATESET.Equals("GDA94_50_S_RTGPS", StringComparison.CurrentCultureIgnoreCase));
                            if (rtk is not null && isexisting)
                            {
                                decimal? existingRTKEasting = decimal.TryParse(rtk.X.ToString(), out decimal rtkeastdec) ? rtkeastdec : null;
                                decimal? existingRTKNorthing = decimal.TryParse(rtk.Y.ToString(), out decimal rtknorthdec) ? rtknorthdec : null;
                                decimal? existingRTKRL = decimal.TryParse(rtk.Z.ToString(), out decimal rtkrldec) ? rtkrldec : null;

                                if (existingRTKEasting != existingDatabaseRecord?.CollarPickupEasting) currentprocessing.CollarPickupEasting = existingRTKEasting;
                                if (existingRTKNorthing != existingDatabaseRecord?.CollarPickupNorthing) currentprocessing.CollarPickupNorthing = existingRTKNorthing;
                                if (existingRTKRL != existingDatabaseRecord?.CollarPickupRL) currentprocessing.CollarPickupRL = existingRTKRL;
                            }

                            if (isexisting)
                            {
                                existingDatabaseRecord = currentprocessing;
                            } else
                            {
                                Rhoks2024Context.CollarPickup.Add(currentprocessing);
                            }

                            Rhoks2024Context.SaveChanges();


                        }
                    }
                }
                else
                {
                    Console.WriteLine($"No such directory or unbale to read => {CollarSurveyPickupSettings?.OreDefSourceTEST}");
                }
            }
        //}
        Console.WriteLine();
        //Console.WriteLine($"COMPLETED Processing Survey Collar Pickup...{Options.DataSource}");
        Console.WriteLine($"COMPLETED Processing Survey Collar Pickup...");
        Console.WriteLine();
    }
}

