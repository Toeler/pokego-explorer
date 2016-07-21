using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonGo.RocketAPI.GeneratedCode;
using static PokemonGo.RocketAPI.GeneratedCode.MapObjectsResponse.Types.Payload.Types;

namespace PokemonGO
{
    internal static class Settings
    {
        internal static readonly string PTC_USERNAME = "Your PTC Username";
        internal static readonly string PTC_PASSWORD = "Your PTC Password";

        internal static readonly int EXPLORATION_STEPS = 40; // Number of steps (increase this to explore a wider area)
        internal static readonly int STEP_DELAY = 1; // Seconds between steps
        internal static readonly int CLEAR_DELAY = 10; // Seconds between clearing map

        internal static readonly string STARTING_LOCATION = "Starting Location"; // Example: Time Square, New York City

        internal static readonly int POKEMON_IMAGE_SIZE = 40;

		internal static readonly IList<PokemonIds> NOTIFICATION_BLACKLIST = new List<PokemonIds> {
			PokemonIds.V0001PokemonBulbasaur,
			PokemonIds.V0004PokemonCharmander,
			PokemonIds.V0007PokemonSquirtle,
			PokemonIds.V0010PokemonCaterpie,
			PokemonIds.V0011PokemonMetapod,
			PokemonIds.V0013PokemonWeedle,
			PokemonIds.V0014PokemonKakuna,
			PokemonIds.V0016PokemonPidgey,
			PokemonIds.V0017PokemonPidgeotto,
			PokemonIds.V0019PokemonRattata,
			PokemonIds.V0020PokemonRaticate,
			PokemonIds.V0021PokemonSpearow,
			PokemonIds.V0023PokemonEkans,
			PokemonIds.V0029PokemonNidoran,
			PokemonIds.V0032PokemonNidoran,
			PokemonIds.V0041PokemonZubat,
			PokemonIds.V0042PokemonGolbat,
			PokemonIds.V0043PokemonOddish,
			PokemonIds.V0046PokemonParas,
			PokemonIds.V0048PokemonVenonat,
			PokemonIds.V0054PokemonPsyduck,
			PokemonIds.V0060PokemonPoliwag,
			PokemonIds.V0069PokemonBellsprout,
			PokemonIds.V0072PokemonTentacool,
			PokemonIds.V0084PokemonDoduo,
			PokemonIds.V0085PokemonDodrio,
			PokemonIds.V0092PokemonGastly,
			PokemonIds.V0098PokemonKrabby,
			PokemonIds.V0099PokemonKingler,
			PokemonIds.V0102PokemonExeggcute,
			PokemonIds.V0109PokemonKoffing,
			PokemonIds.V0114PokemonTangela,
			PokemonIds.V0116PokemonHorsea,
			PokemonIds.V0118PokemonGoldeen,
			PokemonIds.V0120PokemonStaryu,
			PokemonIds.V0127PokemonPinsir,
			PokemonIds.V0129PokemonMagikarp,
			PokemonIds.V0133PokemonEevee
		};
    }
}
