public class PerfumeData
{
    public static List<Perfume> catalogue = new List<Perfume>();
    public static void FillData()
    {
        // Adi Ale Van -- The White Hero
        Perfume whiteHero = new Perfume(
            1,
            "Adi Ale Van",
            "The White Hero",

            new List<string>
            {
                "woody", "amber", "earthy", "mossy",
                "balsamic", "green", "aromatic",
                "fresh spicy", "warm spicy"
            },

            new Dictionary<Season, int>
            {
                { Season.Winter, 27 },
                { Season.Spring, 16 },
                { Season.Summer, 7 },
                { Season.Fall, 26 }
            },

            new Dictionary<Day, int>
            {
                { Day.Day, 17 },
                { Day.Night, 21 }
            },

            new List<string>
            {
                "Olibanum", "Mushroom", "Clary sage",
                "Candle wax", "Peru balsam", "Vetiver",
                "Moss", "Oakmoss", "Green leaves", "Woody notes",
                "Patchouli"
            }
        );
        catalogue.Add(whiteHero);

        // Adi Ale Van -- Decembrie 89
        Perfume decembrie89 = new Perfume(
            2,
            "Adi Ale Van",
            "Decembrie 89",

            new List<string>
            {
                "vanilla", "nutty", "woody", "rum",
                "fruity", "sweet", "citrus",
                "fresh", "powdery", "green"
            },

            new Dictionary<Season, int>
            {
                { Season.Winter, 150 },
                { Season.Spring, 21 },
                { Season.Summer, 13 },
                { Season.Fall, 109 }
            },

            new Dictionary<Day, int>
            {
                { Day.Day, 54 },
                { Day.Night, 110 }
            },

            new List<string>
            {
                "Apple", "Lemon", "Orange",
                "Vanilla bean", "Hazelnut", "Madagascar vanilla",
                "Vanilla absolute", "Rum"
            }
        );
        catalogue.Add(decembrie89);

        // Beaufort London -- Terror & Magnificence
        Perfume termag = new Perfume(
            3,
            "Beaufort London",
            "Terror & Magnificence",

            new List<string>
            {
                "amber", "leather", "warm spicy", "smoky",
                "woody", "balsamic", "tobacco",
                "aromatic", "fresh spicy", "sweet"
            },

            new Dictionary<Season, int>
            {
                { Season.Winter, 262 },
                { Season.Spring, 96 },
                { Season.Summer, 35 },
                { Season.Fall, 261 }
            },

            new Dictionary<Day, int>
            {
                { Day.Day, 113 },
                { Day.Night, 252 }
            },

            new List<string>
            {
                "Birch tar", "Black pepper", "Saffron",
                "Incense", "Tobacco", "Papyrus",
                "Myrrh", "Haitian vetiver", "Labdanum", "Benzoin", "Pebbles"
            }
        );
        catalogue.Add(termag);

        // Beaufort London -- Iron Duke
        Perfume ironDuke = new Perfume(
            3,
            "Beaufort London",
            "Iron Duke",

            new List<string>
            {
                "smoky", "leather", "tobacoo", "rum",
                "animalic", "sweet", "aromatic"
            },

            new Dictionary<Season, int>
            {
                { Season.Winter, 410 },
                { Season.Spring, 138 },
                { Season.Summer, 59 },
                { Season.Fall, 384 }
            },

            new Dictionary<Day, int>
            {
                { Day.Day, 200 },
                { Day.Night, 377 }
            },

            new List<string>
            {
                "Leather", "Gunpowder", "Tobacco",
                "Rum"
            }
        );
        catalogue.Add(ironDuke);

        // Beaufort London -- 1805 Tonnere
        Perfume tonnerre1805 = new Perfume(
            4,
            "Beaufort London",
            "1805 Tonnere",

            new List<string>
            {
                "smoky", "woody", "aromatic", "marine",
                "citrus"
            },

            new Dictionary<Season, int>
            {
                { Season.Winter, 266 },
                { Season.Spring, 93 },
                { Season.Summer, 53 },
                { Season.Fall, 258 }
            },

            new Dictionary<Day, int>
            {
                { Day.Day, 130 },
                { Day.Night, 260 }
            },

            new List<string>
            {
                "Smoke", "Gunpowder", "Lime",
                "Sea water", "Brandy", "Balsam fir",
                "Cedar", "Amber"
            }
        );
        catalogue.Add(tonnerre1805);

        // Beaufort London -- Coeur De Noir
        Perfume coeurDeNoir = new Perfume(
            5,
            "Beaufort London",
            "Coeur De Noir",

            new List<string>
            {
                "leather", "woody", "smoky", "aromatic",
                "tobacco", "animalic", "sweet", "rum", "vanilla"
            },

            new Dictionary<Season, int>
            {
                { Season.Winter, 316 },
                { Season.Spring, 87 },
                { Season.Summer, 41 },
                { Season.Fall, 282 }
            },

            new Dictionary<Day, int>
            {
                { Day.Day, 143 },
                { Day.Night, 297 }
            },

            new List<string>
            {
                "Ink", "Rum", "Ginger",
                "Leather", "Vanilla", "Birch",
                "Tobacco", "Cedar"
            }
        );
        catalogue.Add(coeurDeNoir);

        // Beaufort London -- Fathom V
        Perfume fathomV = new Perfume(
            6,
            "Beaufort London",
            "Fathom V",

            new List<string>
            {
                "green", "earthy", "white floral", "woody",
                "aromatic", "fresh spicy", "mossy", "yellow floral", "soft spicy"
            },

            new Dictionary<Season, int>
            {
                { Season.Winter, 266 },
                { Season.Spring, 728 },
                { Season.Summer, 422 },
                { Season.Fall, 521 }
            },

            new Dictionary<Day, int>
            {
                { Day.Day, 588 },
                { Day.Night, 345 }
            },

            new List<string>
            {
                "Green notes", "Soil tincture", "Junper berries",
                "Black currant", "Tangerine", "Lilly",
                "Mimosa", "Jasmine", "Thyme", "Black pepper", "Cumin",
                "Ylang-ylang", "Ginger", "Oakmoss", "Salt", "Vetiver",
                "Patchouli", "Incense", "Atlas cedar", "Amber"
            }
        );
        catalogue.Add(fathomV);

        // Beaufort London -- Vi Et Armis
        Perfume viEtArmis = new Perfume(
            7,
            "Beaufort London",
            "Vi Et Armis",

            new List<string>
            {
                "smoky", "warm spicy", "leather", "whiskey",
                "woody", "tobacco", "sweet", "amber", "balsamic", "fresh spicy"
            },

            new Dictionary<Season, int>
            {
                { Season.Winter, 305 },
                { Season.Spring, 90 },
                { Season.Summer, 45 },
                { Season.Fall, 289 }
            },

            new Dictionary<Day, int>
            {
                { Day.Day, 135 },
                { Day.Night, 291 }
            },

            new List<string>
            {
                "Tea leaf", "Black pepper", "Cardamom",
                "Incense", "Whiskey", "Opium",
                "Birch", "Tobacco", "Agarwood"
            }
        );
        catalogue.Add(viEtArmis);

        // Toskovat -- Anarchist A-
        Perfume anarchistA = new Perfume(
            8,
            "Toskovat",
            "Anarchist A",

            new List<string>
            {
                "woody", "aromatic", "fresh", "whiskey", "warm spicy"
            },

            new Dictionary<Season, int>
            {
                { Season.Winter, 253 },
                { Season.Spring, 106 },
                { Season.Summer, 73 },
                { Season.Fall, 224 }
            },

            new Dictionary<Day, int>
            {
                { Day.Day, 121 },
                { Day.Night, 247 }
            },

            new List<string>
            {
                "Credit cards", "Whiskey", "Snow",
                "Money", "Candle wax", "Ink",
                "Plastic bag", "Priest's clothes", "Holy water",
                "Precious wood", "Olibanum sacra resin green"
            }
        );
        catalogue.Add(anarchistA);

        // Toskovat -- Age of Innocence
        Perfume ageOfInnocence = new Perfume(
            9,
            "Toskovat",
            "Age of Innocence",

            new List<string>
            {
                "sweet", "fruity", "rubber", "metallic", "caramel",
                "gasoline", "tropical"
            },

            new Dictionary<Season, int>
            {
                { Season.Winter, 141 },
                { Season.Spring, 105 },
                { Season.Summer, 94 },
                { Season.Fall, 158 }
            },

            new Dictionary<Day, int>
            {
                { Day.Day, 154 },
                { Day.Night, 144 }
            },

            new List<string>
            {
                "Bubble gum", "Cotton candy", "Strawberry",
                "Gasoline", "Rubber", "Metallic notes",
                "Rose", "Agarwood", "Cedar",
                "Vetiver", "Cade oil"
            }
        );
        catalogue.Add(ageOfInnocence);

        // Toskovat -- Amaretto In The Melting Room
        Perfume amaretto = new Perfume(
            10,
            "Toskovat",
            "Amaretto In The Melting Room",

            new List<string>
            {
                "sweet", "fruity", "balsamic", "vanilla", "caramel",
                "honey", "almond", "tobacco", "amber", "savory", "powdery"
            },

            new Dictionary<Season, int>
            {
                { Season.Winter, 87 },
                { Season.Spring, 14 },
                { Season.Summer, 3 },
                { Season.Fall, 88 }
            },

            new Dictionary<Day, int>
            {
                { Day.Day, 26 },
                { Day.Night, 73 }
            },

            new List<string>
            {
                "Bread", "Peach", "Stone",
                "Orange peel", "Amaretto", "Candle wax",
                "Sugar syrup", "Labdanum", "Honeycomb",
                "Vanilla", "Tobacco", "Tonka"
            }
        );
        catalogue.Add(amaretto);

        // Toskovat -- Empty Wishes Well
        Perfume emptyWishesWell = new Perfume(
            11,
            "Toskovat",
            "Empty Wishes Well",

            new List<string>
            {
                "earthy", "aromatic", "woody", "aquatic", "metallic",
                "patchouli", "balsamic", "ozonic", "green", "warm spicy"
            },

            new Dictionary<Season, int>
            {
                { Season.Winter, 78 },
                { Season.Spring, 136 },
                { Season.Summer, 39 },
                { Season.Fall, 173 }
            },

            new Dictionary<Day, int>
            {
                { Day.Day, 117 },
                { Day.Night, 103 }
            },

            new List<string>
            {
                "Metallic notes", "Rain notes", "Dried fallen leaves",
                "Stone", "Sage", "Myrrh",
                "Earthy notes", "Patchouli", "Java vetiver oil",
                "Haitian vetiver", "Galbanum", "Amyris", "Carrot seeds"
            }
        );
        catalogue.Add(emptyWishesWell);
    }
}