using Microsoft.Extensions.Logging;

using WaveFunctionCollapseImageGenerator.Models.Cells;
using WaveFunctionCollapseImageGenerator.Models.Simulation.Backtracking;
using WaveFunctionCollapseImageGenerator.Models.Tiles;

namespace WaveFunctionCollapseImageGenerator.Models.Simulation;

public class WFCSimulationFactory(ILoggerFactory loggerFactory)
{
    private readonly ILoggerFactory _loggerFactory = loggerFactory;

    public IWFCSimulation CreateSimulation(CellGrid grid, Ruleset ruleset, Random random, bool useBacktracking, int backtrackingStackSize) => useBacktracking
            ? new WaveFunctionCollapseSimulationWithBacktracking(grid, ruleset, random, backtrackingStackSize, _loggerFactory.CreateLogger<WaveFunctionCollapseSimulationWithBacktracking>())
            : new WaveFunctionCollapseSimulation(grid, ruleset, random);
}