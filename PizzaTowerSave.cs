using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTowerSaveEditor
{
    public class PizzaTowerSave
    {
        public struct LevelInfo
        {
            public enum Ranks
            {
                D, C, B, A, S, P
            }
            public Ranks Rank;
            public int Score;

            public int Secrets;
            public int Attempts;

            public bool MushroomToppinCollected;
            public bool CheeseToppinCollected;
            public bool TomatoToppinCollected;
            public bool SausageToppinCollected;
            public bool PineappleToppinCollected;

            public bool Treasure;
        }

        public struct MrStickInfo
        {
            public bool First;
            public bool Door;
            public int Reduction;
            public bool Unlocked;
            public bool BossKey;
        }
        public class PizzaTowerSaveFile
        {
            public void Read(string filepath)
            {
                var saveIni = new IniFile(filepath);

                readWorld1();
                readWorld2();
                readWorld3();
                readWorld4();
                readWorld5();

                return;

                LevelInfo readLevelInfo(string name)
                {
                    LevelInfo info = new LevelInfo();

                    info.Score = Convert.ToInt32(saveIni.Read(name, "Highscore"));
                    info.Attempts = Convert.ToInt32(saveIni.Read(name, "Attempts"));
                    info.MushroomToppinCollected = saveIni.Read($"{name}1", "Toppin") == "1.000000";
                    info.CheeseToppinCollected = saveIni.Read($"{name}2", "Toppin") == "1.000000";
                    info.TomatoToppinCollected = saveIni.Read($"{name}3", "Toppin") == "1.000000";
                    info.SausageToppinCollected = saveIni.Read($"{name}4", "Toppin") == "1.000000";
                    info.PineappleToppinCollected = saveIni.Read($"{name}5", "Toppin") == "1.000000";
                    info.Treasure = saveIni.Read(name, "Treasure") == "1.000000";

                    switch (saveIni.Read(name, "Ranks"))
                    {
                        case "p":
                        case "P":
                            info.Rank = LevelInfo.Ranks.P;
                            break;
                        case "s":
                        case "S":
                            info.Rank = LevelInfo.Ranks.S;
                            break;
                        case "a":
                        case "A":
                            info.Rank = LevelInfo.Ranks.A;
                            break;
                        case "b":
                        case "B":
                            info.Rank = LevelInfo.Ranks.B;
                            break;
                        case "c":
                        case "C":
                            info.Rank = LevelInfo.Ranks.C;
                            break;
                        case "d":
                        case "D":
                            info.Rank = LevelInfo.Ranks.D;
                            break;
                    }

                    return info;
                }

                void readWorld1()
                {
                    JohnGutter = readLevelInfo("entrance");
                    Pizzascape = readLevelInfo("medieval");
                    AncientCheese = readLevelInfo("ruin");
                    BloodsauceDungeon = readLevelInfo("dungeon");
                }

                void readWorld2()
                {
                    OreganoDesert = readLevelInfo("badland");
                    Wasteyard = readLevelInfo("graveyard");
                    FunFarm = readLevelInfo("farm");
                    FastFoodSaloon = readLevelInfo("saloon");
                }

                void readWorld3()
                {
                    CrustCove = readLevelInfo("plage");
                    GnomeForest = readLevelInfo("forest");
                    DeepDish9 = readLevelInfo("space");
                    Golf = readLevelInfo("minigolf");
                }

                void readWorld4()
                {
                    ThePigCity = readLevelInfo("street");
                    PeppibotFactory = readLevelInfo("industrial");
                    OhShit = readLevelInfo("sewer");
                    RefrigeratorRefrigeradorFreezerator = readLevelInfo("freezer");
                }

                void readWorld5()
                {
                    Pizzascare = readLevelInfo("chateau");
                    DontMakeASound = readLevelInfo("kidsparty");
                    WAR = readLevelInfo("war");
                    TheCrumblingTowerOfPizza = readLevelInfo("exit");
                }
            }


            /// <summary>
            ///  Should the fake peppino portrait be shown?
            /// </summary>
            public bool FakePeppinoPortait;

            /// <summary>
            /// Has Pizzaface been seen in the shower?
            /// </summary>
            public bool PizzaFaceShower;

            /// <summary>
            /// Is Snotty Alive?
            /// </summary>
            public bool SnottyAlive;

            public int BadBonesCount;
            public int StripesCount;
            public int GarishCount;

            public bool MrMooneyUnlocked;

            public bool JohnnyApproved;
            public bool JohnApproved;


            public enum Judgements
            {
                YouSuck,
                Confused,
                ThatsTheOneOfficer,
                NoJudgement,
                NotBad,
                Wow,
                HolyShit,
                QuickAsHell
            }

            public Judgements Judgement;

            public string JudgementString;

            public float Seconds;
            public int Minutes;
            public int Percentage;


            // World 1
            public LevelInfo JohnGutter = new LevelInfo();
            public LevelInfo Pizzascape = new LevelInfo();
            public LevelInfo AncientCheese = new LevelInfo();
            public LevelInfo BloodsauceDungeon = new LevelInfo();

            // World 2
            public LevelInfo OreganoDesert = new LevelInfo();
            public LevelInfo Wasteyard = new LevelInfo();
            public LevelInfo FunFarm = new LevelInfo();
            public LevelInfo FastFoodSaloon = new LevelInfo();

            // World 3
            public LevelInfo CrustCove = new LevelInfo();
            public LevelInfo GnomeForest = new LevelInfo();
            public LevelInfo DeepDish9 = new LevelInfo();
            public LevelInfo Golf = new LevelInfo();

            // World 4
            public LevelInfo ThePigCity = new LevelInfo();
            public LevelInfo PeppibotFactory = new LevelInfo();
            public LevelInfo OhShit = new LevelInfo();
            public LevelInfo RefrigeratorRefrigeradorFreezerator = new LevelInfo();

            // World 5
            public LevelInfo Pizzascare = new LevelInfo();
            public LevelInfo DontMakeASound = new LevelInfo();
            public LevelInfo WAR = new LevelInfo();
            public LevelInfo TheCrumblingTowerOfPizza = new LevelInfo();

        }

        public PizzaTowerSave(string directory)
        {
            File1.Read($"{directory}\\saves\\saveData1.ini");

        }

        public PizzaTowerSaveFile File1 = new PizzaTowerSaveFile();
        public PizzaTowerSaveFile File2 = new PizzaTowerSaveFile();
        public PizzaTowerSaveFile File3 = new PizzaTowerSaveFile();

    }
}
