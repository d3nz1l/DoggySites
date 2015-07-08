// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DogBreeds.cs" company="">
//   
// </copyright>
// <summary>
//   The dog breeds.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DoggySites.Presentation.Common.Enumerations
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The dog breeds.
    /// </summary>
    public enum DogBreeds
    {
        /// <summary>
        /// The affenpinscher.
        /// </summary>
        [Display(Name = "Affenpinscher")]
        Affenpinscher = 1,

        /// <summary>
        /// The airedale.
        /// </summary>
        [Display(Name = "Airedale")]
        Airedale = 2,

        /// <summary>
        /// The akita inu.
        /// </summary>
        [Display(Name = "Akita Inu")]
        AkitaInu = 3,

        /// <summary>
        /// The american bulldog.
        /// </summary>
        [Display(Name = "American Bulldog")]
        AmericanBulldog = 4,

        /// <summary>
        /// The american cocker spaniel.
        /// </summary>
        [Display(Name = "American Cocker Spaniel")]
        AmericanCockerSpaniel = 5,

        /// <summary>
        /// The australian cattle dog.
        /// </summary>
        [Display(Name = "Australian Cattle Dog")]
        AustralianCattleDog = 6,

        /// <summary>
        /// The australian kelpie.
        /// </summary>
        [Display(Name = "Australian Kelpie")]
        AustralianKelpie = 7,

        /// <summary>
        /// The australian shepherd dog.
        /// </summary>
        [Display(Name = "Australian Shepherd Dog")]
        AustralianShepherdDog = 8,

        /// <summary>
        /// The beagle.
        /// </summary>
        [Display(Name = "Beagle")]
        Beagle = 9,

        /// <summary>
        /// The bearded collie.
        /// </summary>
        [Display(Name = "Bearded Collie")]
        BeardedCollie = 10,

        /// <summary>
        /// The bedlington terrier.
        /// </summary>
        [Display(Name = "Bedlington Terrier")]
        BedlingtonTerrier = 11,

        /// <summary>
        /// The belgian shepherd dog.
        /// </summary>
        [Display(Name = "Belgian Shepherd Dog")]
        BelgianShepherdDog = 12,

        /// <summary>
        /// The bernese mountain dog.
        /// </summary>
        [Display(Name = "Bernese Mountain Dog")]
        BerneseMountainDog = 13,

        /// <summary>
        /// The bichon frise.
        /// </summary>
        [Display(Name = "Bichon Frise")]
        BichonFrise = 14,

        /// <summary>
        /// The border collie wsd.
        /// </summary>
        [Display(Name = "Border Collie/WSD")]
        BorderCollieWsd = 15,

        /// <summary>
        /// The border terrier.
        /// </summary>
        [Display(Name = "Border Terrier")]
        BorderTerrier = 16,

        /// <summary>
        /// The boxer.
        /// </summary>
        [Display(Name = "Boxer")]
        Boxer = 17,

        /// <summary>
        /// The briard.
        /// </summary>
        [Display(Name = "Briard")]
        Briard = 18,

        /// <summary>
        /// The bull mastiff.
        /// </summary>
        [Display(Name = "Bull Mastiff")]
        BullMastiff = 19,

        /// <summary>
        /// The cairn terrier.
        /// </summary>
        [Display(Name = "Cairn Terrier")]
        CairnTerrier = 20,

        /// <summary>
        /// The cavalier king charles spaniel.
        /// </summary>
        [Display(Name = "Cavalier King Charles Spaniel")]
        CavalierKingCharlesSpaniel = 21,

        /// <summary>
        /// The chesapeake bay retriever.
        /// </summary>
        [Display(Name = "Chesapeake Bay Retriever")]
        ChesapeakeBayRetriever = 22,

        /// <summary>
        /// The chinese crested.
        /// </summary>
        [Display(Name = "Chinese Crested")]
        ChineseCrested = 23,

        /// <summary>
        /// The corgi.
        /// </summary>
        [Display(Name = "Corgi")]
        Corgi = 24,

        /// <summary>
        /// The cross breed.
        /// </summary>
        [Display(Name = "Cross-Breed")]
        CrossBreed = 25,

        /// <summary>
        /// The curly coated retriever.
        /// </summary>
        [Display(Name = "Curly Coated Retriever")]
        CurlyCoatedRetriever = 26,

        /// <summary>
        /// The dachshund.
        /// </summary>
        [Display(Name = "Dachshund")]
        Dachshund = 27,

        /// <summary>
        /// The dalmatian.
        /// </summary>
        [Display(Name = "Dalmatian")]
        Dalmatian = 28,

        /// <summary>
        /// The deerhound.
        /// </summary>
        [Display(Name = "Deerhound")]
        Deerhound = 29,

        /// <summary>
        /// The dobermann.
        /// </summary>
        [Display(Name = "Dobermann")]
        Dobermann = 30,

        /// <summary>
        /// The dutch partridge dog.
        /// </summary>
        [Display(Name = "Dutch Partridge Dog")]
        DutchPartridgeDog = 31,

        /// <summary>
        /// The english bull terrier.
        /// </summary>
        [Display(Name = "English Bull Terrier")]
        EnglishBullTerrier = 32,

        /// <summary>
        /// The english cocker spaniel.
        /// </summary>
        [Display(Name = "English Cocker Spaniel")]
        EnglishCockerSpaniel = 33,

        /// <summary>
        /// The english pointer.
        /// </summary>
        [Display(Name = "English Pointer")]
        EnglishPointer = 34,

        /// <summary>
        /// The english shepherd.
        /// </summary>
        [Display(Name = "English Shepherd")]
        EnglishShepherd = 35,

        /// <summary>
        /// The english springer spaniel.
        /// </summary>
        [Display(Name = "English Springer Spaniel")]
        EnglishSpringerSpaniel = 36,

        /// <summary>
        /// The field spaniel.
        /// </summary>
        [Display(Name = "Field Spaniel")]
        FieldSpaniel = 37,

        /// <summary>
        /// The flat coated retriever.
        /// </summary>
        [Display(Name = "Flat Coated Retriever")]
        FlatCoatedRetriever = 38,

        /// <summary>
        /// The fox terrier.
        /// </summary>
        [Display(Name = "Fox Terrier")]
        FoxTerrier = 39,

        /// <summary>
        /// The german shepherd dog.
        /// </summary>
        [Display(Name = "German Shepherd Dog")]
        GermanShepherdDog = 40,

        /// <summary>
        /// The german shorthaired pointer.
        /// </summary>
        [Display(Name = "German Shorthaired Pointer")]
        GermanShorthairedPointer = 41,

        /// <summary>
        /// The german spitz.
        /// </summary>
        [Display(Name = "German Spitz")]
        GermanSpitz = 42,

        /// <summary>
        /// The german wirehaired pointer.
        /// </summary>
        [Display(Name = "German Wirehaired Pointer")]
        GermanWirehairedPointer = 43,

        /// <summary>
        /// The golden retriever.
        /// </summary>
        [Display(Name = "Golden Retriever")]
        GoldenRetriever = 44,

        /// <summary>
        /// The great dane.
        /// </summary>
        [Display(Name = "Great Dane")]
        GreatDane = 45,

        /// <summary>
        /// The greyhound.
        /// </summary>
        [Display(Name = "Greyhound")]
        Greyhound = 46,

        /// <summary>
        /// The hungarian puli.
        /// </summary>
        [Display(Name = "Hungarian Puli")]
        HungarianPuli = 47,

        /// <summary>
        /// The hungarian vizsla.
        /// </summary>
        [Display(Name = "Hungarian Vizsla")]
        HungarianVizsla = 48,

        /// <summary>
        /// The irish red white setter.
        /// </summary>
        [Display(Name = "Irish Red & White Setter")]
        IrishRedWhiteSetter = 49,

        /// <summary>
        /// The irish setter.
        /// </summary>
        [Display(Name = "Irish Setter")]
        IrishSetter = 50,

        /// <summary>
        /// The irish terrier.
        /// </summary>
        [Display(Name = "Irish Terrier")]
        IrishTerrier = 51,

        /// <summary>
        /// The irish water spaniel.
        /// </summary>
        [Display(Name = "Irish Water Spaniel")]
        IrishWaterSpaniel = 52,

        /// <summary>
        /// The italian spinone.
        /// </summary>
        [Display(Name = "Italian Spinone")]
        ItalianSpinone = 53,

        /// <summary>
        /// The jack russell terrier.
        /// </summary>
        [Display(Name = "Jack Russell Terrier")]
        JackRussellTerrier = 54,

        /// <summary>
        /// The japanese spitz.
        /// </summary>
        [Display(Name = "Japanese Spitz")]
        JapaneseSpitz = 55,

        /// <summary>
        /// The komondor.
        /// </summary>
        [Display(Name = "Komondor")]
        Komondor = 56,

        /// <summary>
        /// The kooikerhondje.
        /// </summary>
        [Display(Name = "Kooikerhondje")]
        Kooikerhondje = 57,

        /// <summary>
        /// The labrador retriever.
        /// </summary>
        [Display(Name = "Labrador Retriever")]
        LabradorRetriever = 58,

        /// <summary>
        /// The lakeland terrier.
        /// </summary>
        [Display(Name = "Lakeland Terrier")]
        LakelandTerrier = 59,

        /// <summary>
        /// The lancashire heeler.
        /// </summary>
        [Display(Name = "Lancashire Heeler")]
        LancashireHeeler = 60,

        /// <summary>
        /// The large munsterlander.
        /// </summary>
        [Display(Name = "Large Munsterlander")]
        LargeMunsterlander = 61,

        /// <summary>
        /// The leonberger.
        /// </summary>
        [Display(Name = "Leonberger")]
        Leonberger = 62,

        /// <summary>
        /// The lhasa apso.
        /// </summary>
        [Display(Name = "Lhasa Apso")]
        LhasaApso = 63,

        /// <summary>
        /// The malinois.
        /// </summary>
        [Display(Name = "Malinois")]
        Malinois = 64,

        /// <summary>
        /// The manchester terrier.
        /// </summary>
        [Display(Name = "Manchester Terrier")]
        ManchesterTerrier = 65,

        /// <summary>
        /// The mexican hairless.
        /// </summary>
        [Display(Name = "Mexican Hairless")]
        MexicanHairless = 66,

        /// <summary>
        /// The miniature poodle.
        /// </summary>
        [Display(Name = "Miniature Poodle")]
        MiniaturePoodle = 67,

        /// <summary>
        /// The miniature schnauzer.
        /// </summary>
        [Display(Name = "Miniature Schnauzer")]
        MiniatureSchnauzer = 68,

        /// <summary>
        /// The new foundland.
        /// </summary>
        [Display(Name = "New Foundland")]
        NewFoundland = 69,

        /// <summary>
        /// The new zealand huntaway.
        /// </summary>
        [Display(Name = "New Zealand Huntaway")]
        NewZealandHuntaway = 70,

        /// <summary>
        /// The norfolk terrier.
        /// </summary>
        [Display(Name = "Norfolk Terrier")]
        NorfolkTerrier = 71,

        /// <summary>
        /// The northern inuit dog.
        /// </summary>
        [Display(Name = "Northern Inuit Dog")]
        NorthernInuitDog = 72,

        /// <summary>
        /// The norwegian buhund.
        /// </summary>
        [Display(Name = "Norwegian Buhund")]
        NorwegianBuhund = 73,

        /// <summary>
        /// The norwich terrier.
        /// </summary>
        [Display(Name = "Norwich Terrier")]
        NorwichTerrier = 74,

        /// <summary>
        /// The nova scotia duck tolling retriever.
        /// </summary>
        [Display(Name = "Nova Scotia Duck Tolling Retriever")]
        NovaScotiaDuckTollingRetriever = 75,

        /// <summary>
        /// The old english sheepdog.
        /// </summary>
        [Display(Name = "Old English Sheepdog")]
        OldEnglishSheepdog = 76,

        /// <summary>
        /// The papillon.
        /// </summary>
        [Display(Name = "Papillon")]
        Papillon = 77,

        /// <summary>
        /// The patterdale terrier.
        /// </summary>
        [Display(Name = "Patterdale Terrier")]
        PatterdaleTerrier = 78,

        /// <summary>
        /// The phaelene.
        /// </summary>
        [Display(Name = "Phaelene")]
        Phaelene = 79,

        /// <summary>
        /// The pharaoh hound.
        /// </summary>
        [Display(Name = "Pharaoh Hound")]
        PharaohHound = 80,

        /// <summary>
        /// The plummer terrier.
        /// </summary>
        [Display(Name = "Plummer Terrier")]
        PlummerTerrier = 81,

        /// <summary>
        /// The pomeranian.
        /// </summary>
        [Display(Name = "Pomeranian")]
        Pomeranian = 82,

        /// <summary>
        /// The poodle.
        /// </summary>
        [Display(Name = "Poodle")]
        Poodle = 83,

        /// <summary>
        /// The pyrenean mountain dog.
        /// </summary>
        [Display(Name = "Pyrenean Mountain Dog")]
        PyreneanMountainDog = 84,

        /// <summary>
        /// The pyrenean sheepdog.
        /// </summary>
        [Display(Name = "Pyrenean Sheepdog")]
        PyreneanSheepdog = 85,

        /// <summary>
        /// The rhodesian ridgeback.
        /// </summary>
        [Display(Name = "Rhodesian Ridgeback")]
        RhodesianRidgeback = 86,

        /// <summary>
        /// The rottweiler.
        /// </summary>
        [Display(Name = "Rottweiler")]
        Rottweiler = 87,

        /// <summary>
        /// The rough collie.
        /// </summary>
        [Display(Name = "Rough Collie")]
        RoughCollie = 88,

        /// <summary>
        /// The saluki.
        /// </summary>
        [Display(Name = "Saluki")]
        Saluki = 89,

        /// <summary>
        /// The samoyed.
        /// </summary>
        [Display(Name = "Samoyed")]
        Samoyed = 90,

        /// <summary>
        /// The schipperke.
        /// </summary>
        [Display(Name = "Schipperke")]
        Schipperke = 91,

        /// <summary>
        /// The schnauzer.
        /// </summary>
        [Display(Name = "Schnauzer")]
        Schnauzer = 92,

        /// <summary>
        /// The scottish terrier.
        /// </summary>
        [Display(Name = "Scottish Terrier")]
        ScottishTerrier = 93,

        /// <summary>
        /// The shetland sheepdog.
        /// </summary>
        [Display(Name = "Shetland Sheepdog")]
        ShetlandSheepdog = 94,

        /// <summary>
        /// The shitzu.
        /// </summary>
        [Display(Name = "Shitzu")]
        Shitzu = 95,

        /// <summary>
        /// The siberian husky.
        /// </summary>
        [Display(Name = "Siberian Husky")]
        SiberianHusky = 96,

        /// <summary>
        /// The small munsterlander.
        /// </summary>
        [Display(Name = "Small Munsterlander")]
        SmallMunsterlander = 97,

        /// <summary>
        /// The smooth collie.
        /// </summary>
        [Display(Name = "Smooth Collie")]
        SmoothCollie = 98,

        /// <summary>
        /// The soft coated wheaten terrier.
        /// </summary>
        [Display(Name = "Soft Coated Wheaten Terrier")]
        SoftCoatedWheatenTerrier = 99,

        /// <summary>
        /// The spanish water dog.
        /// </summary>
        [Display(Name = "Spanish Water Dog")]
        SpanishWaterDog = 100,

        /// <summary>
        /// The staffordshire bull terrier.
        /// </summary>
        [Display(Name = "Staffordshire Bull Terrier")]
        StaffordshireBullTerrier = 101,

        /// <summary>
        /// The standard poodle.
        /// </summary>
        [Display(Name = "Standard Poodle")]
        StandardPoodle = 102,

        /// <summary>
        /// The swedish vallhound.
        /// </summary>
        [Display(Name = "Swedish Vallhound")]
        SwedishVallhound = 103,

        /// <summary>
        /// The tibetan mastiff.
        /// </summary>
        [Display(Name = "Tibetan Mastiff")]
        TibetanMastiff = 104,

        /// <summary>
        /// The tibetan terrier.
        /// </summary>
        [Display(Name = "Tibetan Terrier")]
        TibetanTerrier = 105,

        /// <summary>
        /// The toy poodle.
        /// </summary>
        [Display(Name = "Toy Poodle")]
        ToyPoodle = 106,

        /// <summary>
        /// The weimaraner.
        /// </summary>
        [Display(Name = "Weimaraner")]
        Weimaraner = 107,

        /// <summary>
        /// The welsh springer spaniel.
        /// </summary>
        [Display(Name = "Welsh Springer Spaniel")]
        WelshSpringerSpaniel = 108,

        /// <summary>
        /// The west highland white terrier.
        /// </summary>
        [Display(Name = "West Highland White Terrier")]
        WestHighlandWhiteTerrier = 109,

        /// <summary>
        /// The whippet.
        /// </summary>
        [Display(Name = "Whippet")]
        Whippet = 110,

        /// <summary>
        /// The yorkshire terrier.
        /// </summary>
        [Display(Name = "Yorkshire Terrier")]
        YorkshireTerrier = 111,
    }
}