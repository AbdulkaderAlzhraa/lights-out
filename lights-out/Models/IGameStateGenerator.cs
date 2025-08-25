using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IGameStateGenerator
{
    void GenerateSolvableState(List<Button> boardButtons, int rowCount, int columnCount, ref GameRecord currentGameRecord);
}
