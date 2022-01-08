using WebApplication8.Models;

namespace WebApplication8
{
    public static class DB
    {
        public static List<Suniukas> Suniukai = new List<Suniukas>()
        {
            new Suniukas()
            {
                Vardas = "Bobikas 1",
                Nuotrauka = "https://images.dog.ceo/breeds/spaniel-welsh/n02102177_3603.jpg"
            },
            new Suniukas()
            {
                Vardas = "Bobikas 2",
                Nuotrauka = "https://images.dog.ceo/breeds/sheepdog-english/n02105641_12614.jpg"
            },
            new Suniukas()
            {
                Vardas = "Bobikas 3",
                Nuotrauka = "https://images.dog.ceo/breeds/mix/Brina_2014_Italy.jpg"
            },
            new Suniukas()
            {
                Vardas = "Bobikas 4",
                Nuotrauka = "https://images.dog.ceo/breeds/pomeranian/n02112018_4813.jpg"
            }
        };
    }
}
