using WaveFunctionCollapseImageGenerator.Models.Cells;
using WaveFunctionCollapseImageGenerator.Models.Simulation.Backtracking;
using WaveFunctionCollapseImageGenerator.Models.Tiles;

namespace WaveFunctionCollapseImageGenerator.Models.Simulation;

public static class WFCSimulationFactory
{
    public static IWFCSimulation CreateSimulation(CellGrid grid, Ruleset ruleset, Random random, bool useBacktracking, int backtrackingStackSize) => useBacktracking
            ? new WaveFunctionCollapseSimulationWithBacktracking(grid, ruleset, random, backtrackingStackSize)
            : new WaveFunctionCollapseSimulation(grid, ruleset, random);
}