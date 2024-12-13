using WaveFunctionCollapseImageGenerator.Models.Cells;
using WaveFunctionCollapseImageGenerator.Models.Tiles;

namespace WaveFunctionCollapseImageGenerator.Models.Simulation;

public interface IWFCSimulation
{
    public CellGrid Grid { get; }
    public Ruleset Ruleset { get; }
    bool IsFinished { get; }

    void Step();
}