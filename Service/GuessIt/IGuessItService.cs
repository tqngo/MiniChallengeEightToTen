using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniChallengeEightToTen.Service;

public interface IGuessItService
{
    string EasyMode(string easy);
    string MediumMode(string medium);
    string HardMode(string hard);

}
