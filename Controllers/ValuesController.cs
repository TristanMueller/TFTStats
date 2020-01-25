using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TFTStats.Models;

namespace TFTStats.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public MongoAccessModel _mongoAccessModel { get; set; }
        public ValuesController(MongoAccessModel mongoAccessModel)
        {
            _mongoAccessModel = mongoAccessModel;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var matchFunction = new MatchFunction(_mongoAccessModel);
            var match = Newtonsoft.Json.JsonConvert.DeserializeObject<Match>("{" +
"    \"info\": {" +
"        \"game_datetime\": 1579506064056," +
"        \"participants\": [" +
"            {" +
"                \"placement\": 1," +
"                \"level\": 9," +
"                \"last_round\": 37," +
"                \"time_eliminated\": 2114.0556640625," +
"                \"companion\": {" +
"                    \"skin_ID\": 2," +
"                    \"content_ID\": \"6aed1fba-d9e9-40ba-aefd-bca7c2053af5\"," +
"                    \"species\": \"PetMiner\"" +
"                }," +
"                \"traits\": [" +
"                    {" +
"                        \"tier_total\": 1," +
"                        \"style\": 3," +
"                        \"name\": \"Celestial\"," +
"                        \"tier_current\": 1," +
"                        \"num_units\": 2" +
"                    }," +
"                    {" +
"                        \"tier_total\": 2," +
"                        \"style\": 1," +
"                        \"name\": \"Desert\"," +
"                        \"tier_current\": 1," +
"                        \"num_units\": 2" +
"                    }," +
"                    {" +
"                        \"tier_total\": 3," +
"                        \"style\": 0," +
"                        \"name\": \"Inferno\"," +
"                        \"tier_current\": 0," +
"                        \"num_units\": 2" +
"                    }," +
"                    {" +
"                        \"tier_total\": 2," +
"                        \"style\": 3," +
"                        \"name\": \"Mystic\"," +
"                        \"tier_current\": 2," +
"                        \"num_units\": 4" +
"                    }," +
"                    {" +
"                        \"tier_total\": 3," +
"                        \"style\": 0," +
"                        \"name\": \"Ocean\"," +
"                        \"tier_current\": 0," +
"                        \"num_units\": 1" +
"                    }," +
"                    {" +
"                        \"tier_total\": 2," +
"                        \"style\": 0," +
"                        \"name\": \"Set2_Assassin\"," +
"                        \"tier_current\": 0," +
"                        \"num_units\": 1" +
"                    }," +
"                    {" +
"                        \"tier_total\": 3," +
"                        \"style\": 2," +
"                        \"name\": \"Set2_Blademaster\"," +
"                        \"tier_current\": 2," +
"                        \"num_units\": 4" +
"                    }," +
"                    {" +
"                        \"tier_total\": 2," +
"                        \"style\": 0," +
"                        \"name\": \"Shadow\"," +
"                        \"tier_current\": 0," +
"                        \"num_units\": 1" +
"                    }," +
"                    {" +
"                        \"tier_total\": 2," +
"                        \"style\": 0," +
"                        \"name\": \"Summoner\"," +
"                        \"tier_current\": 0," +
"                        \"num_units\": 1" +
"                    }," +
"                    {" +
"                        \"tier_total\": 3," +
"                        \"style\": 1," +
"                        \"name\": \"Warden\"," +
"                        \"tier_current\": 1," +
"                        \"num_units\": 2" +
"                    }," +
"                    {" +
"                        \"tier_total\": 3," +
"                        \"style\": 2," +
"                        \"name\": \"Wind\"," +
"                        \"tier_current\": 2," +
"                        \"num_units\": 3" +
"                    }" +
"                ]," +
"                \"players_eliminated\": 2," +
"                \"puuid\": \"VHGeogphkgSPD1ULP98RsDsai5EDw98kciOTkqFICz96v1aukfARPYD9GhiBjg6lGxW4P4w9wd_gFA\"," +
"                \"total_damage_to_players\": 214," +
"                \"units\": [" +
"                    {" +
"                        \"tier\": 2," +
"                        \"items\": []," +
"                        \"character_id\": \"TFT2_Leona\"," +
"                        \"name\": \"\"," +
"                        \"rarity\": 0" +
"                    }," +
"                    {" +
"                        \"tier\": 2," +
"                        \"items\": []," +
"                        \"character_id\": \"TFT2_Yasuo\"," +
"                        \"name\": \"Yasuo\"," +
"                        \"rarity\": 1" +
"                    }," +
"                    {" +
"                        \"tier\": 2," +
"                        \"items\": [" +
"                            28," +
"                            39," +
"                            35" +
"                        ]," +
"                        \"character_id\": \"TFT2_Azir\"," +
"                        \"name\": \"Azir\"," +
"                        \"rarity\": 2" +
"                    }," +
"                    {" +
"                        \"tier\": 2," +
"                        \"items\": [" +
"                            19," +
"                            57," +
"                            69" +
"                        ]," +
"                        \"character_id\": \"TFT2_Sivir\"," +
"                        \"name\": \"Sivir\"," +
"                        \"rarity\": 2" +
"                    }," +
"                    {" +
"                        \"tier\": 2," +
"                        \"items\": [" +
"                            38" +
"                        ]," +
"                        \"character_id\": \"TFT2_QiyanaWind\"," +
"                        \"name\": \"Qiyana\"," +
"                        \"rarity\": 2" +
"                    }," +
"                    {" +
"                        \"tier\": 2," +
"                        \"items\": []," +
"                        \"character_id\": \"TFT2_Karma\"," +
"                        \"name\": \"\"," +
"                        \"rarity\": 2" +
"                    }," +
"                    {" +
"                        \"tier\": 2," +
"                        \"items\": [" +
"                            10204," +
"                            8" +
"                        ]," +
"                        \"character_id\": \"TFT2_Janna\"," +
"                        \"name\": \"Janna\"," +
"                        \"rarity\": 3" +
"                    }," +
"                    {" +
"                        \"tier\": 1," +
"                        \"items\": []," +
"                        \"character_id\": \"TFT2_MasterYi\"," +
"                        \"name\": \"MasterYi\"," +
"                        \"rarity\": 4" +
"                    }," +
"                    {" +
"                        \"tier\": 1," +
"                        \"items\": []," +
"                        \"character_id\": \"TFT2_Nami\"," +
"                        \"name\": \"Nami\"," +
"                        \"rarity\": 4" +
"                    }," +
"                    {" +
"                        \"tier\": 2," +
"                        \"items\": [" +
"                            88," +
"                            10204" +
"                        ]," +
"                        \"character_id\": \"TFT2_Amumu\"," +
"                        \"name\": \"\"," +
"                        \"rarity\": 4" +
"                    }" +
"                ]," +
"                \"gold_left\": 1" +
"            }," +
"            {" +
"                \"placement\": 7," +
"                \"level\": 7," +
"                \"last_round\": 23," +
"                \"time_eliminated\": 1371.453125," +
"                \"companion\": {" +
"                    \"skin_ID\": 1," +
"                    \"content_ID\": \"51308483-ce6c-49e7-9727-aa300827016f\"," +
"                    \"species\": \"PetMiner\"" +
"                }," +
"                \"traits\": [" +
"                    {" +
"                        \"tier_total\": 2," +
"                        \"style\": 1," +
"                        \"name\": \"Crystal\"," +
"                        \"tier_current\": 1," +
"                        \"num_units\": 2" +
"                    }," +
"                    {" +
"                        \"tier_total\": 3," +
"                        \"style\": 1," +
"                        \"name\": \"Inferno\"," +
"                        \"tier_current\": 1," +
"                        \"num_units\": 3" +
"                    }," +
"                    {" +
"                        \"tier_total\": 1," +
"                        \"style\": 0," +
"                        \"name\": \"Mountain\"," +
"                        \"tier_current\": 0," +
"                        \"num_units\": 1" +
"                    }," +
"                    {" +
"                        \"tier_total\": 1," +
"                        \"style\": 0," +
"                        \"name\": \"Poison\"," +
"                        \"tier_current\": 0," +
"                        \"num_units\": 1" +
"                    }," +
"                    {" +
"                        \"tier_total\": 3," +
"                        \"style\": 0," +
"                        \"name\": \"Set2_Glacial\"," +
"                        \"tier_current\": 0," +
"                        \"num_units\": 1" +
"                    }," +
"                    {" +
"                        \"tier_total\": 3," +
"                        \"style\": 2," +
"                        \"name\": \"Set2_Ranger\"," +
"                        \"tier_current\": 2," +
"                        \"num_units\": 4" +
"                    }," +
"                    {" +
"                        \"tier_total\": 2," +
"                        \"style\": 0," +
"                        \"name\": \"Shadow\"," +
"                        \"tier_current\": 0," +
"                        \"num_units\": 1" +
"                    }," +
"                    {" +
"                        \"tier_total\": 3," +
"                        \"style\": 2," +
"                        \"name\": \"Warden\"," +
"                        \"tier_current\": 2," +
"                        \"num_units\": 4" +
"                    }" +
"                ]," +
"                \"players_eliminated\": 0," +
"                \"puuid\": \"qI7aIUNc16Y0dZtYd-Ro08is3_fvOf2H90qSmYBrPtp9rkZm55RMHJPmfgjmMyZQ7SHTHIbEuqAc2g\"," +
"                \"total_damage_to_players\": 34," +
"                \"units\": [" +
"                    {" +
"                        \"tier\": 1," +
"                        \"items\": []," +
"                        \"character_id\": \"TFT2_Braum\"," +
"                        \"name\": \"Braum\"," +
"                        \"rarity\": 1" +
"                    }," +
"                    {" +
"                        \"tier\": 1," +
"                        \"items\": []," +
"                        \"character_id\": \"TFT2_Varus\"," +
"                        \"name\": \"Varus\"," +
"                        \"rarity\": 1" +
"                    }," +
"                    {" +
"                        \"tier\": 2," +
"                        \"items\": []," +
"                        \"character_id\": \"TFT2_Kindred\"," +
"                        \"name\": \"Kindred\"," +
"                        \"rarity\": 2" +
"                    }," +
"                    {" +
"                        \"tier\": 2," +
"                        \"items\": [" +
"                            29," +
"                            9" +
"                        ]," +
"                        \"character_id\": \"TFT2_Twitch\"," +
"                        \"name\": \"Twitch\"," +
"                        \"rarity\": 3" +
"                    }," +
"                    {" +
"                        \"tier\": 2," +
"                        \"items\": [" +
"                            35" +
"                        ]," +
"                        \"character_id\": \"TFT2_Malphite\"," +
"                        \"name\": \"Malphite\"," +
"                        \"rarity\": 3" +
"                    }," +
"                    {" +
"                        \"tier\": 1," +
"                        \"items\": [" +
"                            10204" +
"                        ]," +
"                        \"character_id\": \"TFT2_Ashe\"," +
"                        \"name\": \"Ashe\"," +
"                        \"rarity\": 3" +
"                    }," +
"                    {" +
"                        \"tier\": 1," +
"                        \"items\": [" +
"                            15," +
"                            10204" +
"                        ]," +
"                        \"character_id\": \"TFT2_Taric\"," +
"                        \"name\": \"Taric\"," +
"                        \"rarity\": 4" +
"                    }," +
"                    {" +
"                        \"tier\": 1," +
"                        \"items\": [" +
"                            88," +
"                            37" +
"                        ]," +
"                        \"character_id\": \"TFT2_Amumu\"," +
"                        \"name\": \"\"," +
"                        \"rarity\": 4" +
"                    }" +
"                ]," +
"                \"gold_left\": 5" +
"            }," +
"            {" +
"                \"placement\": 3," +
"                \"level\": 8," +
"                \"last_round\": 33," +
"                \"time_eliminated\": 1919.89794921875," +
"                \"companion\": {" +
"                    \"skin_ID\": 6," +
"                    \"content_ID\": \"aa2cdd4c-108a-4df8-8b0c-70d46cbac86f\"," +
"                    \"species\": \"PetGargoyle\"" +
"                }," +
"                \"traits\": [" +
"                    {" +
"                        \"tier_total\": 1," +
"                        \"style\": 3," +
"                        \"name\": \"Alchemist\"," +
"                        \"tier_current\": 1," +
"                        \"num_units\": 1" +
"                    }," +
"                    {" +
"                        \"tier_total\": 2," +
"                        \"style\": 0," +
"                        \"name\": \"Crystal\"," +
"                        \"tier_current\": 0," +
"                        \"num_units\": 1" +
"                    }," +
"                    {" +
"                        \"tier_total\": 3," +
"                        \"style\": 1," +
"                        \"name\": \"Inferno\"," +
"                        \"tier_current\": 1," +
"                        \"num_units\": 3" +
"                    }," +
"                    {" +
"                        \"tier_total\": 3," +
"                        \"style\": 0," +
"                        \"name\": \"Light\"," +
"                        \"tier_current\": 0," +
"                        \"num_units\": 1" +
"                    }," +
"                    {" +
"                        \"tier_total\": 3," +
"                        \"style\": 1," +
"                        \"name\": \"Ocean\"," +
"                        \"tier_current\": 1," +
"                        \"num_units\": 2" +
"                    }," +
"                    {" +
"                        \"tier_total\": 1," +
"                        \"style\": 0," +
"                        \"name\": \"Poison\"," +
"                        \"tier_current\": 0," +
"                        \"num_units\": 1" +
"                    }," +
"                    {" +
"                        \"tier_total\": 2," +
"                        \"style\": 1," +
"                        \"name\": \"Summoner\"," +
"                        \"tier_current\": 1," +
"                        \"num_units\": 3" +
"                    }," +
"                    {" +
"                        \"tier_total\": 3," +
"                        \"style\": 1," +
"                        \"name\": \"Warden\"," +
"                        \"tier_current\": 1," +
"                        \"num_units\": 3" +
"                    }" +
"                ]," +
"                \"players_eliminated\": 1," +
"                \"puuid\": \"FSRhSXYE2fFrjSuuRI-2XLJQ7ZrbHZtCzlZDb34YVTx3ScFCVA1MTzJE2hmaQUWAeQ7tjLLCIJwBlg\"," +
"                \"total_damage_to_players\": 106," +
"                \"units\": [" +
"                    {" +
"                        \"tier\": 2," +
"                        \"items\": [" +
"                            29," +
"                            1," +
"                            22" +
"                        ]," +
"                        \"character_id\": \"TFT2_Zyra\"," +
"                        \"name\": \"Zyra\"," +
"                        \"rarity\": 0" +
"                    }," +
"                    {" +
"                        \"tier\": 2," +
"                        \"items\": []," +
"                        \"character_id\": \"TFT2_Thresh\"," +
"                        \"name\": \"Thresh\"," +
"                        \"rarity\": 1" +
"                    }," +
"                    {" +
"                        \"tier\": 2," +
"                        \"items\": [" +
"                            10204" +
"                        ]," +
"                        \"character_id\": \"TFT2_Nautilus\"," +
"                        \"name\": \"Nautilus\"," +
"                        \"rarity\": 2" +
"                    }," +
"                    {" +
"                        \"tier\": 2," +
"                        \"items\": [" +
"                            26," +
"                            15," +
"                            14" +
"                        ]," +
"                        \"character_id\": \"TFT2_Yorick\"," +
"                        \"name\": \"Yorick\"," +
"                        \"rarity\": 3" +
"                    }," +
"                    {" +
"                        \"tier\": 2," +
"                        \"items\": [" +
"                            10204" +
"                        ]," +
"                        \"character_id\": \"TFT2_Annie\"," +
"                        \"name\": \"Annie\"," +
"                        \"rarity\": 3" +
"                    }," +
"                    {" +
"                        \"tier\": 1," +
"                        \"items\": []," +
"                        \"character_id\": \"TFT2_Taric\"," +
"                        \"name\": \"Taric\"," +
"                        \"rarity\": 4" +
"                    }," +
"                    {" +
"                        \"tier\": 1," +
"                        \"items\": []," +
"                        \"character_id\": \"TFT2_Taric\"," +
"                        \"name\": \"Taric\"," +
"                        \"rarity\": 4" +
"                    }," +
"                    {" +
"                        \"tier\": 1," +
"                        \"items\": [" +
"                            37," +
"                            38" +
"                        ]," +
"                        \"character_id\": \"TFT2_Singed\"," +
"                        \"name\": \"Singed\"," +
"                        \"rarity\": 4" +
"                    }" +
"                ]," +
"                \"gold_left\": 1" +
"            }," +
"            {" +
"                \"placement\": 5," +
"                \"level\": 8," +
"                \"last_round\": 30," +
"                \"time_eliminated\": 1747.2261962890625," +
"                \"companion\": {" +
"                    \"skin_ID\": 1," +
"                    \"content_ID\": \"eb78f626-c11a-480e-adeb-ed68afec8f81\"," +
"                    \"species\": \"PetGriffin\"" +
"                }," +
"                \"traits\": [" +
"                    {" +
"                        \"tier_total\": 1," +
"                        \"style\": 3," +
"                        \"name\": \"Avatar\"," +
"                        \"tier_current\": 1," +
"                        \"num_units\": 1" +
"                    }," +
"                    {" +
"                        \"tier_total\": 3," +
"                        \"style\": 0," +
"                        \"name\": \"Electric\"," +
"                        \"tier_current\": 0," +
"                        \"num_units\": 1" +
"                    }," +
"                    {" +
"                        \"tier_total\": 3," +
"                        \"style\": 1," +
"                        \"name\": \"Light\"," +
"                        \"tier_current\": 1," +
"                        \"num_units\": 3" +
"                    }," +
"                    {" +
"                        \"tier_total\": 2," +
"                        \"style\": 0," +
"                        \"name\": \"Mage\"," +
"                        \"tier_current\": 0," +
"                        \"num_units\": 1" +
"                    }," +
"                    {" +
"                        \"tier_total\": 1," +
"                        \"style\": 0," +
"                        \"name\": \"Mountain\"," +
"                        \"tier_current\": 0," +
"                        \"num_units\": 1" +
"                    }," +
"                    {" +
"                        \"tier_total\": 3," +
"                        \"style\": 1," +
"                        \"name\": \"Ocean\"," +
"                        \"tier_current\": 1," +
"                        \"num_units\": 3" +
"                    }," +
"                    {" +
"                        \"tier_total\": 3," +
"                        \"style\": 0," +
"                        \"name\": \"Set2_Blademaster\"," +
"                        \"tier_current\": 0," +
"                        \"num_units\": 1" +
"                    }," +
"                    {" +
"                        \"tier_total\": 2," +
"                        \"style\": 0," +
"                        \"name\": \"Summoner\"," +
"                        \"tier_current\": 0," +
"                        \"num_units\": 1" +
"                    }," +
"                    {" +
"                        \"tier_total\": 3," +
"                        \"style\": 2," +
"                        \"name\": \"Warden\"," +
"                        \"tier_current\": 2," +
"                        \"num_units\": 4" +
"                    }," +
"                    {" +
"                        \"tier_total\": 3," +
"                        \"style\": 0," +
"                        \"name\": \"Wind\"," +
"                        \"tier_current\": 0," +
"                        \"num_units\": 1" +
"                    }" +
"                ]," +
"                \"players_eliminated\": 1," +
"                \"puuid\": \"YHUtu4nCGjpUKsJc-FrrE03BRKNO-myXINqY3sZWXjXQEHFdI5ryy2SaBsAhBvP-_EkyeqaOBsh2kQ\"," +
"                \"total_damage_to_players\": 69," +
"                \"units\": [" +
"                    {" +
"                        \"tier\": 1," +
"                        \"items\": []," +
"                        \"character_id\": \"TFT2_Ornn\"," +
"                        \"name\": \"Ornn\"," +
"                        \"rarity\": 0" +
"                    }," +
"                    {" +
"                        \"tier\": 1," +
"                        \"items\": []," +
"                        \"character_id\": \"TFT2_Yasuo\"," +
"                        \"name\": \"Yasuo\"," +
"                        \"rarity\": 1" +
"                    }," +
"                    {" +
"                        \"tier\": 2," +
"                        \"items\": []," +
"                        \"character_id\": \"TFT2_Thresh\"," +
"                        \"name\": \"Thresh\"," +
"                        \"rarity\": 1" +
"                    }," +
"                    {" +
"                        \"tier\": 2," +
"                        \"items\": [" +
"                            10204," +
"                            23" +
"                        ]," +
"                        \"character_id\": \"TFT2_Syndra\"," +
"                        \"name\": \"Syndra\"," +
"                        \"rarity\": 1" +
"                    }," +
"                    {" +
"                        \"tier\": 2," +
"                        \"items\": []," +
"                        \"character_id\": \"TFT2_Nautilus\"," +
"                        \"name\": \"Nautilus\"," +
"                        \"rarity\": 2" +
"                    }," +
"                    {" +
"                        \"tier\": 1," +
"                        \"items\": [" +
"                            22" +
"                        ]," +
"                        \"character_id\": \"TFT2_Yorick\"," +
"                        \"name\": \"Yorick\"," +
"                        \"rarity\": 3" +
"                    }," +
"                    {" +
"                        \"tier\": 2," +
"                        \"items\": [" +
"                            10204," +
"                            36" +
"                        ]," +
"                        \"character_id\": \"TFT2_Malphite\"," +
"                        \"name\": \"Malphite\"," +
"                        \"rarity\": 3" +
"                    }," +
"                    {" +
"                        \"tier\": 2," +
"                        \"items\": [" +
"                            37," +
"                            44," +
"                            39" +
"                        ]," +
"                        \"character_id\": \"TFT2_LuxLight\"," +
"                        \"name\": \"Lux\"," +
"                        \"rarity\": 5" +
"                    }" +
"                ]," +
"                \"gold_left\": 0" +
"            }," +
"            {" +
"                \"placement\": 2," +
"                \"level\": 8," +
"                \"last_round\": 37," +
"                \"time_eliminated\": 2114.0556640625," +
"                \"companion\": {" +
"                    \"skin_ID\": 1," +
"                    \"content_ID\": \"3ae85287-a4c0-4076-be3b-5c76951b2790\"," +
"                    \"species\": \"PetAkaliDragon\"" +
"                }," +
"                \"traits\": [" +
"                    {" +
"                        \"tier_total\": 1," +
"                        \"style\": 0," +
"                        \"name\": \"Celestial\"," +
"                        \"tier_current\": 0," +
"                        \"num_units\": 1" +
"                    }," +
"                    {" +
"                        \"tier_total\": 2," +
"                        \"style\": 1," +
"                        \"name\": \"Desert\"," +
"                        \"tier_current\": 1," +
"                        \"num_units\": 2" +
"                    }," +
"                    {" +
"                        \"tier_total\": 1," +
"                        \"style\": 0," +
"                        \"name\": \"Mountain\"," +
"                        \"tier_current\": 0," +
"                        \"num_units\": 1" +
"                    }," +
"                    {" +
"                        \"tier_total\": 2," +
"                        \"style\": 3," +
"                        \"name\": \"Mystic\"," +
"                        \"tier_current\": 2," +
"                        \"num_units\": 4" +
"                    }," +
"                    {" +
"                        \"tier_total\": 3," +
"                        \"style\": 0," +
"                        \"name\": \"Ocean\"," +
"                        \"tier_current\": 0," +
"                        \"num_units\": 1" +
"                    }," +
"                    {" +
"                        \"tier_total\": 3," +
"                        \"style\": 2," +
"                        \"name\": \"Set2_Blademaster\"," +
"                        \"tier_current\": 2," +
"                        \"num_units\": 4" +
"                    }," +
"                    {" +
"                        \"tier_total\": 2," +
"                        \"style\": 0," +
"                        \"name\": \"Shadow\"," +
"                        \"tier_current\": 0," +
"                        \"num_units\": 1" +
"                    }," +
"                    {" +
"                        \"tier_total\": 2," +
"                        \"style\": 0," +
"                        \"name\": \"Summoner\"," +
"                        \"tier_current\": 0," +
"                        \"num_units\": 1" +
"                    }," +
"                    {" +
"                        \"tier_total\": 3," +
"                        \"style\": 0," +
"                        \"name\": \"Warden\"," +
"                        \"tier_current\": 0," +
"                        \"num_units\": 1" +
"                    }," +
"                    {" +
"                        \"tier_total\": 3," +
"                        \"style\": 1," +
"                        \"name\": \"Wind\"," +
"                        \"tier_current\": 1," +
"                        \"num_units\": 2" +
"                    }" +
"                ]," +
"                \"players_eliminated\": 2," +
"                \"puuid\": \"GaqVGoyjW_o775X-QQt5xsdU_EfBgeoG-_fGMFwdk65t1IqEAyA088A0uImtYrmJGYowMam1eFwIjw\"," +
"                \"total_damage_to_players\": 156," +
"                \"units\": [" +
"                    {" +
"                        \"tier\": 2," +
"                        \"items\": []," +
"                        \"character_id\": \"TFT2_Yasuo\"," +
"                        \"name\": \"Yasuo\"," +
"                        \"rarity\": 1" +
"                    }," +
"                    {" +
"                        \"tier\": 2," +
"                        \"items\": [" +
"                            28," +
"                            14," +
"                            49" +
"                        ]," +
"                        \"character_id\": \"TFT2_Azir\"," +
"                        \"name\": \"Azir\"," +
"                        \"rarity\": 2" +
"                    }," +
"                    {" +
"                        \"tier\": 2," +
"                        \"items\": [" +
"                            19," +
"                            19," +
"                            46" +
"                        ]," +
"                        \"character_id\": \"TFT2_Sivir\"," +
"                        \"name\": \"Sivir\"," +
"                        \"rarity\": 2" +
"                    }," +
"                    {" +
"                        \"tier\": 2," +
"                        \"items\": []," +
"                        \"character_id\": \"TFT2_Karma\"," +
"                        \"name\": \"\"," +
"                        \"rarity\": 2" +
"                    }," +
"                    {" +
"                        \"tier\": 2," +
"                        \"items\": [" +
"                            10204," +
"                            79," +
"                            7" +
"                        ]," +
"                        \"character_id\": \"TFT2_Malphite\"," +
"                        \"name\": \"Malphite\"," +
"                        \"rarity\": 3" +
"                    }," +
"                    {" +
"                        \"tier\": 2," +
"                        \"items\": []," +
"                        \"character_id\": \"TFT2_Janna\"," +
"                        \"name\": \"Janna\"," +
"                        \"rarity\": 3" +
"                    }," +
"                    {" +
"                        \"tier\": 2," +
"                        \"items\": [" +
"                            99" +
"                        ]," +
"                        \"character_id\": \"TFT2_MasterYi\"," +
"                        \"name\": \"MasterYi\"," +
"                        \"rarity\": 4" +
"                    }," +
"                    {" +
"                        \"tier\": 2," +
"                        \"items\": [" +
"                            10006," +
"                            10006," +
"                            10204" +
"                        ]," +
"                        \"character_id\": \"TFT2_Nami\"," +
"                        \"name\": \"Nami\"," +
"                        \"rarity\": 4" +
"                    }" +
"                ]," +
"                \"gold_left\": 30" +
"            }," +
"            {" +
"                \"placement\": 4," +
"                \"level\": 8," +
"                \"last_round\": 33," +
"                \"time_eliminated\": 1916.132080078125," +
"                \"companion\": {" +
"                    \"skin_ID\": 1," +
"                    \"content_ID\": \"51308483-ce6c-49e7-9727-aa300827016f\"," +
"                    \"species\": \"PetMiner\"" +
"                }," +
"                \"traits\": [" +
"                    {" +
"                        \"tier_total\": 2," +
"                        \"style\": 3," +
"                        \"name\": \"Berserker\"," +
"                        \"tier_current\": 2," +
"                        \"num_units\": 6" +
"                    }," +
"                    {" +
"                        \"tier_total\": 2," +
"                        \"style\": 1," +
"                        \"name\": \"Desert\"," +
"                        \"tier_current\": 1," +
"                        \"num_units\": 2" +
"                    }," +
"                    {" +
"                        \"tier_total\": 3," +
"                        \"style\": 0," +
"                        \"name\": \"Electric\"," +
"                        \"tier_current\": 0," +
"                        \"num_units\": 1" +
"                    }," +
"                    {" +
"                        \"tier_total\": 3," +
"                        \"style\": 0," +
"                        \"name\": \"Light\"," +
"                        \"tier_current\": 0," +
"                        \"num_units\": 1" +
"                    }," +
"                    {" +
"                        \"tier_total\": 1," +
"                        \"style\": 0," +
"                        \"name\": \"Poison\"," +
"                        \"tier_current\": 0," +
"                        \"num_units\": 1" +
"                    }," +
"                    {" +
"                        \"tier_total\": 2," +
"                        \"style\": 1," +
"                        \"name\": \"Set2_Assassin\"," +
"                        \"tier_current\": 1," +
"                        \"num_units\": 3" +
"                    }," +
"                    {" +
"                        \"tier_total\": 3," +
"                        \"style\": 1," +
"                        \"name\": \"Set2_Glacial\"," +
"                        \"tier_current\": 1," +
"                        \"num_units\": 2" +
"                    }," +
"                    {" +
"                        \"tier_total\": 2," +
"                        \"style\": 0," +
"                        \"name\": \"Shadow\"," +
"                        \"tier_current\": 0," +
"                        \"num_units\": 1" +
"                    }," +
"                    {" +
"                        \"tier_total\": 3," +
"                        \"style\": 0," +
"                        \"name\": \"Wind\"," +
"                        \"tier_current\": 0," +
"                        \"num_units\": 1" +
"                    }" +
"                ]," +
"                \"players_eliminated\": 0," +
"                \"puuid\": \"ANGaE3-zLjRCQHPdJLR3TxxUKOmJnllOiYYMYBok9j7S6KcDfeyhzKK5_xL3NVlsZM0HHwjQfXnaPA\"," +
"                \"total_damage_to_players\": 102," +
"                \"units\": [" +
"                    {" +
"                        \"tier\": 2," +
"                        \"items\": []," +
"                        \"character_id\": \"TFT2_Renekton\"," +
"                        \"name\": \"Renekton\"," +
"                        \"rarity\": 0" +
"                    }," +
"                    {" +
"                        \"tier\": 1," +
"                        \"items\": [" +
"                            46" +
"                        ]," +
"                        \"character_id\": \"TFT2_Jax\"," +
"                        \"name\": \"Jax\"," +
"                        \"rarity\": 1" +
"                    }," +
"                    {" +
"                        \"tier\": 2," +
"                        \"items\": []," +
"                        \"character_id\": \"TFT2_Volibear\"," +
"                        \"name\": \"Volibear\"," +
"                        \"rarity\": 1" +
"                    }," +
"                    {" +
"                        \"tier\": 2," +
"                        \"items\": [" +
"                            35" +
"                        ]," +
"                        \"character_id\": \"TFT2_DrMundo\"," +
"                        \"name\": \"DrMundo\"," +
"                        \"rarity\": 2" +
"                    }," +
"                    {" +
"                        \"tier\": 2," +
"                        \"items\": []," +
"                        \"character_id\": \"TFT2_Sion\"," +
"                        \"name\": \"Sion\"," +
"                        \"rarity\": 2" +
"                    }," +
"                    {" +
"                        \"tier\": 2," +
"                        \"items\": [" +
"                            6," +
"                            45" +
"                        ]," +
"                        \"character_id\": \"TFT2_QiyanaWind\"," +
"                        \"name\": \"Qiyana\"," +
"                        \"rarity\": 2" +
"                    }," +
"                    {" +
"                        \"tier\": 2," +
"                        \"items\": [" +
"                            18," +
"                            22," +
"                            19" +
"                        ]," +
"                        \"character_id\": \"TFT2_Olaf\"," +
"                        \"name\": \"Olaf\"," +
"                        \"rarity\": 3" +
"                    }," +
"                    {" +
"                        \"tier\": 2," +
"                        \"items\": [" +
"                            10204," +
"                            45," +
"                            19" +
"                        ]," +
"                        \"character_id\": \"TFT2_Khazix\"," +
"                        \"name\": \"Khazix\"," +
"                        \"rarity\": 3" +
"                    }" +
"                ]," +
"                \"gold_left\": 39" +
"            }," +
"            {" +
"                \"placement\": 6," +
"                \"level\": 8," +
"                \"last_round\": 27," +
"                \"time_eliminated\": 1591.910400390625," +
"                \"companion\": {" +
"                    \"skin_ID\": 1," +
"                    \"content_ID\": \"5897ad9f-4665-4372-8f3e-6c878adb8918\"," +
"                    \"species\": \"PetTFTAvatar\"" +
"                }," +
"                \"traits\": [" +
"                    {" +
"                        \"tier_total\": 1," +
"                        \"style\": 3," +
"                        \"name\": \"Alchemist\"," +
"                        \"tier_current\": 1," +
"                        \"num_units\": 1" +
"                    }," +
"                    {" +
"                        \"tier_total\": 2," +
"                        \"style\": 0," +
"                        \"name\": \"Berserker\"," +
"                        \"tier_current\": 0," +
"                        \"num_units\": 1" +
"                    }," +
"                    {" +
"                        \"tier_total\": 1," +
"                        \"style\": 3," +
"                        \"name\": \"Celestial\"," +
"                        \"tier_current\": 1," +
"                        \"num_units\": 2" +
"                    }," +
"                    {" +
"                        \"tier_total\": 2," +
"                        \"style\": 0," +
"                        \"name\": \"Crystal\"," +
"                        \"tier_current\": 0," +
"                        \"num_units\": 1" +
"                    }," +
"                    {" +
"                        \"tier_total\": 3," +
"                        \"style\": 0," +
"                        \"name\": \"Inferno\"," +
"                        \"tier_current\": 0," +
"                        \"num_units\": 2" +
"                    }," +
"                    {" +
"                        \"tier_total\": 2," +
"                        \"style\": 0," +
"                        \"name\": \"Mystic\"," +
"                        \"tier_current\": 0," +
"                        \"num_units\": 1" +
"                    }," +
"                    {" +
"                        \"tier_total\": 1," +
"                        \"style\": 3," +
"                        \"name\": \"Poison\"," +
"                        \"tier_current\": 1," +
"                        \"num_units\": 3" +
"                    }," +
"                    {" +
"                        \"tier_total\": 3," +
"                        \"style\": 2," +
"                        \"name\": \"Set2_Ranger\"," +
"                        \"tier_current\": 2," +
"                        \"num_units\": 4" +
"                    }," +
"                    {" +
"                        \"tier_total\": 2," +
"                        \"style\": 0," +
"                        \"name\": \"Shadow\"," +
"                        \"tier_current\": 0," +
"                        \"num_units\": 1" +
"                    }," +
"                    {" +
"                        \"tier_total\": 3," +
"                        \"style\": 0," +
"                        \"name\": \"Warden\"," +
"                        \"tier_current\": 0," +
"                        \"num_units\": 1" +
"                    }" +
"                ]," +
"                \"players_eliminated\": 0," +
"                \"puuid\": \"x3H3Y4y0So_MuRW5daxB9Fof7CasG7yQSrwwMzJLDifYuUlUON6hnu_Np7L6yMgtfxppykmo5_T0TA\"," +
"                \"total_damage_to_players\": 56," +
"                \"units\": [" +
"                    {" +
"                        \"tier\": 2," +
"                        \"items\": []," +
"                        \"character_id\": \"TFT2_Leona\"," +
"                        \"name\": \"\"," +
"                        \"rarity\": 0" +
"                    }," +
"                    {" +
"                        \"tier\": 2," +
"                        \"items\": []," +
"                        \"character_id\": \"TFT2_Varus\"," +
"                        \"name\": \"Varus\"," +
"                        \"rarity\": 1" +
"                    }," +
"                    {" +
"                        \"tier\": 2," +
"                        \"items\": []," +
"                        \"character_id\": \"TFT2_DrMundo\"," +
"                        \"name\": \"DrMundo\"," +
"                        \"rarity\": 2" +
"                    }," +
"                    {" +
"                        \"tier\": 2," +
"                        \"items\": [" +
"                            10204" +
"                        ]," +
"                        \"character_id\": \"TFT2_Kindred\"," +
"                        \"name\": \"Kindred\"," +
"                        \"rarity\": 2" +
"                    }," +
"                    {" +
"                        \"tier\": 2," +
"                        \"items\": [" +
"                            6" +
"                        ]," +
"                        \"character_id\": \"TFT2_Karma\"," +
"                        \"name\": \"\"," +
"                        \"rarity\": 2" +
"                    }," +
"                    {" +
"                        \"tier\": 1," +
"                        \"items\": [" +
"                            29," +
"                            69" +
"                        ]," +
"                        \"character_id\": \"TFT2_Twitch\"," +
"                        \"name\": \"Twitch\"," +
"                        \"rarity\": 3" +
"                    }," +
"                    {" +
"                        \"tier\": 2," +
"                        \"items\": [" +
"                            22," +
"                            24" +
"                        ]," +
"                        \"character_id\": \"TFT2_Ashe\"," +
"                        \"name\": \"Ashe\"," +
"                        \"rarity\": 3" +
"                    }," +
"                    {" +
"                        \"tier\": 1," +
"                        \"items\": [" +
"                            10204," +
"                            55" +
"                        ]," +
"                        \"character_id\": \"TFT2_Singed\"," +
"                        \"name\": \"Singed\"," +
"                        \"rarity\": 4" +
"                    }" +
"                ]," +
"                \"gold_left\": 0" +
"            }," +
"            {" +
"                \"placement\": 8," +
"                \"level\": 6," +
"                \"last_round\": 14," +
"                \"time_eliminated\": 813.5393676757812," +
"                \"companion\": {" +
"                    \"skin_ID\": 13," +
"                    \"content_ID\": \"fcd5425d-9a58-43f1-bd7f-f73541e415f8\"," +
"                    \"species\": \"PetTurtle\"" +
"                }," +
"                \"traits\": [" +
"                    {" +
"                        \"tier_total\": 2," +
"                        \"style\": 0," +
"                        \"name\": \"Desert\"," +
"                        \"tier_current\": 0," +
"                        \"num_units\": 1" +
"                    }," +
"                    {" +
"                        \"tier_total\": 3," +
"                        \"style\": 0," +
"                        \"name\": \"Light\"," +
"                        \"tier_current\": 0," +
"                        \"num_units\": 1" +
"                    }," +
"                    {" +
"                        \"tier_total\": 2," +
"                        \"style\": 1," +
"                        \"name\": \"Mage\"," +
"                        \"tier_current\": 1," +
"                        \"num_units\": 3" +
"                    }," +
"                    {" +
"                        \"tier_total\": 1," +
"                        \"style\": 0," +
"                        \"name\": \"Mountain\"," +
"                        \"tier_current\": 0," +
"                        \"num_units\": 1" +
"                    }," +
"                    {" +
"                        \"tier_total\": 3," +
"                        \"style\": 1," +
"                        \"name\": \"Ocean\"," +
"                        \"tier_current\": 1," +
"                        \"num_units\": 3" +
"                    }," +
"                    {" +
"                        \"tier_total\": 2," +
"                        \"style\": 0," +
"                        \"name\": \"Summoner\"," +
"                        \"tier_current\": 0," +
"                        \"num_units\": 2" +
"                    }," +
"                    {" +
"                        \"tier_total\": 3," +
"                        \"style\": 0," +
"                        \"name\": \"Warden\"," +
"                        \"tier_current\": 0," +
"                        \"num_units\": 1" +
"                    }" +
"                ]," +
"                \"players_eliminated\": 0," +
"                \"puuid\": \"WdpK-ZPi9SoG4028kw6Gnh2G5xWvfKlLR0YeIFefkPOUiEMkcxQXUFLCii-c7pbuSkR-LwmeyqJU5w\"," +
"                \"total_damage_to_players\": 0," +
"                \"units\": [" +
"                    {" +
"                        \"tier\": 1," +
"                        \"items\": []," +
"                        \"character_id\": \"TFT2_Ivern\"," +
"                        \"name\": \"Ivern\"," +
"                        \"rarity\": 0" +
"                    }," +
"                    {" +
"                        \"tier\": 1," +
"                        \"items\": []," +
"                        \"character_id\": \"TFT2_Vladimir\"," +
"                        \"name\": \"Vladimir\"," +
"                        \"rarity\": 0" +
"                    }," +
"                    {" +
"                        \"tier\": 1," +
"                        \"items\": []," +
"                        \"character_id\": \"TFT2_Neeko\"," +
"                        \"name\": \"Neeko\"," +
"                        \"rarity\": 1" +
"                    }," +
"                    {" +
"                        \"tier\": 1," +
"                        \"items\": []," +
"                        \"character_id\": \"TFT2_Syndra\"," +
"                        \"name\": \"Syndra\"," +
"                        \"rarity\": 1" +
"                    }," +
"                    {" +
"                        \"tier\": 2," +
"                        \"items\": []," +
"                        \"character_id\": \"TFT2_Nautilus\"," +
"                        \"name\": \"Nautilus\"," +
"                        \"rarity\": 2" +
"                    }," +
"                    {" +
"                        \"tier\": 1," +
"                        \"items\": []," +
"                        \"character_id\": \"TFT2_Yorick\"," +
"                        \"name\": \"Yorick\"," +
"                        \"rarity\": 3" +
"                    }" +
"                ]," +
"                \"gold_left\": 0" +
"            }" +
"        ]," +
"        \"tft_set_number\": 2," +
"        \"game_length\": 2122.254638671875," +
"        \"queue_id\": 1100," +
"        \"game_version\": \"Version 10.1.303.9385 (Jan 08 2020/13:40:32) [PUBLIC] <__MAIN__>\"" +
"    }," +
"    \"metadata\": {" +
"        \"data_version\": \"4\"," +
"        \"participants\": [" +
"            \"VHGeogphkgSPD1ULP98RsDsai5EDw98kciOTkqFICz96v1aukfARPYD9GhiBjg6lGxW4P4w9wd_gFA\"," +
"            \"qI7aIUNc16Y0dZtYd-Ro08is3_fvOf2H90qSmYBrPtp9rkZm55RMHJPmfgjmMyZQ7SHTHIbEuqAc2g\"," +
"            \"FSRhSXYE2fFrjSuuRI-2XLJQ7ZrbHZtCzlZDb34YVTx3ScFCVA1MTzJE2hmaQUWAeQ7tjLLCIJwBlg\"," +
"            \"YHUtu4nCGjpUKsJc-FrrE03BRKNO-myXINqY3sZWXjXQEHFdI5ryy2SaBsAhBvP-_EkyeqaOBsh2kQ\"," +
"            \"GaqVGoyjW_o775X-QQt5xsdU_EfBgeoG-_fGMFwdk65t1IqEAyA088A0uImtYrmJGYowMam1eFwIjw\"," +
"            \"ANGaE3-zLjRCQHPdJLR3TxxUKOmJnllOiYYMYBok9j7S6KcDfeyhzKK5_xL3NVlsZM0HHwjQfXnaPA\"," +
"            \"x3H3Y4y0So_MuRW5daxB9Fof7CasG7yQSrwwMzJLDifYuUlUON6hnu_Np7L6yMgtfxppykmo5_T0TA\"," +
"            \"WdpK-ZPi9SoG4028kw6Gnh2G5xWvfKlLR0YeIFefkPOUiEMkcxQXUFLCii-c7pbuSkR-LwmeyqJU5w\"" +
"        ]," +
"        \"match_id\": \"NA1_3270573449\"" +
"    }" +
"}" );
            matchFunction.InsertMatch(match);
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
